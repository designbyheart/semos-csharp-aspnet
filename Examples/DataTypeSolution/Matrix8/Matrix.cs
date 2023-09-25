using System;
using System.Diagnostics;

namespace Matrix8 {
  class Matrix {
    readonly int[,] cells;
    public Matrix(uint nRow, uint nCol, params int[] items) {
      Debug.Assert(nRow > 0, "# of Rows must be > 0");
      Debug.Assert(nCol > 0, "# of Columns must be > 0");
      Debug.Assert(items != null, "cell values must be specified");
      Debug.Assert((nRow * nCol) == items.Length, "Invalid # of cell values");
      cells = new int[nRow, nCol];
      for (int i = 0; i < items.Length; i++) {
        cells[i / nCol, i % nCol] = items[i];
      }
    }
    private Matrix(int[,] items) {
      cells = items;
    }
    public uint NRow {
      get {
        return (uint)cells.GetLength(0);
      }
    }
    public uint NCol {
      get {
        return (uint)cells.GetLength(1);
      }
    }

    static public Matrix operator *(Matrix lhs, Matrix rhs) {
      if (lhs.NCol != rhs.NRow) throw new Exception("Cannot multiply-lah!");
      int[,] m = new int[lhs.NRow, rhs.NCol];
      for (int r = 0; r < m.GetLength(0); r++) {
        for (int c = 0; c < m.GetLength(1); c++) {
          for (int i = 0; i < rhs.NRow; i++) {
            m[r, c] += lhs.cells[r, i] * rhs.cells[i, c];
          }
        }
      }
      return new Matrix(m);
    }
    static public Matrix operator +(Matrix lhs, Matrix rhs) {
      if (lhs.NRow != rhs.NRow) throw new Exception("Not the same # of Rows!");
      if (lhs.NCol != rhs.NCol) throw new Exception("Not the same # of Columns!");
      int[,] m = new int[lhs.NRow, lhs.NCol];
      for (int r = 0; r < m.GetLength(0); r++) {
        for (int c = 0; c < m.GetLength(1); c++) {
          m[r, c] = lhs.cells[r, c] + rhs.cells[r, c];
        }
      }
      return new Matrix(m);
    }
    static public Matrix operator ~(Matrix rhs) {
      int[,] m = new int[rhs.NCol, rhs.NRow];
      for (int r = 0; r < m.GetLength(0); r++) {
        for (int c = 0; c < m.GetLength(1); c++) {
          m[r, c] = rhs.cells[c, r];
        }
      }
      return new Matrix(m);
    }
    static public Matrix operator *(Matrix lhs, int rhs) {
      int[,] m = new int[lhs.NRow, lhs.NCol];
      for (int r = 0; r < m.GetLength(0); r++) {
        for (int c = 0; c < m.GetLength(1); c++) {
          m[r, c] = lhs.cells[r, c] * rhs;
        }
      }
      return new Matrix(m);
    }
    static public Matrix operator *(int lhs, Matrix rhs) {
      return rhs * lhs;
    }
    public override string ToString() {
      var s = new System.Text.StringBuilder("");
      for (uint r = 0; r < NRow; r++) {
        for (uint c = 0; c < NCol; c++)
          s.Append(String.Format("\t{0}", cells[r, c]));
        s.Append('\n');
      }
      s.Append('\n');
      return s.ToString();
    }
    //indexer
    public int this[uint r, uint c] {
      get {
        if (r >= NRow) throw new Exception("Row out of bound");
        if (c >= NCol) throw new Exception("Column out of bound");
        return cells[r, c];
      }
      set {
        if (r >= NRow) throw new Exception("Row out of bound");
        if (c >= NCol) throw new Exception("Column out of bound");
        cells[r, c] = value;
      }
    }
    public int this[uint n] {
      get {
        if (n >= (NRow*NCol)) throw new Exception("Index out of bound");
        return cells[n / NCol, n % NCol];
      }
      set {
        if (n >= (NRow * NCol)) throw new Exception("Index out of bound");
        cells[n / NCol, n % NCol] = value;
      }
    }
    public int this[string which] {
      get {
        switch(which.ToUpper()){
          case "FIRST": return cells[0, 0];
          case "LAST": return cells[NRow - 1, NCol - 1];
        }
        throw new Exception("Invalid parameter " + which);
      }
      set {
        switch (which.ToUpper()) {
          case "FIRST": 
            cells[0, 0] = value;
            break;
          case "LAST": 
            cells[NRow - 1, NCol - 1] = value;
            break;
          default:
            throw new Exception("Invalid paramter " + which);
        }
      }
    }
    static public bool operator ==(Matrix lhs, Matrix rhs) {
      if (lhs.NRow != rhs.NRow) return false;
      if (lhs.NCol != rhs.NCol) return false;
      for (int r = 0; r < lhs.NRow; r++) {
        for (int c = 0; c < lhs.NCol; c++)
          if (lhs.cells[r, c] != rhs.cells[r, c]) return false;
      }
      return true;
    }
    static public bool operator !=(Matrix lhs, Matrix rhs) {
      return !(lhs == rhs);
    }
    public override bool Equals(object obj) {
      return this == (Matrix)obj;
    }

  }
}
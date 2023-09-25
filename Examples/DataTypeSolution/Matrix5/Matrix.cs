using System;
using System.Diagnostics;

namespace Matrix5 {
  class Matrix {
    readonly int[,] cells;
    public Matrix(uint nRow, uint nCol, params int[] items) {
      Debug.Assert(nRow>0, "# of Rows must be > 0");
      Debug.Assert(nCol>0, "# of Columns must be > 0");
      Debug.Assert(items!=null, "cell values must be specified");
      Debug.Assert((nRow*nCol)==items.Length, "Invalid # of cell values");
      cells = new int[nRow,nCol];
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
    public void Show() {
      for (uint r = 0; r < NRow; r++) {
        for (uint c = 0; c < NCol; c++) Console.Write("\t{0}", cells[r, c]);
        Console.WriteLine();
      }
      Console.WriteLine();
    }
    public Matrix Multiply(Matrix rhs) {
      Matrix lhs = this;
      if (lhs.NCol!=rhs.NRow) throw new Exception("Cannot multiply-lah!");
      int[,] m = new int[lhs.NRow,rhs.NCol];
      for (int r = 0; r < m.GetLength(0); r++) {
        for (int c = 0; c < m.GetLength(1); c++) {
          for (int i = 0; i < rhs.NRow; i++) {
            m[r,c] += lhs.cells[r,i] * rhs.cells[i,c];
          }
        }
      }
      return new Matrix(m);
    }
    public Matrix Add(Matrix rhs) {
      Matrix lhs = this;
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
    public Matrix Transpose() {
      Matrix lhs = this;
      int[,] m = new int[lhs.NCol,lhs.NRow];
      for (int r = 0; r < m.GetLength(0); r++) {
        for (int c = 0; c < m.GetLength(1); c++) {
          m[r, c] = lhs.cells[c, r];
        }
      }
      return new Matrix(m);
    }
  }
}

using System;
using System.Diagnostics;

namespace Matrix3 {
  class Matrix {
    readonly int[,] cells;
    public Matrix(uint nRow,uint nCol, params int[] items) {
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
    public uint getNRow() {
      return (uint)cells.GetLength(0);
    }
    public uint getNCol() {
      return (uint)cells.GetLength(1);
    }
    public void Show() {
      for (uint r = 0; r < getNRow(); r++) {
        for (uint c = 0; c < getNCol(); c++) Console.Write("\t{0}", cells[r, c]);
        Console.WriteLine();
      }
      Console.WriteLine();
    }
    public Matrix Multiply(Matrix rhs) {
      Matrix lhs = this;
      if (lhs.getNCol()!=rhs.getNRow()) throw new Exception("Cannot multiply-lah!");
      int[,] m = new int[lhs.getNRow(),rhs.getNCol()];
      for (int r = 0; r < m.GetLength(0); r++) {
        for (int c = 0; c < m.GetLength(1); c++) {
          for (int i = 0; i < rhs.getNRow(); i++) {
            m[r,c] += lhs.cells[r,i] * rhs.cells[i,c];
          }
        }
      }
      return new Matrix(m);
    }
  }
}

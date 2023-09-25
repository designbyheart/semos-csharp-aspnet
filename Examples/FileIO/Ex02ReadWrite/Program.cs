using System;
using System.IO;

namespace Ex02ReadWrite {
  class Program {
    static public byte[] ReadFile(string filePath){
      byte[] buffer;
      FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
      try{
        int length = (int)fileStream.Length;  // get file length
        buffer = new byte[length];            // create buffer
        int count;                            // actual number of bytes read
        int sum = 0;                          // total number of bytes read

      // read until Read method returns 0 (end of the stream has been reached)
        while ((count = fileStream.Read(buffer, sum, length - sum)) > 0)
          sum += count;  // sum is a buffer offset for next reading
      }
      finally{
        fileStream.Close();
      }
      return buffer;
    }

    static void Main(string[] args) {
        FileStream fout = new FileStream(@"c:\test\new2.txt", FileMode.CreateNew, 
                                        FileAccess.Write, FileShare.None);
        byte[] data = ReadFile(@"C:\test\new.txt");
        fout.Write(data,0,data.Length);
        fout.Close();
        Console.WriteLine("DONE");
        Console.ReadKey();
    }
  }
}

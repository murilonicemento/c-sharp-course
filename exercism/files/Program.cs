using System;
using System.IO;
using System.Collections.Generic;

namespace Course;

class Program
{
  static void Main(string[] args)
  {
    // string sourcePath = @"file.txt";
    // string targetPath = @"file2.txt";

    // try
    // {
    //   FileInfo fileInfo = new FileInfo(sourcePath);
    //   fileInfo.CopyTo(targetPath);

    //   string[] lines = File.ReadAllLines(sourcePath);

    //   foreach (string line in lines)
    //   {
    //     Console.WriteLine(line);
    //   }
    // }
    // catch (IOException e)
    // {
    //   Console.WriteLine("An error ocurred");
    //   Console.WriteLine(e.Message);
    // }

    // string path = @"file.txt";
    // FileStream fileStream = null;
    // StreamReader streamReader = null;

    // try
    // {
    //   fileStream = new FileStream(path, FileMode.Open);
    //   streamReader = new StreamReader(fileStream);

    //   streamReader = File.OpenText(path);
    //   while (!streamReader.EndOfStream)
    //   {
    //     string line = streamReader.ReadLine();
    //     Console.WriteLine(line);
    //   }
    // }
    // catch (IOException e)
    // {
    //   Console.WriteLine("An error ocurred");
    //   Console.WriteLine(e.Message);
    // }
    // finally
    // {
    //   if (streamReader != null) streamReader.Close();
    //   if (fileStream != null) fileStream.Close();
    // }

    // ** Using Box
    // using (FileStream fs = new FileStream(path, FileMode.Open))
    // {
    //   using (StreamReader sr = new StreamReader(fs))
    //     while (!sr.EndOfStream)
    //     {
    //       string line = sr.ReadLine();
    //       Console.WriteLine(line);
    //     }
    // }

    //   string sourcePath = @"file.txt";
    //   string targetPath = @"file2.txt";

    //   try
    //   {
    //     string[] lines = File.ReadAllLines(sourcePath);

    //     using (StreamWriter sw = File.AppendText(targetPath))
    //     {
    //       foreach (string line in lines)
    //       {
    //         sw.WriteLine(line.ToUpper());
    //       }
    //     }
    //   }
    //   catch (IOException e)
    //   {
    //     Console.WriteLine("An error ocurred");
    //     Console.WriteLine(e.Message);
    //   }
    // }
    string path = @"file.txt";

    // try
    // {
    //   IEnumerable<string> folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

    //   foreach (var s in folder)
    //   {
    //     Console.WriteLine(s);
    //   }

    //   IEnumerable<string> file = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

    //   foreach (var s in file)
    //   {
    //     Console.WriteLine(s);
    //   }

    //   Directory.CreateDirectory(path + "/new-folder");
    // }
    // catch (IOException e)
    // {
    //   Console.WriteLine("An error ocurred");
    //   Console.WriteLine(e.Message);
    // }

    Console.WriteLine(Path.GetDirectoryName);
    Console.WriteLine(Path.PathSeparator);
    Console.WriteLine(Path.GetFileName(path));
    Console.WriteLine(Path.GetFileNameWithoutExtension(path));
    Console.WriteLine(Path.GetExtension(path));
    Console.WriteLine(Path.GetFullPath(path));
    Console.WriteLine(Path.GetTempPath(path));
    Console.WriteLine(Path.DirectorySeparatorChar(path));
  }
}
﻿using System.IO;
using System.IO.Enumeration;

internal class Program
{
    private static void Main(string[] args) {
        Console.WriteLine("Started.");

        string InsertedPath = "D:\\bkp\\Music\\MEmu Music";
        string[] FilePaths = Directory.GetFiles(InsertedPath);
        string[] DirPaths = Directory.GetDirectories(InsertedPath);

        Console.WriteLine("Directories: ");
        foreach (string DirPath in DirPaths) {
            Console.WriteLine(DirPath);
            // Get only dir name
            // Rename 
        }
        Console.WriteLine("End of directories.");

        Console.WriteLine("");

        Console.WriteLine("Files: ");
        foreach(string FilePath in FilePaths) {
            Console.WriteLine(FilePath);
            // Get only path name
            // Rename
        }
        Console.WriteLine("End of files.");
        
    }
}
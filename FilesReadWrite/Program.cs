﻿using System;
using System.IO;
using System.Text;
using FilesReadWrite;

namespace FilesReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFileHandler fileHandler = new MyFileHandler();

            NoteBook noteBook = new NoteBook();

            //fileHandler.ReadAllContent();

            //fileHandler.WriteContentToFile(Console.ReadLine());

            //string readFile = File.ReadAllText("testfile1.txt");

            //fileHandler.UpperCaseContent(readFile, "testUpper.txt");

            //fileHandler.ReadLatinEncodedContent();

            noteBook.TakeNot(Console.ReadLine());
        }
    }
}

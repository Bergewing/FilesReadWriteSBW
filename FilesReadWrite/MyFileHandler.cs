using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesReadWrite
{
    class MyFileHandler
    {
        public void ReadAllContent()
        {
            string testFile = File.ReadAllText("testfile1.txt");
            Console.WriteLine(testFile);
        }

        public void WriteContentToFile(string text)
        {

            File.WriteAllText("testfile2.txt", text);
        }

        public void UpperCaseContent(string text, string txtFile)
        {
            File.WriteAllText(txtFile, text.ToUpper());
        }

        public void ReadLatinEncodedContent()
        {
            Console.WriteLine(File.ReadAllText("latin1.txt", encoding: Encoding.Latin1)); //Vad gör "encoding:" någon ashäftig feature som sätter labels
        }                                                                                 //För att lättare hålla isär grejer.

    }
}

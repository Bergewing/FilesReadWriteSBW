using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesReadWrite
{
    class NoteBook
    {
        public void TakeNot(string notes)
        {
            string note = string.Format("{0, -24}{1, 0}", DateTime.Now.ToString(), notes);
            string header = string.Format("{0, -24}{1, 0}", "Date", "Note");
            string line = "---------------------------------------";
            //File.AppendAllText("Notes.txt", Environment.NewLine + header + Environment.NewLine + line + Environment.NewLine + note);


            if (File.Exists("Notes.txt") == false)
            {
                File.AppendAllText("Notes.txt", header + Environment.NewLine + line);
            }
            File.AppendAllText("Notes.txt",Environment.NewLine + note);
        }


    }
}

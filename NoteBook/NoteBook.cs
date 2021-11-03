using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook
{
    internal class NoteBook
    {
        public void TakeNote(string note)
        {

            if (!File.Exists("notes.txt"))
            {
                string[] headerInfo = new string[]
                {
                    $"{"Datum",-24}{"Note"}", 
                    
                    new string('-', 60)
                };
                File.WriteAllLines("notes.txt", headerInfo);
            }
            string output = $"{DateTime.Now.ToString(),-24}{note}";
            File.AppendAllText("notes.txt", output + Environment.NewLine);
        }
        public string[] GetAllNotes()
        {
            if (!File.Exists("notes.txt"))
            {
                string[] headerInfo = new string[]
                {
                    $"{"Datum",-24}{"Note"}",

                    new string('-', 60)
                };
                File.WriteAllLines("notes.txt", headerInfo);
            }
            string[] notes = File.ReadAllLines("notes.txt");
            return notes[2..];
        }
    }
}

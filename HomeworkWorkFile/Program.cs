using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWorkFile
{
    interface IWriteToFile
    {
        void Write();
    }

    class WorkFile : IWriteToFile
    {
        public string Path { get; set; }
        public void Write()
        {
            Path = @"C:\Users\NewComp\Desktop\NewFile123.txt";

            string text = "";

            try
            {
                using (StreamReader sr = new StreamReader(Path, Encoding.Default))
                {
                    text = sr.ReadToEnd();
                }
            
                using (StreamWriter sw = new StreamWriter(Path, true, Encoding.Default))
                {
                    sw.WriteLine(text);
                }
                string text1 = Console.ReadLine();
                using (StreamWriter sw = new StreamWriter(Path, true, Encoding.Default))
                {
                    sw.WriteLine(text1);
                }

                using (StreamReader sr = new StreamReader(Path))
                {
                    Console.WriteLine(sr.ReadToEnd()); 
                }
            }
            catch   (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            WorkFile workFile = new WorkFile();
            workFile.Write();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MigrationsTool_DLL
{
    public class Main
    {
        string FilePath = "";
        public void ()
        {
            using(StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }


            string path = @"";
            if(!File.Exits(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine();
                }
            }
        }
    }
}

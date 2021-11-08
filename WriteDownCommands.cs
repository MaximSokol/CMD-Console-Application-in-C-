using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CMD_v2._17
{
    class WriteDownCommands
    {
        public void SaveCommands(string path)
        {
            using (StreamWriter sw = new StreamWriter("commands.txt", true, Encoding.Default))
            {
                sw.WriteLine(path);
            }
        }

        public void ShowStory()
        {
            Console.WriteLine("List of commands:\n");

            using (StreamReader sr = new StreamReader("commands.txt"))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CMD_v2._17
{
    class SearchFiles
    {
        public void SearchDirectory()
        {
             Console.WriteLine("Enter the path of the file ->");
             string catalog = Console.ReadLine();

             Console.WriteLine("Enter the file's name ->");
             string fileName = Console.ReadLine();

            foreach (string findedFile in Directory.EnumerateFiles(catalog, fileName,
                SearchOption.AllDirectories))
            {
                FileInfo f;
                try
                {
                    f = new FileInfo(findedFile);
                    Console.WriteLine($"File name\t{f.Name}\nFull name\t{f.FullName}\n" +
                        $"Size:\t{f.Length}\tbytes\nTime of created:\t{f.CreationTime}\n");
                }
                catch
                {
                    continue;
                }

            }
        }
    }
}

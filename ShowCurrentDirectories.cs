using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CMD_v2._17
{
    class ShowCurrentDirectories
    {
       public void ShowCurrentDirectory()
        {
            DirectoryInfo dir = new DirectoryInfo(".");

             Console.WriteLine($"Full path to the directory\n{dir.FullName}\n");

             Console.WriteLine($"Time of creation\n{dir.CreationTime}\n");

             Console.WriteLine("All files in the current directory\n");
                    
              FileInfo[] f = dir.GetFiles();

                foreach (FileInfo fi in f)
                {
                   Console.WriteLine(fi.Name);
                }
                Console.WriteLine();
                Console.ReadKey();
        }
    }
}

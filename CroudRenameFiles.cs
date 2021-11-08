using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CMD_v2._17
{
    class CroudRenameFiles
    {
        public void RenameFolder()
        {
            try
            {
                Console.WriteLine("Enter source folder name ->");
                string sourceName = Console.ReadLine();

                Console.WriteLine("Enter destination folder name ->");
                string destinationName = Console.ReadLine();

                Directory.Move(sourceName, destinationName);

                Console.Write("Renamed successfuly!\n");
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex}");
            }
            Console.ReadKey();
        }

        public void RenameFile()
        {
           Console.WriteLine("Enter path of file ->");
           string path = Console.ReadLine();

            Console.WriteLine("Enter current file name ->");
            string sourceName = Console.ReadLine();

            Console.WriteLine("Enter future file name ->");
            string destinationName = Console.ReadLine();

            DirectoryInfo d = new DirectoryInfo(path);
            FileInfo[] infos = d.GetFiles();
            foreach (FileInfo f in infos)
            {
                File.Move(f.FullName, f.FullName.Replace(sourceName, destinationName));
            }
            Console.Write("Renamed successfuly!\n");
            Console.ReadKey();
        }
    }
}

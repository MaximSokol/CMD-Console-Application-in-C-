using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CMD_v2._17
{
    class CopyFilesAndDirectories
    {
        public void CopyFiles()
        {
            Console.WriteLine("Enter source ->");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter destination ->");
            string str2 = Console.ReadLine();

            try
            {
                if (!File.Exists(str1)){
                    using (File.Create(str1));
                }

                File.Copy(str1, str2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        public void CopyDirectory(bool trueOrFalse)
        {

            Console.WriteLine("Enter source ->");
            string source = Console.ReadLine();

            Console.WriteLine("Enter destination ->");
            string destination = Console.ReadLine();

            DirectoryInfo dir = new DirectoryInfo(source);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    $"This file in not exist or can't be found" + source);
            }

            DirectoryInfo[] dirArr = dir.GetDirectories();

            Directory.CreateDirectory(destination);

            FileInfo[] fileArr = dir.GetFiles();
            foreach(FileInfo member in fileArr)
            {
                string temPath = Path.Combine(destination, member.Name);
                member.CopyTo(temPath, false);
            }

            if (trueOrFalse)
            {
                foreach (DirectoryInfo subDir in dirArr)
                {
                    string tempSubDir = Path.Combine(destination, subDir.Name);
                    CopyDirectory(trueOrFalse);
                }
                Console.Write("The directory was copied!\n ");
            }
            Console.ReadKey();
        }
    }
}

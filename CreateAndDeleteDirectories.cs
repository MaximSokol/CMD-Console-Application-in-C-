using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CMD_v2._17
{
    class CreateAndDeleteDirectories
    {
        public void CreateDirectory()
        {
            Console.Write("Enter the path of directory ->\n");
            string path = Console.ReadLine();

            try
            {
                if (Directory.Exists(path))
                {
                    Console.WriteLine("The directory has already exists!");
                }
                DirectoryInfo dir = Directory.CreateDirectory(path);

                Console.WriteLine("The directory was created!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadKey();
        }

        public void DeleteDirectory()
        {
            Console.Write("Enter the path of directory to delete->\n");
            string path = Console.ReadLine();

            if (!Directory.Exists(path))
            {
                Console.WriteLine("Along the specified path the directory has not foound!");
            }
            Directory.Delete(path);
            Console.WriteLine("Directory was deleted.");

            Console.ReadKey();
        }
       
    }
}

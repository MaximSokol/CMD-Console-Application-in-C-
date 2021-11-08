using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CMD_v2._17
{
    class CreateAndVieweFiles
    {
        public void CreateFile()
        {
            Console.WriteLine("Enter the path ->");
            string path = Console.ReadLine();

            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                Console.WriteLine("Enter the text ->");
                string textFile = Console.ReadLine();

                byte[] arrBytes = Encoding.UTF8.GetBytes(textFile);
                fs.Write(arrBytes, 0, arrBytes.Length);
            }
            Console.WriteLine("Was written!");
            Console.ReadKey();
        }

        public void VieweFile()
        {
            Console.WriteLine("Enter the path ->");
            string path = Console.ReadLine();

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                byte[] arrBytes = new byte [fs.Length];
                fs.Read(arrBytes, 0, arrBytes.Length);
                string str = Encoding.UTF8.GetString(arrBytes);

                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}

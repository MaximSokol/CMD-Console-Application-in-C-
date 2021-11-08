using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMD_v2._17
{
    class ShowAttributes
    {
        public void GetAttributes()
        {
            try
            {
                Console.WriteLine("Enter the name of the file ->");
                string attributesDate = Console.ReadLine();
               
                Console.WriteLine("Tap double enter button to close the CMD");

                FileAttributes attribute = File.GetAttributes(attributesDate);
                Console.WriteLine(attribute);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD_v2._17
{
    class MovingFilesAndDirectories
    {
        public void MovingFile()
        {
			Console.WriteLine("Enter source file ->");
			string path1 = Console.ReadLine();

			Console.WriteLine("Enter destination file ->");
			string path2 = Console.ReadLine();

			if (!File.Exists(path1))
			{
				using (FileStream fs = File.Create(path1)) { }
			}

			if (File.Exists(path2))
			{
				File.Delete(path2);
			}

			File.Move(path1, path2);

			Console.WriteLine("The first file was moved to the second!\n", path1, path2);

			if (File.Exists(path1))
			{
				Console.WriteLine("Sourse File still existing!\n");
			}
			else
			{
				Console.WriteLine("Sourse file, was deleted!\n");
			}
			Console.ReadKey();
		}

		public void MovingDirectory()
        {
			Console.WriteLine("Enter the first dirrection ->");
			string dir1 = Console.ReadLine();

			Console.WriteLine("Enter the second dirrection ->");
			string dir2 = Console.ReadLine();

			try
			{ 
				Directory.Move(dir1, dir2);

				Console.WriteLine("The folder was moved to the second DIRRECTION!\n");
			}
            catch(Exception exception)
            {
				Console.WriteLine(exception.Message);
            }
			Console.ReadKey();
        }
	}
}

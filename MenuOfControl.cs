using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD_v2._17
{
    class MenuOfControl
    {
        string selection;
        string command;
        public MenuOfControl() { }

        public MenuOfControl(string selection, string command)
        {
            this.selection = selection;
            this.command = command;
        }

        public void ShowPosition(string emptyStr = "")
        {
            Console.Write(">" + emptyStr);
        }

        public void Menu()
        {
            WriteDownCommands commands = new WriteDownCommands();

            List<string> list = new List<string>();
            list.Add("|==================================================|");
            list.Add("|dir          -  Show current directory...........1|");
            list.Add("|moving       -  Moving files and folders.........2|");
            list.Add("|copy         -  Copy files and directories.......3|");
            list.Add("|createfile   -  Create and viewe text files......4|");
            list.Add("|clear        -  Clear the console)...............5|");
            list.Add("|attribute    -  Viewe attribute selected file....6|");
            list.Add("|rename       -  Group rename files...............7|");
            list.Add("|dirrectories -  Create abd delete directories....8|");
            list.Add("|search       -  Search files.....................9|");
            list.Add("|history      -  History of entered commands.....10|");
            list.Add("|help         -  Show list commands..............11|");
            list.Add("|helpkey      -  Show list by key................12|");
            list.Add("|exit         -  To close the program............13|");
            list.Add("|==================================================|");


            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            do
            {
                ShowPosition();
                command = Console.ReadLine();
                commands.SaveCommands(command);

                switch (command)
                {
                    case "dir":
                        ShowCurrentDirectories dir = new ShowCurrentDirectories();
                        dir.ShowCurrentDirectory();
                        break;

                    case "moving":
                        MovingFilesAndDirectories move = new MovingFilesAndDirectories();
                        Console.Write($"1. Move file\n2. Move dirrectory\n");
                        selection = Console.ReadLine();
                        if (selection == "1") move.MovingFile();
                        else if (selection == "2") move.MovingDirectory();
                        break;

                    case "copy":
                        CopyFilesAndDirectories copy = new CopyFilesAndDirectories();
                        Console.Write("1. Copy files\n2. Copy directories\n");
                        selection = Console.ReadLine();
                        if (selection == "1") copy.CopyFiles();
                        else if (selection == "2") copy.CopyDirectory(true);
                        break;

                    case "createfile":
                        CreateAndVieweFiles viewe = new CreateAndVieweFiles();
                        Console.Write("1. Create file\n2. Viewe file\n");
                        selection = Console.ReadLine();
                        if (selection == "1") viewe.CreateFile();
                        else if (selection == "2") viewe.VieweFile();
                        break;

                    case "clear":
                        Console.Clear();
                        break;

                    case "attricbute":
                        ShowAttributes attributes = new ShowAttributes();
                        attributes.GetAttributes();
                        break;

                    case "rename":
                        CroudRenameFiles rename = new CroudRenameFiles();
                        Console.Write("1. Rename folder\n2. Rename file\n");
                        selection = Console.ReadLine();
                        if (selection == "1") rename.RenameFolder();
                        else if (selection == "2") rename.RenameFile();
                        break;

                    case "directories":
                        CreateAndDeleteDirectories dirrection = new CreateAndDeleteDirectories();
                        Console.WriteLine("1. Create directory\n2. Delete directory\n");
                        selection = Console.ReadLine();
                        if (selection == "1") dirrection.CreateDirectory();
                        else if (selection == "2") dirrection.DeleteDirectory();
                        break;

                    case "search":
                        SearchFiles search = new SearchFiles();
                        search.SearchDirectory();
                        break;

                    case "history":
                        commands.ShowStory();
                        break;

                    case "exit":
                        Environment.Exit(0);
                        break;

                    case "help":
                        foreach(var elem in list)
                            Console.WriteLine(elem);
                        break;

                    case "helpkey":
                        SearchCommandByKey byKey = new SearchCommandByKey();
                        byKey.SearchByKey(5);
                        break;

                    default:
                        Console.WriteLine("ERROR: The wrong command!");
                        break;
                }
            } while (command != "exit");
        }
    }
}


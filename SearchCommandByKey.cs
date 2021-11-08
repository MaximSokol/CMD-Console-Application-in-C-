using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CMD_v2._17
{
    class SearchCommandByKey
    {
        string key;

       public SearchCommandByKey() { }

       public SearchCommandByKey(string key)
        {
            this.key = key;
        }
        public void SearchByKey(int size)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("helpdir", "Show current directory");
            dict.Add("helpmoving", "Moving files and folders");
            dict.Add("helpcopy", "Copy files and directories");
            dict.Add("helpcreatefile", "Create and viewe text files");
            dict.Add("helpclear", "Clear the console");
            dict.Add("helpattribute", "Viewe attribute selected file");
            dict.Add("helprename", "Group rename files");
            dict.Add("helpdirrectories", "Create abd delete directories");
            dict.Add("helpsearch", "Search files");
            dict.Add("helphistory", "History of entered commands");
            dict.Add("helpexit", "To close the program");

            Console.WriteLine("Enter key ->\n");
            key = Console.ReadLine();

            if (dict.ContainsKey(key))
            {
                string valueKey = dict[key];
                Console.WriteLine(valueKey);
            }
        }
    }
}

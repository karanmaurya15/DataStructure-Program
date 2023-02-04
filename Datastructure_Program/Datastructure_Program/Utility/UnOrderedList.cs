using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure_Program.Utility
{
    internal class UnOrderedList
    {
        public void ReadAllText(string filepath)
        {
            string list = File.ReadAllText(filepath);
            string[] words = list.Split(",");
            LinkedList<string> linkedList = new LinkedList<string>();
            foreach (var word in words)
            {
                linkedList.Add(word);
            }
            Console.Write("\nEnter the word to be searched : ");
            string searchWord = Console.ReadLine();
            foreach (var data in words)
            {
                if (data.Equals(searchWord))
                {
                    Console.WriteLine("Word is present in the linkedlist");
                    linkedList.Delete(searchWord);
                    linkedList.Display();
                    Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    return;
                }
            }
            linkedList.Add(searchWord);
            linkedList.Display();
        }
    }
}

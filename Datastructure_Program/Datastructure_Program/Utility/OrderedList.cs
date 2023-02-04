using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure_Program.Utility
{
    internal class OrderedList
    {
        public void ReadAllTextFile(string filepath)
        {
            string list = File.ReadAllText(filepath);
            string[] numbers = list.Split(",");
            SortingList<int> linkedlist = new SortingList<int>();
            foreach (var num in numbers)
            {
                int result = Convert.ToInt32(num);
                linkedlist.AddNode(result);
            }
            Console.WriteLine("Before Sorting");
            linkedlist.DisplaySort();
            linkedlist.SortOrderedList();
            Console.WriteLine("After Sorting : ");
            linkedlist.DisplaySort();
        }
    }
}

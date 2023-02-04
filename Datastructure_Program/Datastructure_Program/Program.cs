using Datastructure_Program.Utility;

namespace Datastructure_Program
{
    internal class Program
    {
        public static string wordFilePath = @"C:\BridgeLabz\DataStructure-Program\Datastructure_Program\Datastructure_Program\Files\WordSearch.txt";
        public static string numberFilePath = @"C:\BridgeLabz\DataStructure-Program\Datastructure_Program\Datastructure_Program\Files\NumberFile.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to the Data Structure Programs");
            bool flag = true;
            while(flag)
            {
                Console.WriteLine(" 1.UnOrdered List \n 2.Ordered List \n 3.Exit");
                Console.Write("Select any one from the above option :");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        UnOrderedList unOrderedList = new UnOrderedList();
                        unOrderedList.ReadAllText(wordFilePath);
                        break;
                    case 2:
                        OrderedList orderedList = new OrderedList();
                        orderedList.ReadAllTextFile(numberFilePath);
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}
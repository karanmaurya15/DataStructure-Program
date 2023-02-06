using Datastructure_Program.Utility;

namespace Datastructure_Program
{
    internal class Program
    {
        public static string wordFilePath = @"C:\BridgeLabz\DataStructure-Program\Datastructure_Program\Datastructure_Program\Files\WordSearch.txt";
        public static string numberFilePath = @"C:\BridgeLabz\DataStructure-Program\Datastructure_Program\Datastructure_Program\Files\NumberFile.txt";
        public static string paranthesisFilePath = @"C:\BridgeLabz\DataStructure-Program\Datastructure_Program\Datastructure_Program\Files\BalancedParanthesis.txt";
        public static string personsListFilePath = @"C:\BridgeLabz\DataStructure-Program\Datastructure_Program\Datastructure_Program\Files\PersonsAtCounter.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to the Data Structure Programs");
            bool flag = true;
            while(flag)
            {
                Console.WriteLine(" 1.UnOrdered List \n 2.Ordered List \n 3.Balanced Paranthesis \n 4.Banking Cash Counter \n 5.Exit");
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
                        BalancedParanthesis balancedParanthesis = new BalancedParanthesis();
                        balancedParanthesis.ReadText(paranthesisFilePath);
                        break;
                    case 4:
                        BankingCashCounter bankingCashCounter = new BankingCashCounter();
                        bankingCashCounter.ReadAllTextFile(personsListFilePath);
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
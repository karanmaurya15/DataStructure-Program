using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure_Program.Utility
{
    internal class BalancedParanthesis
    {
        public void ReadText(string filepath)
        {
            string list = File.ReadAllText(filepath);
            string[] expression = list.Split(" ");
            Stack<string> stack = new Stack<string>();
            foreach(var data in expression)
            {
                if(data.Equals("("))
                    stack.Push(data);
                if(data.Equals(")"))
                    stack.Pop();
            }
            if (stack.Peek())
            {
                Console.WriteLine("Arithmatic Expression is balanced");
            }
            else
                Console.WriteLine("Arithmatic Expression is not balanced");
        }
    }
}

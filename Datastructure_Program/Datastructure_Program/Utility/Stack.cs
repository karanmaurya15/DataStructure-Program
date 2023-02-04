using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure_Program.Utility
{
    public class Stack<T>
    {
        public Node<T> top;
        public Stack()
        {
            this.top = null;
        }
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            if(this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine($"{value} pushed to stack");
        }
        public bool Peek()
        {
            if(this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return true;
            }
            Console.WriteLine($"{this.top.data} is the top of stack");
            return false;
        }
        public void Pop()
        {
            if(this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine($"Value Popped is {this.top.data}");
            this.top = this.top.next;
        }
        public void Display()
        {
            Node<T> temp = this.top;
            Console.WriteLine("Stack is as:");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class node
    {
        public int info;
        public node next;
        public node(int i, node n)
        {
            info = i;
            next = n;
        }
    }
    class Stack
    {
        node top;
        public Stack()
        {
            top = null;
        }
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
        public void pop()
        {
            Console.WriteLine("\n The poped elements is: " + top.info);
            top = top.next; // make top point to the next node is squence
        }
        public void push(int element)
        {
            node fresh;
            fresh = new node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + "pushed");
        }
        public void display()
        {
            node tmp;
            if (empty())
                Console.WriteLine("\nStack Empty");
            else
            {
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Stack s = new Stack();
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("\n***Stack Menu***\n");
                    Console.WriteLine("1. POP");
                    Console.WriteLine("2. PUSH");
                    Console.WriteLine("3. DISPLAY");
                    Console.Write("4. Exit");
                    Console.Write("\nEnter your choice: ");
                    string Input = Console.ReadLine();
                    char ch = Convert.ToChar(Input == "" ? "o" : Input);
                    switch (ch)
                    {
                        case '1':
                            if (s.empty())
                            {
                                Console.WriteLine("\nStack Empty");
                                break;
                            }
                            s.pop();
                            break;
                    }
                }
            }
        }
    }   
}

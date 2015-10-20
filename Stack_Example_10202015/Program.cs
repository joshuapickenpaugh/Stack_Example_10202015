//Joshua Pickenpaugh, IN2017
//October 20th, 2015
//Stack Example

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Example_10202015
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack1 = new Stack();
            stack1.Push(2);
            stack1.Push(4);
            stack1.Push(6);
            stack1.Push(8);
            stack1.Push(10);

            MethodStack(stack1);

            Console.ReadKey();
        }

        static void MethodStack(Stack methStack)
        {
            if (methStack.Contains(6))
            {
                Console.WriteLine("Here is the Stack:");
            }
            
            while (0 < methStack.Count)
            {
                Console.WriteLine(methStack.Pop());
            }

            Console.WriteLine("Press a key to exit program.");
        }
    } 
}


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavannahAssessment
{
    class Program
    {

        static void Main(string[] args)
        {
            // Creates and initializes a new Stack.
            Stack myStack = new Stack();
            myStack.Push("The");
            myStack.Push("quick");
            myStack.Push("brown");
            myStack.Push("fox");

            /*=======================================POP()=============================*/
      
            // Displays the Stack.
            Console.Write("Stack values:" );
            PrintValues(myStack, '\t');

            // Removes an element from the Stack.
            Console.WriteLine("(Pop)\t\t{0}", myStack.Pop());

            // Displays the Stack.
            Console.Write("Stack values:");
            PrintValues(myStack, '\t');


            /*==========================================PUSH()=====================================*/

            Stack stk = new Stack();
            stk.Push("Welcome");
            stk.Push("To Justus Example");
            stk.Push(20.5f);
            stk.Push(10);
            stk.Push(null);
            stk.Push(100);
            Console.WriteLine("Number of Elements in Stack: {0}", stk.Count);
            Console.WriteLine("******Stack Elements For Push******");

            // Access Stack Elements
            foreach (var item in stk)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        private static void PrintValues(IEnumerable myStack, char v)
        {
            foreach (Object obj in myStack)
                Console.Write("{0}{1}", v, obj);
            Console.WriteLine();
        }
    }

 }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue myQ = new Queue(); 

            myQ.Enqueue(1);
            myQ.Enqueue(14);
            myQ.Enqueue(3);
            myQ.Enqueue(46);
            myQ.Enqueue(8);
                                    
            PrintValues(myQ);
                        
            Console.WriteLine("(Dequeue)\t{0}", myQ.Dequeue());
            PrintValues(myQ);
                            
            Console.WriteLine("(Peek)   \t{0}", myQ.Peek());
            PrintValues(myQ);
        }

        public static void PrintValues(Queue myQ)
        {
            
            Console.Write("    {0}", myQ);
            Console.WriteLine();
        }






    }

}


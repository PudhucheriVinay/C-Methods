using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Methods
{
    internal class Program
    {
        //** Methods
        // Create & call a method
        static void MyMethod()
        {
            Console.WriteLine("I Just got executed");
        }
   

        // Parameters and Arguments

        static void MyMethod(string fname, int age)
        {
            Console.WriteLine(fname + " Refsnes is" +   age);
        }

        static void MyMethod(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        static int MyMethod(int x, int y)
        {
            return x + y;
        }

        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is:" + child3);
        }

        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            MyMethod();
            MyMethod();
            MyMethod();

            Console.WriteLine();

            // Calling second method

            MyMethod("Liam", 5);
            MyMethod("Jenny", 6);
            MyMethod("Anja", 21);

            {
                MyMethod("Sweden");
                MyMethod("India");
                MyMethod();
                MyMethod("USA");
            }

                {
                    Console.WriteLine(MyMethod(5,3));
                    int z = MyMethod(5,3);
                    Console.WriteLine(z);
                }
            {
                MyMethod(child3: "John", child1: "Liam", child2: "Liam");
            }

            {
                int myNum1 = PlusMethod(8, 5);
                double myNum2 = PlusMethod(4.3, 6.26);
                Console.WriteLine("Int: " + myNum1);
                Console.WriteLine("Double: " + myNum2);
            }


        }

    }
  }



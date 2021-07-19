using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2;
            Console.WriteLine("please enter the Num1");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the Num2");
            Num2 = Convert.ToInt32(Console.ReadLine());
            int add, sub;
            add = Num1 + Num2;
            sub = Num1 - Num2;
            Console.WriteLine("sum of two numbers:" + add.ToString());
            Console.WriteLine("Diff of two numbers:" + sub.ToString());
        }
    }
}

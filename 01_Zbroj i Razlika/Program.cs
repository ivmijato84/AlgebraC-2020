using System;

namespace _01_Zbroj_i_Razlika
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            Console.Write("Unesite prvi broj:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Unesite drugi broj:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Zbroj: {0}", a + b);
            Console.WriteLine("Razlika: {0}", a - b);

            Console.WriteLine("Pritisni \"Enter\" na kraju");

            //Ivan Mijatović_Zbroj i razlika

        }
    }
}

using System;

namespace _01_Umnožak_i_kvocijent
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

            Console.WriteLine("Umnožak: {0}, Kvocijent: {1}", a * b, (float)a / (float)b);
            Console.WriteLine("Pritisnite neku tipku na kraju");

            //Ivan Mijatović_Umnožak i kvocijent

        }
    }
}

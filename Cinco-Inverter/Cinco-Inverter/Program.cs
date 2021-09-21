using System;

namespace Cinco_Inverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a palava pra ser invertida");
            var word = Console.ReadLine();
            for (var i = word?.Length-1; i >= 0; i--)
            {
                Console.Write(word[(int) i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace DOIS_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor a ser verificado : ");
            var number = int.Parse(Console.ReadLine() ?? "1");
            var list = Fibonacci(0, 1, number);
            var response = list.Any(i => i == number)
                ? "Sim, o número está na sequencia fibonacci :)"
                : "Não, o número não está na sequencia fibonacci :(";
            Console.WriteLine(response);
        }

        private static List<int> Fibonacci(int firstNumber, int secondNumber, int number)
        {
            var list = new List<int>();
            while (true)
            {
                if (firstNumber >= number) return list;
                
                var firstNumber1 = firstNumber;
                firstNumber = secondNumber;
                secondNumber = firstNumber1 + secondNumber;
                list.Add(firstNumber);

            }
        }
    }
}
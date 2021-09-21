using System;
using System.Collections.Generic;
using System.Linq;

namespace Quatro_FaturamentoEstado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de estados a serem inseridos");
            var number = int.Parse(Console.ReadLine() ?? "1");
            var listEstado = new List<Estado>();
            for (var i = 1; i <= number; i++)
            {
                Console.WriteLine("Digite o nome do Estado "+ i);
                var nomeEstado = Console.ReadLine();
                
                Console.WriteLine("Digite valor do Estado "+ i);
                var valorFaturamento = decimal.Parse(Console.ReadLine()!);

                listEstado.Add(new Estado()
                {
                    Name = nomeEstado,
                    value = valorFaturamento
                }); 
                
            }

            listEstado = ComputePercentage(listEstado);
            foreach (var estado in listEstado)
            {
                Console.WriteLine($"O estado {estado.Name} teve o faturamento de {estado.value} que representa {estado.percentage}% do faturamento geral");
            }
        }

        public static List<Estado> ComputePercentage(List<Estado> list)
        {
            var total = list.Sum(i => i.value);
            foreach (var estado in list)
            {
                estado.percentage = (double)((estado.value * 100) / total);
            }

            return list;
        }
        public class Estado
        {
            public string Name { get; set; }
            public decimal value { get; set; }
            public double? percentage { get; set; }
        }
    }
}
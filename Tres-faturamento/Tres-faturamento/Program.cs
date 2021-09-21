using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Tres_faturamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var basePath = Directory.GetCurrentDirectory() + @"\\files";
            if (!Directory.Exists(basePath))
            {
                ConsoleVersion();
            }
            else
            {
                using var r = new StreamReader(basePath+ @"\\dados.json");
                var json = r.ReadToEnd();
                var listaFaturamento = JsonConvert.DeserializeObject<List<Faturamento>>(json);
                Printmedias(listaFaturamento);
            }
        }

        private static void ConsoleVersion()
        {
            Console.WriteLine("Digite o número de dias a serem inseridos");
            var number = int.Parse(Console.ReadLine() ?? "1");
            var listaFaturamento = new List<Faturamento>();
            for (var i = 1; i <= number; i++)
            {
                Console.WriteLine("Digite valor do dia "+ i);
                decimal valorFaturamento;
                
                try
                {
                    valorFaturamento = decimal.Parse(Console.ReadLine()!);
                }
                catch (Exception )
                {
                    valorFaturamento = 0;
                }
                
                listaFaturamento.Add(new Faturamento()
                {
                    Dia = i,
                    valor = valorFaturamento
                }); 
            }
            Printmedias(listaFaturamento);
        }

        public static void Printmedias(List<Faturamento> listaFaturamento)
        {
            Console.WriteLine("\n\nMenor Faturamento "+listaFaturamento.Where(i=>i.valor!=0).Min(i => i.valor));
            Console.WriteLine("\n\nMaior Faturamento "+listaFaturamento.Where(i=>i.valor!=0).Max(i => i.valor));
            Console.WriteLine("\n\nMédia Faturamento "+listaFaturamento.Where(i=>i.valor!=0).Average(i => i.valor));
        }
        public class Faturamento
        {
            public int Dia { get; set; }
            public decimal valor { get; set; }
        }
    }
}

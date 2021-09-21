using System;

class Program {
  public static void Main (string[] args) {
    var indice = 13;
    var soma = 0;
    var k = 0 ;
    while(k<indice)
    {
      k += 1;
      soma += k;
      Console.WriteLine ("Valor atual de K" + k);
      Console.WriteLine ("Valor atual da soma"+soma);
    }
    Console.WriteLine ("\n\nTotal = " + soma);
  }
}
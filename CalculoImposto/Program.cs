// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        decimal salarioBruto = 3000.00m;
        CalculadoraInss calculadoraInss = new CalculadoraInss();
        decimal descontoInss  = calculadoraInss.Calcular(salarioBruto);

        CalculadoraIrrf calculadoraIrrf = new CalculadoraIrrf();
        decimal descontoIrrf = calculadoraIrrf.Calcular(salarioBruto, descontoInss);

        Console.WriteLine($"Bruto : {salarioBruto:C}");
        Console.WriteLine($"Desconoto Bruto : {descontoInss:C}");
        Console.WriteLine($"Base IRRF : {salarioBruto - descontoInss:C}");
        Console.WriteLine($"Desconto IRRF : {descontoIrrf:C}");
    }
}

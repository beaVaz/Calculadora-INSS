using System;

namespace CalculoImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal salarioBruto = 3000.00m;

            CalculadoraInss calculadoraInss = new CalculadoraInss();
            decimal descontoInss = calculadoraInss.Calcular(salarioBruto);

            CalculadoraIrrf calculadoraIrrf = new CalculadoraIrrf();
            decimal descontoIrrf = calculadoraIrrf.Calcular(salarioBruto, descontoInss);

            Console.WriteLine($"Salário Bruto: {salarioBruto:C}");
            Console.WriteLine($"Desconto INSS: {descontoInss:C}");
            Console.WriteLine($"Salário Base IRRF: {salarioBruto - descontoInss:C}");
            Console.WriteLine($"Desconto IRRF: {descontoIrrf:C}");
        }
    }
}

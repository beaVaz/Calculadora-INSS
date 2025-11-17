using System;

namespace CalculoImposto
{
    public class CalculadoraIrrf
    {
        public decimal Calcular(decimal salarioBruto, decimal descontoInss)
        {
            decimal salarioBase = salarioBruto - descontoInss;
            decimal irrf = 0m;
            decimal aliquota = 0m;
            decimal deducao = 0m;

            if (salarioBase <= 2259.20m)
            {
                aliquota = 0m;
                deducao = 0m;
            }
            else if (salarioBase <= 2826.65m)
            {
                aliquota = 0.075m;
                deducao = 169.44m;
            }
            else if (salarioBase <= 3751.05m)
            {
                aliquota = 0.15m;
                deducao = 381.44m;
            }
            else if (salarioBase <= 4664.68m)
            {
                aliquota = 0.225m;
                deducao = 662.77m;
            }
            else
            {
                aliquota = 0.275m;
                deducao = 896.00m;
            }

            irrf = (salarioBase * aliquota) - deducao;

            if (irrf < 0)
            {
                irrf = 0m;
            }

            return Math.Round(irrf, 2);
        }
    }
}

using System;

namespace CalculoImposto
{
    public class CalculadoraInss
    {
        public decimal Calcular(decimal salarioBruto)
        {
            decimal inss = 0m;

            // O cálculo é limitado ao teto de R$ 7.786,02
            decimal salarioParaCalculo = salarioBruto > 7786.02m ? 7786.02m : salarioBruto;

            if (salarioParaCalculo > 4000.03m)
            {
                inss += (salarioParaCalculo - 4000.03m) * 0.14m;
                salarioParaCalculo = 4000.03m;
            }

            if (salarioParaCalculo > 2666.68m)
            {
                inss += (salarioParaCalculo - 2666.68m) * 0.12m;
                salarioParaCalculo = 2666.68m;
            }

            if (salarioParaCalculo > 1412.00m)
            {
                inss += (salarioParaCalculo - 1412.00m) * 0.09m;
                salarioParaCalculo = 1412.00m;
            }

            inss += salarioParaCalculo * 0.075m;

            return Math.Round(inss, 2);
        }
    }
}

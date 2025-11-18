using System;

public class CalculadoraInss
{
    public decimal Calcular(decimal salarioBruto)
    {
        decimal inss = 0m;
        decimal salarioParaCalculo = salarioBruto > 7786.02m ? 7786.02m : salarioBruto;
    if (salarioParaCalculo > 4190.84m)
        {
            inss += (salarioParaCalculo - 4190.84m) * 0.14m;
            salarioParaCalculo = 4190.84m;
        }
        if (salarioParaCalculo > 2793.89m)
        {
            inss += (salarioParaCalculo - 2793.89m) * 0.12m;
            salarioParaCalculo = 2793.89m;
        } 
         if (salarioParaCalculo > 1518.01m)
        {
            inss += (salarioParaCalculo - 1518.01m) * 0.09m;
            salarioParaCalculo = 1518.01m;
        } inss += salarioParaCalculo * 0.075m;
        return Math.Round (inss, 2);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using CalculoImposto.Models;

public class CalculadoraInss
{
    private static readonly List<FaixaInss> _faixasInss = new List<FaixaInss>
    {
        new FaixaInss { Limite = 1518.01m, Aliquota = 0.075m },
        new FaixaInss { Limite = 2793.89m, Aliquota = 0.09m },
        new FaixaInss { Limite = 4190.84m, Aliquota = 0.12m },
        new FaixaInss { Limite = 7786.02m, Aliquota = 0.14m }
    };

    public decimal Calcular(decimal salarioBruto)
    {
        decimal inss = 0m;
        decimal salarioParaCalculo = salarioBruto > _faixasInss.Last().Limite ? _faixasInss.Last().Limite : salarioBruto;
        decimal limiteAnterior = 0m;

        foreach (var faixa in _faixasInss)
        {
            if (salarioParaCalculo > limiteAnterior)
            {
                decimal valorNestaFaixa = Math.Min(salarioParaCalculo, faixa.Limite) - limiteAnterior;
                inss += valorNestaFaixa * faixa.Aliquota;
                limiteAnterior = faixa.Limite;
            }
        }

        return Math.Round(inss, 2);
    }
}

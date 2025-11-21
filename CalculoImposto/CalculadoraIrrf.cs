using System;
using System.Collections.Generic;
using System.Linq;
using CalculoImposto.Models;

public class CalculadoraIrrf
{
    private static readonly List<FaixaIrrf> _faixasIrrf = new List<FaixaIrrf>
    {
        new FaixaIrrf { Limite = 2259.20m, Aliquota = 0m, Deducao = 0m },
        new FaixaIrrf { Limite = 2826.65m, Aliquota = 0.075m, Deducao = 182.16m },
        new FaixaIrrf { Limite = 3751.05m, Aliquota = 0.15m, Deducao = 394.16m },
        new FaixaIrrf { Limite = 4664.68m, Aliquota = 0.225m, Deducao = 675.49m },
        new FaixaIrrf { Limite = decimal.MaxValue, Aliquota = 0.275m, Deducao = 908.73m }
    };

    public decimal Calcular(decimal salarioBruto, decimal descontoInss)
    {
        decimal salarioBase = salarioBruto - descontoInss;
        decimal irrf = 0m;

        var faixa = _faixasIrrf.First(f => salarioBase <= f.Limite);
        irrf = (salarioBase * faixa.Aliquota) - faixa.Deducao;

        if (irrf < 0)
        {
            irrf = 0m;
        }

        return Math.Round(irrf, 2);
    }
}

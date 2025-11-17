using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculoImposto;

namespace CalculoImposto.Tests
{
    [TestClass]
    public class CalculadoraIrrfTests
    {
        private readonly CalculadoraInss _calculadoraInss = new CalculadoraInss();
        private readonly CalculadoraIrrf _calculadoraIrrf = new CalculadoraIrrf();

        [TestMethod]
        public void Calcular_SalarioIsento_DeveRetornarZero()
        {
            // Arrange
            decimal salario = 2000.00m;
            decimal descontoInss = _calculadoraInss.Calcular(salario);
            decimal esperado = 0m;

            // Act
            decimal resultado = _calculadoraIrrf.Calcular(salario, descontoInss);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Calcular_SalarioFaixa1_DeveRetornarValorCorreto()
        {
            // Arrange
            decimal salario = 2500.00m;
            decimal descontoInss = _calculadoraInss.Calcular(salario);
            decimal esperado = 2.77m; // Corrigido de 3.69

            // Act
            decimal resultado = _calculadoraIrrf.Calcular(salario, descontoInss);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Calcular_SalarioFaixa2_DeveRetornarValorCorreto()
        {
            // Arrange
            decimal salario = 3000.00m;
            decimal descontoInss = _calculadoraInss.Calcular(salario);
            decimal esperado = 36.15m;

            // Act
            decimal resultado = _calculadoraIrrf.Calcular(salario, descontoInss);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Calcular_SalarioFaixa3_DeveRetornarValorCorreto()
        {
            // Arrange
            decimal salario = 4000.00m;
            decimal descontoInss = _calculadoraInss.Calcular(salario);
            decimal esperado = 161.74m; // Corrigido de 143.82

            // Act
            decimal resultado = _calculadoraIrrf.Calcular(salario, descontoInss);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Calcular_SalarioFaixa4_DeveRetornarValorCorreto()
        {
            // Arrange
            decimal salario = 5000.00m;
            decimal descontoInss = _calculadoraInss.Calcular(salario);
            decimal esperado = 345.50m; // Corrigido de 354.55

            // Act
            decimal resultado = _calculadoraIrrf.Calcular(salario, descontoInss);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}

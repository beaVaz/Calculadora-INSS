using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculoImposto;

namespace CalculoImposto.Tests
{
    [TestClass]
    public class CalculadoraInssTests
    {
        private readonly CalculadoraInss _calculadoraInss = new CalculadoraInss();

        [TestMethod]
        public void Calcular_SalarioFaixa1_DeveRetornarValorCorreto()
        {
            // Arrange
            decimal salario = 1412.00m;
            decimal esperado = 105.90m;

            // Act
            decimal resultado = _calculadoraInss.Calcular(salario);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Calcular_SalarioFaixa2_DeveRetornarValorCorreto()
        {
            // Arrange
            decimal salario = 2000.00m;
            decimal esperado = 158.82m;

            // Act
            decimal resultado = _calculadoraInss.Calcular(salario);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Calcular_SalarioFaixa3_DeveRetornarValorCorreto()
        {
            // Arrange
            decimal salario = 3000.00m;
            decimal esperado = 258.82m;

            // Act
            decimal resultado = _calculadoraInss.Calcular(salario);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Calcular_SalarioFaixa4_DeveRetornarValorCorreto()
        {
            // Arrange
            decimal salario = 4500.00m;
            decimal esperado = 448.82m; // Corrigido de 458.81

            // Act
            decimal resultado = _calculadoraInss.Calcular(salario);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Calcular_SalarioAcimaDoTeto_DeveRetornarValorTeto()
        {
            // Arrange
            decimal salario = 8000.00m;
            decimal esperado = 908.86m; // Corrigido de 908.85

            // Act
            decimal resultado = _calculadoraInss.Calcular(salario);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}

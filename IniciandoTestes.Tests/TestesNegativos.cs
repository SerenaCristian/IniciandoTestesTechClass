using System;
using Xunit;
using IniciandoTestesTechClass;

namespace IniciandoTestes.Tests
{

    public class TestesNegativos
    {
        [Fact]
        public void Somar_Incorreto()
        {
            // Arrange
            int n1 = 10;
            int n2 = 20;
            Calculadora sut = new Calculadora();
            int resultadoIncorreto = 40;

            // Act
            int resultado = sut.Somar(n1, n2);

            // Assert
            Assert.NotEqual(resultadoIncorreto, resultado);
        }

        [Fact]
        public void Subtracao_Incorreto()
        {
            // Arrange
            int n1 = 20;
            int n2 = 10;
            Calculadora sut = new Calculadora();
            int resultadoIncorreto = 15;

            // Act
            int resultado = sut.Subtracao(n1, n2);

            // Assert
            Assert.NotEqual(resultadoIncorreto, resultado);
        }

        [Fact]
        public void Multiplicacao_Incorreto()
        {
            // Arrange
            double n1 = 10;
            double n2 = 20;
            Calculadora sut = new Calculadora();
            double resultadoIncorreto = 150;

            // Act
            double resultado = sut.Multiplicacao(n1, n2);

            // Assert
            Assert.NotEqual(resultadoIncorreto, resultado);
        }

        [Fact]
        public void Divisao_Incorreto()
        {
            // Arrange
            double n1 = 20;
            double n2 = 10;
            Calculadora sut = new Calculadora();
            double resultadoIncorreto = 3;

            // Act
            double resultado = sut.Divisao(n1, n2);

            // Assert
            Assert.NotEqual(resultadoIncorreto, resultado);
        }
    }
}

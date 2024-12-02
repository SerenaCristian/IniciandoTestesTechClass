using System;
using Xunit;
using IniciandoTestesTechClass;

namespace IniciandoTestes.Tests
{

    public class TestesPositivosTest
    {
        [Fact]
        public void Somar()
        {
            // Arrange
            int n1 = 10;
            int n2 = 20;
            Calculadora sut = new Calculadora();
            int resultadoEsperado = 30;
         
            // Act
            int resultado = sut.Somar(n1, n2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Subtracao()
        {
            // Arrange
            int n1 = 20;
            int n2 = 10;
            Calculadora sut = new Calculadora();
            int resultadoEsperado = 10;
         
            // Act
            int resultado = sut.Subtracao(n1, n2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Multiplicacao()
        {
            // Arrange
            double n1 = 10;
            double n2 = 20;
            Calculadora sut = new Calculadora();
            int resultadoEsperado = 200;
            
            // Act
            double resultado = sut.Multiplicacao(n1, n2);

            // Assert: 
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Divisao()
        {
            // Arrange
            double n1 = 20;
            double n2 = 10;
            Calculadora sut = new Calculadora();
            double resultadoEsperado = 2;

            // Act
            double resultado = sut.Divisao(n1, n2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}


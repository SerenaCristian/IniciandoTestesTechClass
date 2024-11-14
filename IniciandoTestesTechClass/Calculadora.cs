using System;
using System.Collections.Generic;
using System.Text;

namespace IniciandoTestesTechClass
{
    internal class Calculadora
    {
        public double Somar(double primeiroNumero, double segundoNumero) => primeiroNumero + segundoNumero; 

        public double Subtracao(double primeiroNumero, double segundoNumero ) => primeiroNumero - segundoNumero;

        public double Multiplicacao(double primeiroNumero, double segundoNumero) => primeiroNumero * segundoNumero;

        public double Divisao(double primeiroNumero, double segundoNumero) => primeiroNumero / segundoNumero;
    }
}

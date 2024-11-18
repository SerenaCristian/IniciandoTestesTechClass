using System;
using System.Collections.Generic;
using System.Text;

namespace IniciandoTestesTechClass
{
    public class Calculadora
    {
        public int Somar(int primeiroNumero, int segundoNumero) => primeiroNumero + segundoNumero; 

        public int Subtracao(int primeiroNumero, int segundoNumero ) => primeiroNumero - segundoNumero;

        public double Multiplicacao(double primeiroNumero, double segundoNumero) => primeiroNumero * segundoNumero;

        public double Divisao(double primeiroNumero, double segundoNumero) => primeiroNumero / segundoNumero;
    }
}

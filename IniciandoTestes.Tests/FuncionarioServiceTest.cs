using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IniciandoTestes.Tests
{
    public class FuncionarioServiceTest
    {
        [Fact]
        public void AdicionarFuncionario_DeveConcluir_QuandoDados_E_Validos() 
        {
            //Arrenge 

            Funcionario funcionario = new Funcionario()
            {
                Nome = "Cristian Olegini Serena",
                Nascimento = new DateTime(1988, 11, 03),
                Senioridade = Senioridade.Pleno,
                Salario = 7550.00
            };



            // act
            FuncionarioService sut = new FuncionarioService();

            // Assert

            sut.AdicionarFuncionario(funcionario);
        }
    }
}

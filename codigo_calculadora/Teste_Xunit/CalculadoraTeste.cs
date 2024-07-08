using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Teste_Xunit
{
    public class CalculadoraTeste
    {
        [Fact]
        public void TesteSomar()
        {
            double resultado = Calculadora.Somar(77, 33);
            Assert.Equal(110,resultado);
        }

        [Fact]
        public void TesteSubtrair()
        {
            double resultado = Calculadora.Subtrair(10, 7);
            Assert.Equal(3, resultado);
        }

        [Fact]
        public void TesteMutiplicação()
        {
            double resultado = Calculadora.Mutiplicar(4, 25);
            Assert.Equal(100, resultado);
        }

        [Fact]
        public void TesteDivisão()
        {
            double resultado = Calculadora.Dividir(81, 9);
            Assert.Equal(9, resultado);
        }

        [Fact]
        public void DivisãoPorZero()
        {
            double resultado = Calculadora.Dividir(10, 0);
            Assert.Equal(double.PositiveInfinity, resultado);
        }
    }
}

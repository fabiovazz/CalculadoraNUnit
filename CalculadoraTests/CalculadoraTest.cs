using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraDominio;
using NUnit.Framework;

namespace CalculadoraTests
{
    [TestFixture]
    public class CalculadoraTest
    {
        [Test]
        public void TestSum()
        {
            //Arrange  levanta os dados para poder executar os testes
            int a = 3;
            int b = 2;
            int r = 5;

            //Act 
            Calculadora calculadora = new();
            int result = calculadora.Sum(a, b);

            //Assert

            Assert.AreEqual(result, r);
        }
        [Test]
        public void TestSubtract()
        {
            int a = 3;
            int b = 2;
            int r = 1;
             
            Calculadora calculadora = new();
            int result = calculadora.Subtract(a, b);

            Assert.AreEqual(result, r);
        }
        [Test]
        public void TestDivision()
        {
            int a = 10;
            int b = 2;
            int r = 5;

            Calculadora calculadora = new();
            int result = calculadora.Division(a, b);

            Assert.AreEqual(result, r);
        }
        [Test]
        public void TestMultiply()
        {
            int a = 3;
            int b = 2;
            int r = 6;

            Calculadora calculadora = new();
            int result = calculadora.Multiply(a, b);

            Assert.AreEqual(result, r);
        }
    }
}

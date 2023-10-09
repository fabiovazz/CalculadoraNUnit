using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDominio
{
    public class Calculadora
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
        public int Subtract(int x, int y)
        {
            return x - y;
        }
        public int Multiply(int x, in int y)
        {
            return x * y;
        }
        public int Division(int x, in int y)
        {
            return x / y;
        }
    }
}

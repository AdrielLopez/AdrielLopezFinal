using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos.BL
{
    public class Triangulo
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }
        public override string ToString()
        {
            return $"Lado1={Lado1 }, Lado2={Lado2}, Lado3={Lado3}";
        }

        public double GetPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
        public double S()
        {
            double d = (Lado1 + Lado2 + Lado3) / 2;
            return d;
        }

        public double GetSuperficie()
        {
            return Math.Sqrt(S() * (S() - Lado1) * (S() - Lado2) * (S() - Lado3));

        }
    }
}

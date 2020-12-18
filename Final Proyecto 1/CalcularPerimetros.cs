using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proyecto_1
{
    class CalcularPerimetros:Perimetros
    {
        public CalcularPerimetros(decimal L, decimal L2, decimal L3, decimal B, decimal A, decimal R, decimal BM, decimal BMR)
        {
            Lado = L;
            Lado2 = L2;
            Lado3 = L3;
            Base1 = B;
            Altura = A;
            Radio = R;
            Basemayor = BM;
            Basemenor = BMR;

        }

        public CalcularPerimetros()
        {
        }

        public decimal CuadradoPerimetro(decimal L)
        {
            return L*4;
        }
        public decimal RectanguloPerimetro(decimal B, decimal A)
        {
            return (B * 2) + (A * 2);
        }
        public decimal TrianguloPerimetro(decimal L, decimal L2, decimal L3)
        {
            return L + L2 + L3;
        }
        public decimal CirculoPerimetro (decimal R)
        {
            return (2*(decimal)Math.PI)*R;
        }
        public decimal RomboidePerimetro(decimal B1, decimal A)
        {
            return (B1 * 2) + (A * 2);
        }
        public decimal TrapecioPerimetro (decimal BM, decimal L, decimal BMR)
        {
            return BM + BMR + (L * 2);
        }
        public decimal PentagonoPerimetro(decimal L)
        {
            return L * 5;
        }
        public decimal HexagonoPerimetro (decimal L)
        {
            return L * 6;
        }
    }
}
 
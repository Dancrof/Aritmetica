using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmProyecto
{
    class ClsCalculos
    {
        public double Sumar(double A, double B)
        {
            double R = A + B;
            return R;
        }
        public double Restar(double A, double B)
        {
            double R = A - B;
            return R;
        }
        public double Multiplicar(double A, double B)
        {
            double R = A * B;
            return R;
        }
        public double Dividir(double A, double B)
        {
            double R = A / B;
            return R;
        }
    }
}

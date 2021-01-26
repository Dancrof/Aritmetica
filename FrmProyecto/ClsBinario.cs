using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmProyecto
{
    class ClsBinario
    {
        public int Sumar(int A, int B)
        {
            int R = A + B;
            return R;
        }
        public int Restar(int A, int B)
        {
            int R = A - B;
            return R;
        }
        public int Multiplicar(int A, int B)
        {
            int R = A * B;
            return R;
        }
        public int Dividir(int A, int B)
        {
            int R = A / B;
            return R;
        }
        
    }
}

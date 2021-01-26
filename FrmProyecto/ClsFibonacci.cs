using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmProyecto
{
    class ClsFibonacci
    {
        public string serie (int cantidad)
        {
            
                string res = " 0 - 1 ";
                int a = 0; int b = 1; int aux;
                int[] arreglo = new int[cantidad];
                arreglo[0] = 0;
                arreglo[1] = 1;
                for (int i = 2; i < cantidad; i++)
                {
                    aux = a + b;
                    a = b;
                    b = aux;
                    res = res + " - " + aux;
                }
                return res;



        }

    }

}

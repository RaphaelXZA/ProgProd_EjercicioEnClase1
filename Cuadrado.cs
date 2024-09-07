using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ejercicio1
{
    internal class Cuadrado : Figura
    {
        public float lados;

        public Cuadrado (float lados)
        {
            this.lados = lados;
        }

        public override float GiveArea()
        {
            return lados * lados;
        }
    }
}

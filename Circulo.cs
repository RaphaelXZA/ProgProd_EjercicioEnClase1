using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ejercicio1
{
    internal class Circulo : Figura
    {
        public float pi = 3.14159265f;
        public float radio;

        public Circulo (float radio)
        {
            this.radio = radio;
        }

        public override float GiveArea()
        {
            return pi * radio * radio;
        }
    }
}

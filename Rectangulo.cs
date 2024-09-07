using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ejercicio1
{
    internal class Rectangulo : Figura
    {
        public float _base;
        public float altura;

        public Rectangulo(float _base, float altura)
        {
            this._base = _base;
            this.altura = altura;
        }

        public override float GiveArea()
        {
            return _base * altura;
        }
    }
}

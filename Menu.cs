using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ejercicio1
{
    internal class Menu
    {
        float primerValor;
        float segundoValor;
        int seleccion;
        Figura figura;
        bool ContinueFlag = true;

        public void Execute()
        {
            while (ContinueFlag)
            {
                Console.WriteLine("------------------------CALCULAR AREA DE FIGURA------------------------");
                Console.WriteLine("Escribe el numero de la figura cuya area quieras calcular:");
                Console.WriteLine("1. Círculo");
                Console.WriteLine("2. Rectángulo");
                Console.WriteLine("3. Cuadrado");
                Console.WriteLine("4. Triángulo");
                Console.WriteLine("0. Salir del programa");
                seleccion = int.Parse(Console.ReadLine());

                switch (seleccion)
                {
                    case 1:
                        Console.WriteLine("Introduce el radio del circulo");
                        primerValor = float.Parse(Console.ReadLine());
                        figura = new Circulo(primerValor);
                        break;
                    case 2:
                        Console.WriteLine("Introduce la base del rectangulo");
                        primerValor = float.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura del rectangulo");
                        segundoValor = float.Parse(Console.ReadLine());
                        figura = new Rectangulo(primerValor, segundoValor);
                        break;
                    case 3:
                        Console.WriteLine("Introduce los lados del cuadrado");
                        primerValor = float.Parse(Console.ReadLine());
                        figura = new Cuadrado(primerValor);
                        break;
                    case 4:
                        Console.WriteLine("Introduce la base del triangulo");
                        primerValor = float.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura del triangulo");
                        segundoValor = float.Parse(Console.ReadLine());
                        figura = new Triangulo(primerValor, segundoValor);
                        break;
                    case 0:
                        ContinueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        continue;


                }

                Console.WriteLine($"El área de la figura es: {figura.GiveArea()}");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("¿Deseas calcular otra figura?");
                Console.WriteLine("1. Sí");
                Console.WriteLine("2. No");
                seleccion = int.Parse(Console.ReadLine());

                if (seleccion == 2)
                {
                    ContinueFlag = false;
                }
            }
        }

    }
}

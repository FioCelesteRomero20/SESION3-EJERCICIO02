using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SESION3_EJERCICIO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Categoria de Hotel");
            Console.WriteLine("0: tres estrellas");
            Console.WriteLine("1: cinco estrellas");
            string tipoTexto = Console.ReadLine();

            Console.WriteLine("Ingrese los dias");
            string diasTexto = Console.ReadLine();


            float dias = float.Parse(diasTexto);
            int categoriaHotel = int.Parse(tipoTexto);


            float precio = 0f;
            float totalestadia = 0f;
            float desayuno = 0f;
            float neto = 0f;

            switch (categoriaHotel)
            {
                case 0:
                    if (11 <= dias)
                    {
                        precio = 70f;
                    }
                    else if (6 <= dias && 10 >= dias)
                    {
                        precio = 85f;
                    }
                    else
                    {
                        precio = 100f;
                    }
                    break;
                case 1:
                    if (11 <= dias)
                    {
                        precio = 250f;
                    }
                    else if (6 <= dias && 10 >= dias)
                    {
                        precio = 270f;
                    }
                    else
                    {
                        precio = 300f;
                    }
                    break;
                default:
                    break;

            }
            totalestadia = precio * dias;
            desayuno = dias * 7;
            neto = totalestadia + desayuno;
            Console.WriteLine("El total es: " + neto);
            Console.ReadKey();
        }
    }
}


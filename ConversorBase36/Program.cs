using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorBase36
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introducimos las variables que necesitaremos en el programa.
            String ListaBase36 = "0123456789ABCDEFGHIJKLMNOPQRSTVWXYZ", solucion="";
            int posicion = 0, paso = 1, numeroamirar = int.Parse(args[0]), ValorFinal=0;
            int[] Resto = new int[100];
            //Guardamos el valor que le introducimos para poder conocerlo al final.
            int numeroenbase10 = numeroamirar;
            if (numeroamirar < 0) //Si el valor introducido, es menor que 0, el programa no tiene que convertir el valor a alfanumerico.
            {
                Console.WriteLine("No se puede convertir numeros negativos, con lo cual no es un numero válido.");
            }
            else
                do
                {
                    //El programa va a ir guardando el resto de la división entre 36 (base36) y ira aumentando el valor de la posicion.
                    Resto[posicion] = (numeroamirar % 36);
                    numeroamirar = (numeroamirar / 36);

                    posicion++;
                } while (numeroamirar != 0);
            posicion--;
            do
            {
                //guardamos el valor en la posicion dentro de un int, para cogerlo como la posición inicial del Substring.
                ValorFinal = Resto[posicion];
                solucion += ListaBase36.Substring(ValorFinal, paso);
                posicion--;
            } while (posicion > (-1));
            //Mostramos el resultado en pantalla.
            Console.WriteLine("El resultado de la conversion de " + numeroenbase10 + " a alfanumérico, es: " + solucion);
        }
    }
}

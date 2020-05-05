using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_UF2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos un array de 5 elementos

            string[] arrayPaisTemperatura = new string[5];

            // Rellenamos el array con la función que hemos creado

            RellenaArrayInformacion(arrayPaisTemperatura);

            Console.WriteLine("Estos son los conjuntos de datos que usted ha introducido:");

            // Hacemos un for para recorrer el array que hemos creado para que muestre al usuario el conjunto de datos

            for (int i = 0; i < arrayPaisTemperatura.Length; i++)
            {
                Console.WriteLine(arrayPaisTemperatura[i]);
            }

            // Calculamos la media de la temperatura de los países con la función que hemos creado

            double media = CalculoTemperaturaMediaPaises(arrayPaisTemperatura);

            // Hacemos esta concatenación de N2 para que muestre solo dos decimales por pantalla

            Console.WriteLine($"La media de temperatura de los países que ha introducido es de {media.ToString("N2")}º Grados Centígrados de media");

            Console.ReadKey();
        }

        // Creamos la función para que nos rellene el array que hemos creado de 5 elementos de información

        private static void RellenaArrayInformacion(string[] array)
        {
            // Indicamos al usuario los pasos a seguir

            Console.WriteLine("Por favor, ingrese por teclado 5 países diferentes y su temperatura en Grados Centígrados media a lo largo del año");

            // Iniciamos un for para que recorra el array mientras le vamos introduciendo información en cada vuelta que da

            for (int i = 0; i < array.Length; i++)
            {
                // Indicamos instrucción al usuario de introducir nombre del país

                Console.WriteLine($"Por favor, escriba el nombre del país {i + 1}");

                // Recibimos el nombre del país que ha introducido el usuario

                string pais = Console.ReadLine();

                // Indicamos instrucción al usuario de introducir la temperatura media del país

                Console.WriteLine("Escribe su temperatura media en Cº");

                // Recibimos la temperatura media del país que ha introducido el usuario

                string temperatura = Console.ReadLine();

                // Le damos forma a la información de esta manera: pais + "," + temperatura

                array[i] = $"{pais},{temperatura}"; 

            }

            // Fin de la función
  
        }



        // Creamos la función para que nos calcule la media de temperatura en el array que hemos creado de 5 elementos anteriormente

        private static double CalculoTemperaturaMediaPaises(string[] array)
        {
            // Iniciamos las variables de tipo double y las inicializamos en 0; necesitaremos la temperatura, la suma de la temperatura, el sumatorio para saber cuántos índices hay y el resultado que nos va a devolver

            double temperatura = 0;
            double suma = 0;
            double sumatorio = 0;
            double resultado = 0;

            // Iniciamos un for para que el array vaya obteniendo la información de las temperatura en cada vuelta que da

            for (int i = 0; i < array.Length; i++)
            {
                // Creamos una variable de tipo string en el que nos haga una cadena de caracteres en cada posición del array, de modo que quede de la siguiente manera: China,25

                string paisMedia = array[i];

                // Con la siguiente variable tipo int, y con el método IndexOf, nos nuestra la posición donde se encuentre un caracter, en nuestro caso la "," para utilizarla en la siguiente sentencia

                int posicionComa = paisMedia.IndexOf(',');

                /* Creamos otra variable tipo string y mediante substring tendremos solo la parte de la temperatura, la iniciamos en una posición después de la coma, 
                 * y la finalizamos añadiendo tantas cifras como tenga la temperatura introducida. Recordar que se empieza contado en la posición 0, por eso a la posición de la coma al final se resta 1*/

                string temperaturaTexto = paisMedia.Substring(posicionComa + 1, paisMedia.Length - posicionComa - 1);

                // Creamos una variable nueva tipo double y hacemos un parse para pasar la variable string a tipo double

                temperatura = double.Parse(temperaturaTexto);

                // Calculamos la media

                suma = suma + temperatura;

                sumatorio++;

            }

            // Creamos la fórmula

            resultado = suma / sumatorio;

            // Devolvemos el dato que queremos pasar al main

            return resultado;

            // Fin de la función

        }
    }
}


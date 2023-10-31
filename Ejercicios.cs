using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciosdebusqueda
{
    public class Ejercicios
    {
        public void Ejercicio1()
        {
            int[] numeros = { 1,2,3,4,5,6,7,8,9,10};

            Console.Write("Ingrese un número a buscar: ");
            int numeroABuscar = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroABuscar)
                {
                    Console.WriteLine($"El número {numeroABuscar} esta en la posición {i}");
                    return;
                }
            }

            Console.WriteLine($"El número {numeroABuscar} no se encuentra");
        }
        public void Ejercicio2()
        {
            string[] cadenas = { "dalia", "angelica", "maria", "carlos", "rigoberto" };

            Console.Write("Ingrese una cadena a buscar: ");
            string cadenaABuscar = Console.ReadLine();

            for (int i = 0; i < cadenas.Length; i++)
            {
                if (cadenas[i] == cadenaABuscar)
                {
                    Console.WriteLine($"La cadena '{cadenaABuscar}' esta en la posición {i}");
                    return;
                }
            }

            Console.WriteLine($"La cadena '{cadenaABuscar}' no se encuentra");
        }
        public void Ejercicio3()
        {
            int[] numeros = { 1,2,3,4,5,6,7,8,9,10 };

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine($"El primer número par se encuentra en la posición {i}");
                    return;
                }
            }

            Console.WriteLine("No se encontraron números pares");
        }
        public void Ejercicio4()
        {
            int[] numeros = { 1,2,3,4,5,6,7,8,9,10};

            Console.WriteLine("Posiciones de números pares en la matriz:");
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine($"Número par en la posición {i}");
                }
            }
        }
        public void Ejercicio5()
        {
            int[] numerosOrdenados = { 1,2,3,4,5,6,7,8,9,10 };

            Console.Write("Ingrese el numero a buscar: ");
            int numeroABuscar = int.Parse(Console.ReadLine());

            int inicio = 0;
            int fin = numerosOrdenados.Length - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (numerosOrdenados[medio] == numeroABuscar)
                {
                    Console.WriteLine($"El numero {numeroABuscar} se encuentra en la posición {medio}");
                    return;
                }
                else if (numerosOrdenados[medio] < numeroABuscar)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            Console.WriteLine($"El numero {numeroABuscar} no se encuentra");
        }
        public void Ejercicio6()
        {
            string[] cadenasOrdenadas = { "dalia", "angelica", "maria", "carlos", "rigoberto" };

            Console.Write("Ingrese una cadena a buscar: ");
            string cadenaABuscar = Console.ReadLine();

            int inicio = 0;
            int fin = cadenasOrdenadas.Length - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                int comparacion = string.Compare(cadenaABuscar, cadenasOrdenadas[medio]);

                if (comparacion == 0)
                {
                    Console.WriteLine($"La cadena '{cadenaABuscar}' se encuentra en la posición {medio}");
                    return;
                }
                else if (comparacion > 0)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            Console.WriteLine($"La cadena '{cadenaABuscar}' no se encuentra");
        }
        public void Ejercicio7()
        {
            int[] numerosOrdenados = { 1,2,3,4,5,6,7,8,9,10 };

            int inicio = 0;
            int fin = numerosOrdenados.Length - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (numerosOrdenados[medio] % 2 == 0)
                {
                    Console.WriteLine($"El primer número par se encuentra en la posición {medio}");
                    return;
                }
                else if (numerosOrdenados[medio] % 2 != 0)
                {
                    inicio = medio + 1;
                }
            }

            Console.WriteLine("No se encontraron números pares");
        }
    }
}

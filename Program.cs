using System;

namespace T03_3
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int X = 1;
            int Y = 2;

            double N = 0.55;
            double M = 1.66;

            int resultado = 0;
            double resultado2 = 0;

            //Mostrar valores de variables
            Console.WriteLine("Los valores de las variables son los siguientes: ");            
            Console.WriteLine("Variable X = {0}", X);
            Console.WriteLine("Variable Y = {0}", Y);
            Console.WriteLine("Variable N = {0}", N);
            Console.WriteLine("Variable M = {0}", M);

            //Mostrar resultados de las operaciones con variables
            resultado = X + Y;
            Console.WriteLine("La suma de X e Y es {0}", resultado);

            resultado = X - Y;
            Console.WriteLine("La resta de X e Y es {0}", resultado);

            resultado = X * Y;
            Console.WriteLine("La multiplicación de X e Y es {0}", resultado);

            resultado = X / Y;
            Console.WriteLine("La división de X e Y es {0}", resultado);

            resultado = X % Y;
            Console.WriteLine("El resto de X e Y es {0}", resultado);

            resultado2 = N + M;
            Console.WriteLine("La suma de N y M es {0}", resultado2);

            resultado2 = N - M;
            Console.WriteLine("La resta de X e Y es {0}", resultado2);

            resultado2 = N * M;
            Console.WriteLine("La multiplicación de X e Y es {0}", resultado2);

            resultado2 = N / M;
            Console.WriteLine("La división de X e Y es {0}", resultado2);

            resultado2 = N % M;
            Console.WriteLine("El resto de X e Y es {0}", resultado2);

            resultado2 = X + N;
            Console.WriteLine("La SUMA DE X y N es {0}", resultado2);

            resultado2 = Y / M;
            Console.WriteLine("La división de Y y M es {0}", resultado2);

            resultado2 = Y % M;
            Console.WriteLine("El resto de Y y M es {0}", resultado2);

            //Calcular y mostrar los dobles de cada variable
            resultado2 = X * 2;
            Console.WriteLine("El doble de X es {0}", resultado2);

            resultado2 = Y * 2;
            Console.WriteLine("El doble de Y es {0}", resultado2);

            resultado2 = N * 2;
            Console.WriteLine("El doble de N es {0}", resultado2);

            resultado2 = M * 2;
            Console.WriteLine("El doble de M es {0}", resultado2);

            //Suma de todas las variables
            resultado2 = X+Y+N+M;
            Console.WriteLine("La suma de todas las variables es {0}", resultado2);

            //Producto de todas las variables
            resultado2 = X * Y * N * M;
            Console.WriteLine("El producto de todas las variables es {0}", resultado2);
        }
    }
}

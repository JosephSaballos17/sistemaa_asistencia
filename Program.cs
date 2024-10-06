//Trabajo Realizado por Joseph Saballos 1M2-S



using System;

namespace SistemaAsistencia
{
    class Program
    {
        public static void Main(string[] args)
        {

            double asistenciasTotales = 0;

            // Bienvenida al sistema 


            Console.WriteLine("Bienvenido al Sistema de Asistencias de la Universidad Nacional de Ingenieria ");
            Console.WriteLine();




            Console.WriteLine("Ingrese la Cantidad de Estudiantes");
            int estudiante = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();




            // Bucle para pedir  las asistencias totales
            do
            {
                Console.WriteLine("Ingrese la Asistencia Total: ");
                asistenciasTotales = Convert.ToInt32(Console.ReadLine());
                if (asistenciasTotales < 0)
                {
                    Console.WriteLine("Dato erroneo, Ingrese un numero Positivo Por favor");
                }

            } while (asistenciasTotales < 0);




            //Declaracion de Arreglos 

            string[] cantidadnombres = new string[estudiante];
            double[] cantidadasistenias = new double[estudiante];





            // Arreglo que recopila la cantidad de estudiantes 


            for (int i = 0; i < cantidadnombres.Length; i++)
            {
                Console.WriteLine();

                Console.WriteLine($"Nombre del Estudiante {i + 1} ");
                cantidadnombres[i] = Console.ReadLine();



                // Recopilacion de sesiones que asistio el estudiante 
                do
                {

                    Console.WriteLine("Imgrese las Sesiones Asistidas: ");
                    cantidadasistenias[i] = Convert.ToDouble(Console.ReadLine());
                    if (cantidadasistenias[i] < 0)
                    {

                        Console.WriteLine("Dato erroneo, Por favor Ingrese un numero Positivo");
                    }



                } while (cantidadasistenias[i] < 0);

                var informacion = new Universidad.Estudiante
                {

                    nombre = cantidadnombres[i],
                    numerosesionesTotales = asistenciasTotales,
                    numerosesionesAsistidas = cantidadasistenias[i],

                };

                informacion.mostrarinfo();

            }



            Console.WriteLine();
            Console.WriteLine("Los Nombre Ingresados Fueron: ");
            foreach (var i in cantidadnombres)
            {
                Console.WriteLine(i);
            }



            // Mensaje de Despedida

            Console.WriteLine();
            Console.WriteLine("Gracias por usar nuestro sistema!");

        }


    }

}
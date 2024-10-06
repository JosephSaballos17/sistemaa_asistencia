using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SistemaAsistencia.Universidad;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SistemaAsistencia
{



    public class Universidad
    {
        public class Estudiante //Clase Principal

        {
            // Variables para el estudiante 

            public string nombre { get; set; }
            public double numerosesionesTotales { get; set; }
            public double numerosesionesAsistidas { get; set; }



            public class Asistencia //Clase Interna llamada Asistencia 
            {

                //Metodo para mostrar la asistencia 
                public static double MostrarPorcentaje(double sesionesAsistidas, double sesionesTotales)
                {

                    return (double)sesionesAsistidas / sesionesTotales * 100;

                    if (sesionesTotales == 0)
                    {
                        return 0;
                    }




                }


            }
            //Metodo para mostrar la informacion del estudiante 
            public void mostrarinfo()
            {
                Console.WriteLine($"nombre : {nombre} numero de sesiones totales: {numerosesionesTotales}, numero de sesiones asistidas: {numerosesionesAsistidas}");


                double asistencia = Asistencia.MostrarPorcentaje(numerosesionesAsistidas, numerosesionesTotales);

                // Validacion de la asistencia 

                if (asistencia >= 75)
                {
                    Console.WriteLine("El estudiante cumple con el requisito de asistencia.");
                }
                else
                {

                    Console.WriteLine("Lo siento, el estudiante no cumple con el requisito de asistencia.");
                }






            }

        }



    }
}
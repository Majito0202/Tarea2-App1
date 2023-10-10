using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1- EJERCICIO 1");
                Console.WriteLine("2- EJERCICIO 2");
                Console.WriteLine("3- EJERCICIO 3");
                Console.WriteLine("4- SALIR");
                Console.WriteLine("DIGITA UNA OPCION");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Ejercicio1();
                        break;
                    case 2:
                        Console.Clear();
                        Ejercicio2();
                        break;
                    case 3:
                        Console.Clear();
                        Ejercicio3();
                        break;
                    default:
                        Console.WriteLine("OPCION INCORRECTA:");
                        break;
                }
            } while (opcion != 4); //mientras que la opcion sea diferente de 4
        }

        public static void Ejercicio1() // metodo 
        {
            float precio = 0f;
            int cantidad = 0;
            float total = 0f;

            Console.WriteLine("Digite el precio la camiseta: ");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad == 1)
            {
                Console.WriteLine("$total a pagar: {cantidad * precio}");
            }

            if (cantidad >= 2 && cantidad <= 6)
            {
                total = precio * 0.15f; //calcular el 15%
                total = precio - total; //
                Console.WriteLine($"Precio por artículo: ${total} + monto de descuento 15%");
            }

            if (cantidad >= 6)
            {
                total = precio * 0.2f; //calcular el 15%
                total = precio - total; //
                Console.WriteLine($"Precio por artículo: ${total} + monto de descuento 20%");
            }
        }

        public static void Ejercicio2()
        {
            const double PORCENTAJE_QUIZES = 0.25;
            const double PORCENTAJE_TAREAS = 0.30;
            const double PORCENTAJE_EXAMENES = 0.45;

            int totalEstudiantes;
            Console.Write("DIGITE NUMERO DE ESTUDIANTES: ");
            while (!int.TryParse(Console.ReadLine(), out totalEstudiantes) || totalEstudiantes <= 0)
            {
                Console.WriteLine("DIGITE UN NUMERO VALIDO.");
                Console.Write("DIGITE NUMERO DE ESTUDIANTES: ");
            }

            for (int i = 0; i < totalEstudiantes; i++)
            {
                Console.WriteLine("DIGITE DATOS PARA EL ESTUDIANTE {i + 1}:");
                Console.Write("CARNET: ");
                string carnet = Console.ReadLine();

                Console.Write("NOMBRE: ");
                string nombre = Console.ReadLine();

                double[] quices = new double[3];
                double[] tareas = new double[3];
                double[] examenes = new double[3];

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" INGRESE CALIFICACION DEL QUIZ {j + 1}: ");
                    while (!double.TryParse(Console.ReadLine(), out quices[j]) || quices[j] < 0 || quices[j] > 100)
                    {
                        Console.WriteLine("DIGITE CALIFICACION VALIDA (ENTRE 0 Y 100).");
                        Console.Write($"DIGITE CALIFICACION DE QUIZ {j + 1}: ");
                    }

                    Console.Write($"DIGITE CALIFICACIÓN DE TAREA {j + 1}: ");
                    while (!double.TryParse(Console.ReadLine(), out tareas[j]) || tareas[j] < 0 || tareas[j] > 100)
                    {
                        Console.WriteLine("DIGITE CALIFICACION VALIDA (entre 0 y 100).");
                        Console.Write($"DIGITE CALIFICACION DE TAREA {j + 1}: ");
                    }

                    Console.Write($"DIGITE CALIFICACION DE EXAMEN {j + 1}: ");
                    while (!double.TryParse(Console.ReadLine(), out examenes[j]) || examenes[j] < 0 || examenes[j] > 100)
                    {
                        Console.WriteLine("DIGITE CALIFICACION VALIDA (entre 0 y 100).");
                        Console.Write($"DIGITE CALIFICACION DE EXAMEN  {j + 1}: ");
                    }
                }

                double promedioQuices = (quices[0] + quices[1] + quices[2]) / 3;
                double promedioTareas = (tareas[0] + tareas[1] + tareas[2]) / 3;
                double promedioExamenes = (examenes[0] + examenes[1] + examenes[2]) / 3;

                double promedioFinal = promedioQuices * PORCENTAJE_QUIZES + promedioTareas * PORCENTAJE_TAREAS + promedioExamenes * PORCENTAJE_EXAMENES;

                Console.WriteLine($"CARNET: {carnet}");
                Console.WriteLine($"NOMBRE: {nombre}");
                Console.WriteLine($"PORCENTAJE DE QUICES: {promedioQuices * PORCENTAJE_QUIZES:P2}");
                Console.WriteLine($"PORCENTAJE DE TAREAS: {promedioTareas * PORCENTAJE_TAREAS:P2}");
                Console.WriteLine($"PORCENTAJE DE EXAMENES: {promedioExamenes * PORCENTAJE_EXAMENES:P2}");
                Console.WriteLine($"PROMEDIO FINAL: {promedioFinal:P2}");

                if (promedioFinal >= 70)
                {
                    Console.WriteLine("Condición: APROBADO");
                }
                else if (promedioFinal >= 50 && promedioFinal < 70)
                {
                    Console.WriteLine("Condición: APLAZADO");
                }
                else
                {
                    Console.WriteLine("Condición: REPROBADO");
                }

            }
        }


        public static void Ejercicio3()
        {
            int cantidadArticulos;
            double precioPorArticulo;
            double precioTotal;

            Console.WriteLine("INGRESE LA CANTIDAD DE ARTICULOS QUE DESEA COMPRAR: ");
            cantidadArticulos = Convert.ToInt32(Console.ReadLine());

            // precio por artículo según la cantidad comprada
            if (cantidadArticulos <= 10)
            {
                precioPorArticulo = 20;
            }
            else
            {
                precioPorArticulo = 15;
            }

            // Calcular el precio total
            precioTotal = cantidadArticulos * precioPorArticulo;

            // Mostrar resultados
            Console.WriteLine($"PRECIO POR CADA UNO: ${precioPorArticulo}");
            Console.WriteLine($"PRECIO TOTAL A PAGAR: ${precioTotal}");

        }
    }
}


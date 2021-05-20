using System;
using System.Collections.Generic;
using System.Linq;

namespace M1NETCore_ConsoleHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreCurso = ".NET Core web con C#";
            int edad = 30;
            double monto = 350.5;

            string salario = "Mil dólares";
            string detalleEdad = String.Empty;

            var listado = new List<Persona>();

            var per1 = new Persona();
            per1.dni = "11223344";
            per1.nombre = "Jose Paolo";
            per1.telefono = 887874774;

            var per2 = new Persona("22334455","Jefferson Carlos",4455465);

            listado.Add(per1);
            listado.Add(per2);
            listado.Add(new Persona("33445566", "Edison Miguel", 545455));

            foreach (var item in listado)
            {
                Console.WriteLine(item.dni + " " +
                                  item.nombre + " " +
                                  item.telefono);
            }

            var busqueda = listado.Where(x => x.dni == "22334455").FirstOrDefault();

            Console.WriteLine("Se encontró a: " + busqueda.nombre);

            Console.WriteLine("Hello World!");
        }
    }
}

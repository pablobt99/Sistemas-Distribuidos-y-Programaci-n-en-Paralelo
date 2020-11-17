using System;

namespace ClasesOnline
{
    class Program
    {
      

        static void Main(string[] args)
        {
            /* Sesión 1:
            Vehiculo UnVehiculo = new Vehiculo();
            Console.WriteLine(UnVehiculo.Modelo);
            Console.WriteLine(UnVehiculo.Submodelo);
            //para llamar a un miembro estatico se le llama con el nombre de la clase no el objeto
            Vehiculo.ConverturMiilasAKilometros(8);
            */

            /*
            Persona Persona2 = new Persona("Gonzalo Gonzalez");
            Console.WriteLine(Persona2.Nombre);
            Console.WriteLine(Persona2.FechaNacimiento);
            Persona2.ComunicarIncidaencia("ha perdido DNI");
            Console.WriteLine(Persona2.ToString()); //devuelve el nombre completo de la clase
            */
            /*
            Empleado Empleado1 = new Empleado(154,"simp");
            Console.WriteLine(Empleado1.Nombre);
            Console.WriteLine(Empleado1.DNI);
            Console.WriteLine(Empleado1.FechaNacimiento);
            Empleado1.ComunicarIncidaencia("ha perdido DNI");
            */

            Persona persona1 = new Persona("Gonzalo");
            Persona persona2 = new Persona("FErnando");
            persona2 = persona1;
            persona1.FechaNacimiento = new DateTime(2000, 1, 1);
            Console.WriteLine(persona1.FechaNacimiento);
            Console.WriteLine(persona2.FechaNacimiento);


            Console.ReadLine();
        }
    }
}

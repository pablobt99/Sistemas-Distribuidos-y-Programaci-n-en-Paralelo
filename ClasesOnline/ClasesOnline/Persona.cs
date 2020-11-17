using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesOnline
{
    public class Persona
    {
        public string Nombre { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string DNI { get; set; }

        public Persona(string ElNombre)
        {
            this.Nombre = ElNombre;
            this.FechaNacimiento = new DateTime(1990, 2, 15);
        }
        public virtual /*virtual permite sobre escribir en empleado*/ void ComunicarIncidaencia(string ExplicacionIncidencia)
        {
            object Miobjeto = new object();
            Miobjeto.ToString();
            Console.WriteLine($"Para la perosna{this.Nombre} se ha comunicado una incidencia");
        }
    }
}

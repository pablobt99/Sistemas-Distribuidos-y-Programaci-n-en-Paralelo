using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClasesOnline
{
    public class Empleado: Persona //herenda de Persoba
    {
         public Empleado(int ElIdEmpleado, string ElNombre): base(ElNombre)
            {
            this.IdEmpleado = ElIdEmpleado;
            }
        public int IdEmpleado { get; }
        }
    public override void ComunicarIncidaencia(string ExplicacionIncidencia)
    {
        Console.WriteLine("Envio mail recursos humanos");
        base.ComunicarIncidaencia(ExplicacionIncidencia);
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;

namespace Servidor1
{
    public class MovieTicket : MarshalByRefObject,MovieTicket //marsal necesario para instanciar un objeto demanera distribuida
    {
        public string GetTicketStatus(string stringToPrint) 
        {
            string returnStatus = "Ticket Confirmado";
            Console.WriteLine($"Requiriendo{stringToPrint}");
            Console.WriteLine($"Enviado confirmación:{returnStatus}");
            return returnStatus;        
        }

    }
}

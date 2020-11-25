using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;

namespace Remoting
{
    class MovieTicket : MarshalByRefObject, IMovieTicket //para poder hacer remoting necesario MarshalByRefObject(Proxy)
    {
        public string GetTicketStatus(string stringToPrint)
        {
            string returnStatus = "Ticket confirmado";
            Console.WriteLine($"Requiriendo {stringToPrint}");
            Console.WriteLine($"Enviando confirmación:{returnStatus}");
            return returnStatus;

        }
    }
}

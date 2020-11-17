using System;

namespace Negocio
{
  
  
       public interface IMovieTicket//para comunicar el cliente y el servidor
       {
        string GetTicketStatus(string stringToPrint);
        }
}

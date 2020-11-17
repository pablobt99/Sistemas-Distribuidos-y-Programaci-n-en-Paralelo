using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace Cliente1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            TcpChanel Elcanal = new TcpChanel();
            ChanelService.RegisterChannel(Elcanal, false);
            Type ElTipo = typeof(IMovieTicket);

            IMovierTicker ElTicketRemoto = (IMOvieticket)Activaor.GetObject(ElTipo, "tcp://localhost:9998/MovieTicketBooking");
            ElTicketRemoto.GetTicketStatus("Ticket Nº: 556832");
            Console.WriteLine(Resultado);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("servidor de Tickets activaso");
            TcpChanel tcpChanel = new TcpChanel(9998);
            ChanelServices.REgisterChanel(tcpChanel, false);
            Type commonInterfaceType = typeof(MovieTicket);
            RemotingConfiguration.RegisterWellKnownServiceType(commonInterfaceType, "MovieTicketBooking", WellKnownObjectMode.SingleCall);
            Console.WriteLine("Pulse Enter para salir");
            Console.ReadLine();
        }     
       
    }
}

using Negocio;
using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Cliente
{
    class MyClient
    {
        public static void Main()
        {
            TcpChannel ElCanal = new TcpChannel();
            ChannelServices.RegisterChannel(ElCanal, false);
            Type ElTipo = typeof(IMovieTicket);
            IMovieTicket ElTicketRemoto = (IMovieTicket)Activator.GetObject(ElTipo, url: "tcp://localhost:9998/MovieTicketBooking");/*la parte de la derecha devuelve un objeto por lo que hay que convertirlo con (IMovieTicket)*/
            string Resultado = ElTicketRemoto.GetTicketStatus("Ticket Nº 5569854");
            Console.WriteLine(Resultado);
            Console.ReadLine();

            /*
            TcpChannel tcpChannel = new TcpChannel();
            ChannelServices.RegisterChannel(tcpChannel);
            Type requiredType = typeof(MovieTicketInterface);
            MovieTicketInterface remoteObject =
            (MovieTicketInterface)Activator.GetObject(requiredType,
            "tcp://localhost:9998/MovieTicketBooking");
            Console.WriteLine(remoteObject.GetTicketStatus("Ticket No: 3344"));
            */
        }
    }

}

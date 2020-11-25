﻿using Remoting; //hay que usar la solución
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

class Program
{


    static void Main(string[] args)
    {
        Console.WriteLine("Servidor de Tickets Activado");
        TcpChannel tcpChannel = new TcpChannel(9998);
        ChannelServices.RegisterChannel(tcpChannel, false);
        Type commonInterfaceType = typeof(MovieTicket);
        RemotingConfiguration.RegisterWellKnownServiceType(commonInterfaceType, "MovieTicketBooking", WellKnownObjectMode.SingleCall);
        Console.WriteLine("Pulsa Enter para salir");

    }
/*
       TicketServer();
   }
   static void TicketServer()
   { 
       Console.WriteLine("Ticket Server started...");
       TcpChannel tcpChannel = new TcpChannel(9998);
       ChannelServices.RegisterChannel(tcpChannel);
       Type commonInterfaceType = Type.GetType("MovieTicket");
       RemotingConfiguration.RegisterWellKnownServiceType(commonInterfaceType,
       "MovieTicketBooking", WellKnownObjectMode.SingleCall);
       System.Console.WriteLine("Press ENTER to quitnn");
       System.Console.ReadLine();
   }
}
public interface MovieTicketInterface
{
   string GetTicketStatus(string stringToPrint);
}
public class MovieTicket : MarshalByRefObject, MovieTicketInterface
{
   public string GetTicketStatus(string stringToPrint)
   {
       string returnStatus = "Ticket Confirmed";
       Console.WriteLine("Enquiry for {0}", stringToPrint);
       Console.WriteLine("Sending back status: {0}", returnStatus);
       return returnStatus;
   }
   */
    }

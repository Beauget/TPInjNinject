﻿using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjectionTP
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Test mode 0

            Console.WriteLine("Test premier mode Ninject : ");
            IKernel kernel = new StandardKernel(new MonModule(0));

            IChargementParametres test;
            test = kernel.Get<IChargementParametres>();
            TicketDeCaisse ticketTest1 = new TicketDeCaisse(test);



           Console.WriteLine(ticketTest1.getParamClientTicket("08212"));
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");

            //Test mode 1 
            Console.WriteLine("Test second mode Ninject : ");
            IKernel kernel2 = new StandardKernel(new MonModule(1));

            IChargementParametres test2;
            test2 = kernel2.Get<IChargementParametres>();
            TicketDeCaisse ticketTest2 = new TicketDeCaisse(test2);



            Console.WriteLine(ticketTest2.getParamClientTicket("08213"));

        }
    }
}

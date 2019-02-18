using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waiting_Distribution
{
    class Program
    {
        static void Main(string[] args)
        {
            int running = 0;
            while (running == 0)
            {
                Console.WriteLine("Please select the queue model: M/M/1 (1), M/M/S (2), M/D/1, (3), M/M/1 with finite source (4)");
            int program;
                program = Convert.ToInt32(Console.ReadLine());


            double n;
            double arrivals;
            double period;
                                                                        
            double lambda; //average number of arrivals per time period                                                                 Formula : (arrivals/period)
            double mu;     //average number of people served per time period (average service rate)                                     Formula : (customers served/time period)
            double Ls;     //average number of units (customers) in the system (waiting and being served)                               Formula : (lambda / (mu - lambda)
            double Ws;     //average time a unit spends in the system (waiting time plus service time)                                  Formula : (1 / (mu - lambda)
            double Lq;     //average number of units waiting in the queue                                                               Formula : (lambda^2)/(mu)*(mu-lambda)
            double Wq;     //average time a unit spends waiting in the queue                                                            Formula : ((lamda)/(mu)*(mu-lambda) OR Lq/lambda
            double rho;    //utilization factor for the system (p)                                                                      Formula : (lambda/mu)
            double rhoSub0; // probability of 0 units in the system (that is, the service unit is idle)                                 Formula : (1-(lambda/mu))
            double rhoNGreaterThanK; //probability of more than k units in the system, where n is the number of units in the system     Formula : (lambda/mu)^(k+1)


            
               
                

                if (program==1)
                {
                    Console.WriteLine("Modelling beginning");
                    Console.WriteLine("Model M/M/1 - Single-Server System - Channel: Single - Phases: Single - Arrival Rate Pattern: Poisson - Service Time Pattern: Negative Exponential - Population Size: Unlimited - Queue Discipline: FIFO");

                    Console.WriteLine("Is lambda or mu unknown? (y) or n)");
                    string userQ = null;
                    userQ = Console.ReadLine();
                    if (userQ == "y") 
                    {
                       
                        Console.WriteLine("arrivals?");
                        arrivals =Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("time period");
                        period = Convert.ToDouble(Console.ReadLine());
                        lambda = arrivals / period;
                        Console.WriteLine("lambda is {0}",lambda);


                    }
                    Console.WriteLine("arrivals per hour? (lambda)");
                    lambda = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("average service rate? (mu)");
                    mu = Convert.ToDouble(Console.ReadLine());
                    Lq = (Math.Pow(lambda, 2))/((mu)*(mu-lambda));
                    Console.WriteLine("Lq, or average number of units waiting in the queue, is {0}",Lq);
                    Ls = ((lambda) / ((mu - lambda)));
                    Console.WriteLine("LS, or average number of units (customers) in the system (waiting and being served) is, {0}",Ls);
                    Wq = Lq / lambda;
                    Console.WriteLine("Wq, or average time a unit spends waiting in the queue, is {0}",Wq);
                    Ws = 1 / (mu - lambda);
                    Console.WriteLine("Ws, or average time a unit spends in the system (waiting time plus service time, is {0}", Ws);
                    rho = (lambda / mu);
                    Console.WriteLine("rho, or p, or utilization factor for the system is {0}", rho);
                    rhoSub0 = (1 - (lambda / mu));
                    Console.WriteLine("rho subscript 0, or the probability that there are 0 units in the system, (that is the service unit is idle), is {0}", rhoSub0);
                    


                    Console.WriteLine("Would you like to convert all values by a factor? yes (1) no (2)");
                    int convertFactor;
                    convertFactor = Convert.ToInt32(Console.ReadLine());
                    if (convertFactor==1)
                    {
                        Console.WriteLine("enter factor");
                        double factor;
                        factor = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Values multiplied by a factor of {0} are as follows:",factor);
                        Lq = Lq * factor;
                        Console.WriteLine("Lq, or average number of units waiting in the queue, is {0}", Lq);
                        Ls = Ls * factor;
                        Console.WriteLine("LS, or average number of units (customers) in the system (waiting and being served) is, {0}", Ls);
                        Wq = Wq * factor;
                        Console.WriteLine("Wq, or average time a unit spends waiting in the queue, is {0}", Wq);
                        Ws = Ws * factor;
                        Console.WriteLine("Ws, or average time a unit spends in the system (waiting time plus service time, is {0}", Ws);
                        rho = rho * factor;
                        Console.WriteLine("rho, or p, or utilization factor for the system is {0}", rho);
                        

                    }
                    if (convertFactor == 2)
                    {
                      
                    }
                }







                Console.WriteLine("Would you like to continue the program? yes (0), no (1)");
                running = Convert.ToInt32(Console.ReadLine());
                if (running==1)
                {
                    break;
                }

            }
            Console.WriteLine("Press enter to continue...");
            Console.Read();   
        }
    }
}

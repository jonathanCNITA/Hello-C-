using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean ExitProgram = false;
            DateTime Now = DateTime.Now;

            string MessageToReturn = "no";
            string UserName = Environment.UserName;

            if( Now.DayOfWeek == DayOfWeek.Saturday
                || Now.DayOfWeek == DayOfWeek.Sunday
                || Now.DayOfWeek == DayOfWeek.Friday && Now.Hour > 18
                || Now.DayOfWeek == DayOfWeek.Monday && Now.Hour < 9
                )
            {
                MessageToReturn = "Bon weekend " + UserName;
            } else if (Now.Hour >= 9 && Now.Hour < 13 )
            {
                MessageToReturn = "Bonjour " + UserName;
            }
            else if (Now.Hour >= 13 && Now.Hour < 18)
            {
                MessageToReturn = "Bonne aprem " + UserName;
            } else
            {
                MessageToReturn = "Bonsoir " + UserName;
            }

            while( !ExitProgram )
            {
                Console.WriteLine(Now.Hour);
                Console.WriteLine(MessageToReturn);
                Console.WriteLine("Write 'exit' to quit the program");
                string userChoice = Console.ReadLine();
                ExitProgram = (userChoice == "exit");
            }

        }
    }
}

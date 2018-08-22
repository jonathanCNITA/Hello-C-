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
            Message greeting = new Message( new RealTime() );

            while ( !ExitProgram )
            {
                
                Console.WriteLine(greeting.GetHelloMessage());
                Console.WriteLine("Write 'exit' to quit the program");
                string userChoice = Console.ReadLine();
                ExitProgram = (userChoice == "exit");
            }
        }
    }
}

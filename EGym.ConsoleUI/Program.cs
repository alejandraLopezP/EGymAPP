using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EGym.Logic;
using EGym.Logic.Models.People;

namespace EGym.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic.EGym gym = new Logic.EGym();
            while (true)
            {
                Console.WriteLine("Press N to register new Client");
                Console.WriteLine("Press R to Register a New Activity:  ");
                Console.WriteLine("Press S to see the Gym schedule: ");
                Console.WriteLine("Press Q to Exit the system: ");

                var pressedKey = Console.ReadLine();

                switch (pressedKey.ToUpper())
                {
                    case "N":
                        //TODO new client registration
                        Console.WriteLine("Type your name");
                        string input = Console.ReadLine();
                        string name = input;
                        Console.WriteLine("Type your Email");
                        input = Console.ReadLine();
                        string eMail = input;
                        Console.WriteLine("Type your phone number");
                        input = Console.ReadLine();
                        string phoneNumber = input;




                        break;
                    case "R":

                        break;
                    case "S":

                        var result = gym.ShowSchedule();
                        Console.WriteLine(result);
                        break;
                    case "Q":
                        Console.WriteLine("Thanks for using our App!");
                        return;
                    default:
                        break;
                }
            }

        }
    }
}

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
                Console.WriteLine("Press R to Register a New Activity:  ");
                Console.WriteLine("Press S to see the Gym schedule: ");
                Console.WriteLine("Press Q to Exit the system: ");

                var pressedKey = Console.ReadLine();

                switch (pressedKey)
                {
                    case "C": // Create new user
                        Console.WriteLine("Name:");
                        string input = Console.ReadLine();
                        string name = input;
                        Console.WriteLine("Email:");
                        input = Console.ReadLine();
                        string email = input;
                        Console.WriteLine("Number:");
                        input = Console.ReadLine();
                        string number = input;

                        Client oClient = new Client(name, email, number); 

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

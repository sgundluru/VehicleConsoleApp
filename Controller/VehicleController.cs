using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleConsoleApp.Interface;

namespace VehicleConsoleApp.Controller
{
    public class VehicleController
    {
        private IVehicle vehicle;

        public VehicleController(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Enter your choice: ");
                Console.WriteLine("1. Start");
                Console.WriteLine("2. Stop");
                Console.WriteLine("3. Accelerate");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        vehicle.Start();
                        break;
                    case 2:
                        vehicle.Stop();
                        break;
                    case 3:
                        Console.WriteLine("Enter acceleration amount: ");
                        int accelerationAmount = int.Parse(Console.ReadLine());
                        vehicle.Accelerate(accelerationAmount);
                        break;
                    case 4:
                        Console.WriteLine("Exiting the program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }

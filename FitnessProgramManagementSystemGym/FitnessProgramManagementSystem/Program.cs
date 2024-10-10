using FitnessProgramManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.ReadLine();

        }

        public static void Menu()
        {


            var admin = new FitnessProgramManager();

            while (true) {
                Console.WriteLine("FitnessProgram Management System:");

                Console.WriteLine("1. Add a FitnessProgram");

                Console.WriteLine("2. View All FitnessPrograms");

                Console.WriteLine("3. Update a FitnessProgram");


                Console.WriteLine("4. Delete a FitnessProgram");

                Console.WriteLine("5. Exit");
                Console.Write("Choose an option:");
                var MenuInput = Console.ReadLine();
                switch (MenuInput)
                {

                    case "1":
                        admin.CreateFitnessProgram();
                        break;
                    case "2":
                        admin.ReadFitnessPrograms();
                        break;
                    case "3":
                        admin.UpdateFitnessProgram();
                        break;
                    case "4":
                        admin.DeleteFitnessProgram();
                        break;
                    case "5":
                        Console.WriteLine("Thank you");
                        break;
                    default:
                        Console.Clear();
                        Menu();
                        break;


                }






            








            }














        }











    }
}

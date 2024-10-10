using FitnessProgramManagementSystem.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem.Entity
{
    internal class FitnessProgramManager
    {

     public List<FitnessProgram> FitnessProgramList=new List<FitnessProgram>();
    public FitnessProgramRepository fitnessProgramRepository = new FitnessProgramRepository();

        public void CreateFitnessProgram()
        {

            Console.WriteLine("Enter FitnessProgram Title:");
            var title=Console.ReadLine();
            
            Console.WriteLine("Enter FitnessProgram Duration:");
            var duration = Console.ReadLine();

            Console.WriteLine("Enter FitnessProgram price: ");
            var Rentalprice =Convert.ToInt16( Console.ReadLine());

            Console.WriteLine("FitnessProgram added successfully ");

            var program = new FitnessProgram((FitnessProgramList.Count + 1), title, duration, Rentalprice);

            fitnessProgramRepository.CreateFitnessProgram(program);
            //FitnessProgramList.Add(program);

        }


        public void ReadFitnessPrograms()
        {

            //if (FitnessProgramList.Count > 0)
            //{

            //    foreach (var programs in FitnessProgramList)
            //    {

            //        Console.WriteLine(programs.ToString());
            //    }


            //}
            //else
            //{
            //    Console.WriteLine("No fitnessprograms available");
            //}
            Console.WriteLine(fitnessProgramRepository.GetAll());

        }


        public void UpdateFitnessProgram()
        {
            Console.WriteLine("Enter Program Id");
            var id = Console.ReadLine();

            var program = FitnessProgramList.Find(p => p.FitnessProgramId == int.Parse(id));

            if (program != null)
            {

                Console.WriteLine("Enter the FitnessProgram ID to update:");
                var newid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter new Title:");
                var title = Console.ReadLine();
                Console.WriteLine("Enter new Duration: ");
                var duration = Console.ReadLine();
                Console.WriteLine("Enter new Price:");
                var price = Convert.ToInt16(Console.ReadLine());


                var NProgram = new FitnessProgram(){


                    Title = title,
                    Duration = duration,
                    Price = price

                };


                fitnessProgramRepository.UpdateProgram(NProgram);

            }
           

        }




        public void DeleteFitnessProgram()
        {
            Console.WriteLine("Enter Program Id");
            var id = Convert.ToInt32(Console.ReadLine());

            var program = FitnessProgramList.Find(p => p.FitnessProgramId == id);

            if (program != null)
            {

                //FitnessProgramList.Remove(program);

                fitnessProgramRepository.DeleteProgram(id);



            }


        }

        public decimal ValidateFitnessProgramPrice()
        {
            decimal price = 0;

            while (true)
            {

                Console.WriteLine("Enter FitnessProgram price:");
                var Rentelprice=decimal.Parse(Console.ReadLine());

                if (Rentelprice > 0)
                {

                    Rentelprice = price;



                }

                else
                {
                    Console.WriteLine("Your value is incorrect");
                }


            }






        }


        public string CapitalizeTitle(string title) {
        
        string firstletter=title.Substring(0,1);
            string remaing=title.Substring(1,title.Length-1);
            return $"{firstletter.ToUpper()}{remaing}";
        
        
        }






    }

}

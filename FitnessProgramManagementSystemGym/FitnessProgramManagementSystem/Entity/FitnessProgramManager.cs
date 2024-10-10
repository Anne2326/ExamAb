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


            FitnessProgramList.Add(program);

        }


        public void ReadFitnessPrograms()
        {

            Console.WriteLine("Enter Program Id");
            var id = Console.ReadLine();

            var program = FitnessProgramList.Find(p => p.FitnessProgramId == int.Parse(id));

            if (program == null)
            {

                foreach (var programs in FitnessProgramList)
                {

                    Console.WriteLine(programs);
                }


            }


        }


        public void UpdateFitnessProgram()
        {
            Console.WriteLine("Enter Program Id");
            var id = Console.ReadLine();

            var program = FitnessProgramList.Find(p => p.FitnessProgramId == int.Parse(id));

            if (program == null)
            {

                Console.WriteLine("Enter the FitnessProgram ID to update:");
                var newid=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter new Title:");
                var title = Console.ReadLine();
                Console.WriteLine("Enter new Duration: ");
                var duration = Console.ReadLine();
                Console.WriteLine("Enter new Price:");
                var price =Convert.ToInt16(Console.ReadLine());



                program.FitnessProgramId = newid;
                program.Title = title;
                program.Duration = duration;
                program.Price = price;






            }


            }




        public void DeleteFitnessProgram()
        {
            Console.WriteLine("Enter Program Id");
            var id = Console.ReadLine();

            var program = FitnessProgramList.Find(p => p.FitnessProgramId == int.Parse(id));

            if (program == null)
            {

                FitnessProgramList.Remove(program);




            }


        }

        //public decimal ValidateFitnessProgramPrice()
        //{
        //    decimal price = 0;

        //    while (true) {

        //        Console.WriteLine("Enter FitnessProgram price:");
            
            
            
        //    }






        //}









    }

}

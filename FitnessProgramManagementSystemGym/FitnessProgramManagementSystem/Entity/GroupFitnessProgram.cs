using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem.Entity
{
    internal class GroupFitnessProgram : FitnessProgram
    {

        public string Schedule { get; set; }
        public string GroupCapacity { get; set; }


        public GroupFitnessProgram() : base() { }


        public string DisplayGroupFitnessProgramInfo()
        {



            return $"ID: {FitnessProgramId}, Title: {Title}, Duration: {Duration}, Price: {Price},Schedule{Schedule},GroupCapacity{GroupCapacity}";




        }














    }
}

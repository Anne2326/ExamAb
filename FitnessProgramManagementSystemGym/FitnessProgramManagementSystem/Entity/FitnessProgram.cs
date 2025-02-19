﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem.Entity
{
    internal class FitnessProgram
    {
        public FitnessProgram(int v)
        {
        }

        public FitnessProgram(int fitnessProgramId, string title, string duration, decimal price)
        {
            FitnessProgramId = fitnessProgramId;
            Title = title;
            Duration = duration;
            Price = price;
        }
        public FitnessProgram() { }
        public int FitnessProgramId { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public decimal Price { get; set; }


        public override string ToString() {
            return $"ID: {FitnessProgramId}, Title: {Title}, Duration: {Duration}, Price: {Price}";
                
                }

        public virtual string DisplayFitnessProgramInfo()
        {
            return $"ID: {FitnessProgramId}, Title: {Title}, Duration: {Duration}, Price: {Price}";
        }




    }

}

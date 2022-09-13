using System;
using System.Collections.Generic;
using System.Text;

namespace TAL.Task.Domains.Models
{
    public class PremiumCalculatorModel
    {
        public string Name { get; set; }
        public int Age { get; set; }         
        
        public DateTime DateOfBirth { get; set; }
        public double SumInsured { get; set; }

        public OccupationModel Occupation { get; set; }
    }
}

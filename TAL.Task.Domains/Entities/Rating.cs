using System;
using System.Collections.Generic;
using System.Text;

namespace TAL.Task.Domains.Entities
{
    public class Rating
    {
        public int RatingId { get; set; }

        public string Name { get; set; }

        public double Factor { get; set; }
    }
}

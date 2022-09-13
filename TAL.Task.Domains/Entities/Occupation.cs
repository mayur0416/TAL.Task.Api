using System;
using System.Collections.Generic;
using System.Text;

namespace TAL.Task.Domains.Entities
{
    public class Occupation
    {
        public int OccupationId { get; set; }
        public string Name { get; set; }
        public int RatingId { get; set; }
        public virtual Rating Rating { get; }
    }
}

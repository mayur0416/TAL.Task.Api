using System.Collections.Generic;
using TAL.Task.Domains.Entities;

namespace TAL.Task.Repositories.Data
{
    public class SampleDbContext : ISampleDbContext
    {
        public List<Rating> GetRatingData()
        {
            List<Rating> ratings = new List<Rating>();

            ratings.Add(new Rating { RatingId = 1, Name = "Professional", Factor = 1.0 });
            ratings.Add(new Rating { RatingId = 2, Name = "White Collar", Factor = 1.25 });
            ratings.Add(new Rating { RatingId = 3, Name = "Light Manual", Factor = 1.50 });
            ratings.Add(new Rating { RatingId = 4, Name = "Heavy Manual", Factor = 1.75 });

            return ratings;
        }


        public List<Occupation> GetOccupationData()
        {
            List<Occupation> occupations = new List<Occupation>();


            occupations.Add(new Occupation { OccupationId = 1, Name = "Cleaner", RatingId = 3 });
            occupations.Add(new Occupation { OccupationId = 2, Name = "Doctor", RatingId = 1 });
            occupations.Add(new Occupation { OccupationId = 3, Name = "Author", RatingId = 2 });
            occupations.Add(new Occupation { OccupationId = 4, Name = "Farmer", RatingId = 4 });
            occupations.Add(new Occupation { OccupationId = 5, Name = "Mechanic", RatingId = 4 });
            occupations.Add(new Occupation { OccupationId = 6, Name = "Florist", RatingId = 3 });
            return occupations;
        }
    }
}

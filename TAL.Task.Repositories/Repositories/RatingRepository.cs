using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TAL.Task.Repositories.Data;

namespace TAL.Task.Repositories.Repositories
{
    public class RatingRepository : IRatingRepository
    {
        private readonly ISampleDbContext _sampleDbContext;

        public RatingRepository(ISampleDbContext sampleDbContext)
        {
            _sampleDbContext = sampleDbContext;
        }
        public double GetRatingFactor(int ratingId)
        {
            // here it will call dbcontext object and fetch data from DB
            // also this task will be async when data will fetch from DB so we can add async await
            return _sampleDbContext.GetRatingData().Where(x => x.RatingId == ratingId).Select(x => x.Factor).FirstOrDefault();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TAL.Task.Repositories.Repositories
{
    public interface IRatingRepository
    {
        public double GetRatingFactor(int ratingId);
    }
}

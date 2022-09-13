using System;
using System.Collections.Generic;
using System.Text;
using TAL.Task.Domains.Entities;

namespace TAL.Task.Repositories.Data
{
    public interface ISampleDbContext
    {
        List<Rating> GetRatingData();

        List<Occupation> GetOccupationData();
    }
}

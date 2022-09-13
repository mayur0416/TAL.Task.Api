using System.Collections.Generic;
using TAL.Task.Domains.Entities;

namespace TAL.Task.Repositories.Data
{
    public interface ISampleDbContext
    {
        List<Rating> GetRatingData();

        List<Occupation> GetOccupationData();
    }
}

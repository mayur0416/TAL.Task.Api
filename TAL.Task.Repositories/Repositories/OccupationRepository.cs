using System.Collections.Generic;
using TAL.Task.Domains.Entities;
using TAL.Task.Repositories.Data;

namespace TAL.Task.Repositories.Repositories
{
    public class OccupationRepository : IOccupationRepository
    {
        private readonly ISampleDbContext _sampleDbContext;

        public OccupationRepository(ISampleDbContext sampleDbContext)
        {
            _sampleDbContext = sampleDbContext;
        }

        public List<Occupation> GetOccupationsList()
        {
            // here it will call dbcontext object and fetch data from DB 
            // also this task will be async when data will fetch from DB so we can add async await
            return _sampleDbContext.GetOccupationData();
        }
    }
}

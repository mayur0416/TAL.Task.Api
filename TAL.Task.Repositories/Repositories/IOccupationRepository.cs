using System.Collections.Generic;
using TAL.Task.Domains.Entities;

namespace TAL.Task.Repositories.Repositories
{
    public interface IOccupationRepository
    {
        List<Occupation> GetOccupationsList();
    }
}

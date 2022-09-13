using System;
using System.Collections.Generic;
using System.Text;
using TAL.Task.Domains.Entities;

namespace TAL.Task.Repositories.Repositories
{
    public interface IOccupationRepository
    {
        List<Occupation> GetOccupationsList();
    }
}

using System.Collections.Generic;
using TAL.Task.Domains.Models;

namespace TAL.Task.Api.Services
{
    public interface IOccupationService
    {
        public List<OccupationModel> GetOccupationsList();
    }
}

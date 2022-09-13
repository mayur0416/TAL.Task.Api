using AutoMapper;
using System.Collections.Generic;
using TAL.Task.Domains.Models;
using TAL.Task.Repositories.Repositories;

namespace TAL.Task.Api.Services
{
    public class OccupationService : IOccupationService
    {
        private readonly IOccupationRepository _occupationRepository;
        private readonly IMapper _mapper;
        public OccupationService(IOccupationRepository occupationRepository, IMapper mapper)
        {
            _occupationRepository = occupationRepository;
            _mapper = mapper;
        }
        public List<OccupationModel> GetOccupationsList()
        {            
            var occupationData = _occupationRepository.GetOccupationsList();
            return _mapper.Map<List<OccupationModel>>(occupationData);            
        }
    }
}

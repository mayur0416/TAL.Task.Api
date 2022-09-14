using AutoMapper;
using Moq;
using System.Collections.Generic;
using TAL.Task.Api.Infrastructure.AutoMapper;
using TAL.Task.Api.Services;
using TAL.Task.Domains.Entities;
using TAL.Task.Repositories.Repositories;
using Xunit;

namespace TAL.Task.Test.Services
{
    public class OccupationServiceTest
    {
        private readonly OccupationService occupationService;
        private Mock<IOccupationRepository> occupationRepositoryMock;
        private IMapper mapper;

        public OccupationServiceTest()
        {
            var mockMapper = new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile()));
            mapper = mockMapper.CreateMapper();
            occupationRepositoryMock = new Mock<IOccupationRepository>();
            occupationService = new OccupationService(occupationRepositoryMock.Object, mapper);

        }

        [Fact]
        public void GetOccupationsList_Shouldreturn_Occupations()
        {
            // Arrange
             
            List<Occupation> occupations = TAL.Task.Test.MockData.MockData.GetMockOccupations();             
            occupationRepositoryMock.Setup(x => x.GetOccupationsList()).Returns(occupations);

            // Act
            var occupationsList = occupationService.GetOccupationsList();

            // Assert,
            Assert.NotNull(occupationsList);
        }
    }
}

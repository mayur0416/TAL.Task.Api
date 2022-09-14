using Bogus;
using System;
using System.Collections.Generic;
using System.Text;
using TAL.Task.Domains.Entities;

namespace TAL.Task.Test.MockData
{
    public static class MockData
    {
        public static List<Occupation> GetMockOccupations()
        {
            int occupationId = 1;
            string occupationName = "mockOccupation" + occupationId;
            int ratingId = 1;
            var faker = new Faker<Occupation>()
                .RuleFor(c => c.OccupationId, occupationId++)
                .RuleFor(c => c.Name, occupationName)
                .RuleFor(c => c.RatingId, ratingId);
            return faker.Generate(5);
        }
    }
}

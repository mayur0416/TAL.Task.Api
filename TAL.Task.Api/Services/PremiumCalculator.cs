using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TAL.Task.Domains.Models;
using TAL.Task.Repositories.Repositories;

namespace TAL.Task.Api.Services
{
    public class PremiumCalculator : IPremiumCalculatorService
    {
        private readonly IRatingRepository _ratingRepository;

        public PremiumCalculator(IRatingRepository ratingRepository)
        {
            _ratingRepository = ratingRepository;

        }
        public double CalulatePremium(PremiumCalculatorModel premiumCalculatorModel)
        {
            var ratingFactor = _ratingRepository.GetRatingFactor(premiumCalculatorModel.Occupation.RatingId);
            return ((premiumCalculatorModel.SumInsured * ratingFactor * premiumCalculatorModel.Age) / (1000 * 12));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TAL.Task.Domains.Models;

namespace TAL.Task.Api.Services
{
    public interface IPremiumCalculatorService
    {
        double CalulatePremium(PremiumCalculatorModel premiumCalculatorModel);
    }
}

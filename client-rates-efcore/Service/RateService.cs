using client_rates_efcore.Model;
using client_rates_efcore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace client_rates_efcore.Service
{
    public class RateService : IRateService
    {
        public IRatesRepository _ratesRepository;

        public RateService(IRatesRepository ratesRepository)
        {
            _ratesRepository = ratesRepository;
        }

        public async Task<Rate> ListAsync()
        {
            return await _ratesRepository.GetAsync();
        }
    }
}

using client_rates_efcore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace client_rates_efcore.Repository
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAsync();
    }
}

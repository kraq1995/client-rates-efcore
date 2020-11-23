using client_rates_efcore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace client_rates_efcore.Service
{
    public interface IClientService
    {
        Task<Client> GetAsync();
    }
}

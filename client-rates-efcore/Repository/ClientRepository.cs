using client_rates_efcore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace client_rates_efcore.Repository
{
    public class ClientRepository : BaseRepository, IClientRepository
    {
        public ClientRepository(AppDbContext context) : base(context)
        {
        }

        public Task<IEnumerable<Client>> GetAsync()
        {
            throw new NotImplementedException();
        }
    }
}

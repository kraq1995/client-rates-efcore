using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace client_rates_efcore.Model
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? PeselNr { get; set; }
        public string? IdDocNumber { get; set; }
        public IList<Rate> Rates { get; set; } = new List<Rate>();
    }
}

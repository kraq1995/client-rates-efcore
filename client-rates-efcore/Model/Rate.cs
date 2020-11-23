using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace client_rates_efcore.Model
{
    public class Rate
    {
        public Guid Id { get; set; }
        public int Stars { get; set; }
        public string Opinion { get; set; }

        public Guid ClientId { get; set; }
        public Client Client { get; set; }
    }
}

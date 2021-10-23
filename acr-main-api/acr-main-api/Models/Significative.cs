using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acr_main_api.Models
{
    public class Significative
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int DomainId { get; set; }
        public Domain Domain { get; set; }

        public List<Percentage> Percentages { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acr_main_api.Models
{
    public class Percentage
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public DateTime Date { get; set; }

        public int SignificativeId { get; set; }
        public Significative Significative { get; set; }
    }
}

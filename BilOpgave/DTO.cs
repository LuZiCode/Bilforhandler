using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilOpgave
{
    internal abstract class DTO
    {
        public string? name { get; set; }
        public decimal? price { get; set; }
        public DateTime age { get; set; } = DateTime.Today;
        public string? type { get; set; }
        public DateTime from0to100 { get; set; }

        public string GetCarAge()
        {
            return age.ToString("dd-mm-yyyy");
        }

    }
}

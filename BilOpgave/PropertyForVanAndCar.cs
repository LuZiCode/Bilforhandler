using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilOpgave
{
    internal class Van : DTO
    {
        public List<VanAccessories> vanAccessories { get; set; } = new();
        public string GetSpeed()
        {
            return from0to100.ToString("mm:ss");
        }
    }
    internal class VanAccessories : DTO
    {
        public string? AccessorieName { get; set; }
        public int? AccessorieCount { get; set; }
        public decimal? AccessoriePrice { get; set; }
        public string? AccessorieType { get; set; }
        public DateTime? AccessorieAge { get; set; } = DateTime.Today;
    }
    internal class Car : DTO
    {
        public List<CarAccessories> carAccessories { get; set; } = new();
        public string GetSpeed()
        {
            return from0to100.ToString("ss");
        }
    }
    internal class CarAccessories : DTO
    {
        public string? AccessorieName { get; set; }
        public int? AccessorieCount { get; set; }
        public decimal? AccessoriePrice { get; set; }
        public string? AccessorieType { get; set; }

    }

}

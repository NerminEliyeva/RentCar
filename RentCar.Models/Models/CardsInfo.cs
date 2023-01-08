using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models.Models
{
    public class CardsInfo
    {
        public int CarId { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }
        public string Category { get; set; }
        public string EngineType { get; set; }
        public double Volume { get; set; }
        public string ImageBase64 { get; set; }

    }
}

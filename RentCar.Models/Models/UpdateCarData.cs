using Microsoft.AspNetCore.Http;
using RentCar.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models.Models
{
    public class UpdateCarData
    {
        public int CarId { get; set; }
        public string MainImage { get; set; }
        public List<string> Images { get; set; }
        public double Volume { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public List<Marks> Marks { get; set; }
        public List<Categories> Categories { get; set; }
        public List<EngineTypes> EngineTypes { get; set; }
    }
}

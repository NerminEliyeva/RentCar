using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models.Models
{
    public class SaveNewCarModel
    {
        public int MarkId { get; set; }
        public int ModelId { get; set; }
        public int CaregoryId { get; set; }
        public int EngineTypeId { get; set; }
        public IFormFile MainImage { get; set; }
        public IFormFile[] Images { get; set; }
        public double Volume { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
    }
}

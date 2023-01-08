using RentCar.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models.Models
{
    public class NewCarData
    {
        public List<Marks> Marks { get; set; }
        public List<Categories> Categories { get; set; }
        public List<EngineTypes> EngineTypes { get; set; }
    }
}

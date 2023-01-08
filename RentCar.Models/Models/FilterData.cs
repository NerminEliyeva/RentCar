using RentCar.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models.Models
{
    public class FilterData
    {
        public List<Marks> FilterMarks { get; set; }
        public List<Entities.Models> FilterModels { get; set; }
        public List<int> FilterYears { get; set; }
        public List<Categories> FilterCategories { get; set; }
    }
}

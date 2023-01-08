using RentCar.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models.ViewModels
{
    public class CarsViewModel
    {
        public List<CardsInfo> CardsInfo { get; set; }
        public FilterData FilterData { get; set; }
    }
}

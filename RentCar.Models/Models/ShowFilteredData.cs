using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models.Models
{
    public class ShowFilteredData
    {
        public int FilterMarkaId { get; set; }
        public int FilterModelId { get; set; }
        public int FilterYear { get; set; }
        public int FilterCategoryId { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }

    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace RentCar.Models.Entities
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CategoryName { get; set; }
    }
}

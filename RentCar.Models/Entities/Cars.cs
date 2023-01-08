using System;
using System.ComponentModel.DataAnnotations;

namespace RentCar.Models.Entities
{
    public class Cars
    {
        [Key]
        public int CarId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public int MarkId { get; set; }
        public int ModelId { get; set; }
        public int Year { get; set; }
        public int EngineTypeId { get; set; }
        public double EngineVolume { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int Status { get; set; }
    }
}

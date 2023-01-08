using System;
using System.ComponentModel.DataAnnotations;

namespace RentCar.Models.Entities
{
    public class Models
    {
        [Key]
        public int ModelId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModelMarkId { get; set; }
        public string ModelName { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace RentCar.Models.Entities
{
    public class Marks
    {
        [Key]
        public int MarkId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string MarkName { get; set; }
    }
}

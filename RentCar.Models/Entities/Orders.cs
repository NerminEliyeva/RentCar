using System;
using System.ComponentModel.DataAnnotations;

namespace RentCar.Models.Entities
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedUserId { get; set; }
        public int OrderCarId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}

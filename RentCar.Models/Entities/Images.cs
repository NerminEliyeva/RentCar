using System;
using System.ComponentModel.DataAnnotations;

namespace RentCar.Models.Entities
{
    public class Images
    {
        [Key]
        public int ImageId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public int ImageCarId { get; set; }
        public string FullPath { get; set; }
        public int MainImage { get; set; }


    }
}

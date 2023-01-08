using System.ComponentModel.DataAnnotations;

namespace RentCar.Models.Entities
{
    public class EngineTypes
    {
        [Key]
        public int EngineTypeId { get; set; }
        public string EngineTypeName { get; set; }
    }
}

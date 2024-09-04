using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models
{
    public class VillaDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Details { get; set; }
        [Required]
        public double Rate { get; set; }
        public int Sqft { get; set; }
        public int Occupancy { get; set; }
        public string ImageURL { get; set; }
        public string Amenity { get; set; }
    }
}

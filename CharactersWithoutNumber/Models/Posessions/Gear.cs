using System.ComponentModel.DataAnnotations;

namespace CharactersWithoutNumber.Models
{
    public class Gear
    {
        [Key]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public int Encumbrance { get; set; }
        public bool CanStack { get; set; }
        public string TechLevel { get; set; }
    }
}
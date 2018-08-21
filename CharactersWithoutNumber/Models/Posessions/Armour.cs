using System.ComponentModel.DataAnnotations;

namespace CharactersWithoutNumber.Models
{
    public class Armour
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Encumbrance { get; set; } //what about Storm Armour - increases Strength by 4 times but only for encumbrance.. likely just need an if statement
        public string Readied { get; set; }
        public string TechLevel { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace CharactersWithoutNumber.Models
{
    public class ClassFoci
    {
        [Key]
        public string Name { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
    }
}
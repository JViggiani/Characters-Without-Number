using System.ComponentModel.DataAnnotations;

namespace CharactersWithoutNumber.Models
{
    public class ClassFoci
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
    }
}
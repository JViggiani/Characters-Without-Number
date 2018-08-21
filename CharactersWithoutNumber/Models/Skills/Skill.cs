using System.ComponentModel.DataAnnotations;
namespace CharactersWithoutNumber.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
    }
}
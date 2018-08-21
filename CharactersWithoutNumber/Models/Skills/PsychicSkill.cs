using System.ComponentModel.DataAnnotations;

namespace CharactersWithoutNumber.Models
{
    public class PsychicSkill
    {
        [Key]
        public string Name { get; set; }
        public int Level { get; set; }
    }
}
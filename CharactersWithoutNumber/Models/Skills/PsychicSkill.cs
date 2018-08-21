using System.ComponentModel.DataAnnotations;

namespace CharactersWithoutNumber.Models
{
    public class PsychicSkill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
    }
}
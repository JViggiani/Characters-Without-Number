using System.ComponentModel.DataAnnotations;
namespace CharactersWithoutNumber.Models
{
    public class Skill
    {
        [Key]
        public string Name { get; set; }
        public int Level { get; set; }
        //public string RollType { get; set; } should this be here? Each character could have a foci which affects the roll type on a skill. So should this be under character, foci, or skill?
    }
}
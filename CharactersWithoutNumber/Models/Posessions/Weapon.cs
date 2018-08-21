using System.ComponentModel.DataAnnotations;
namespace CharactersWithoutNumber.Models
{
    public class Weapon
    {
        [Key]
        public string Name { get; set; }
        public int AttackBonus { get; set; }
        public string Skill { get; set; } // how to associate and verify with an existing skill? would be a dropdown in practice
        public string Attribute { get; set; }
        public bool Burst { get; set; }
        public string Damage { get; set; } //how to ensure format? Format should be xdy - eg 2d6 where x is the number of dice and y is the type of dice (a "y sided" die)
        public bool AddSkillToDamage { get; set; }
        public bool Shock { get; set; }
        public int ShockDamage { get; set; }
        public int ShockAC { get; set; }
        public int LowerRangeBand { get; set; }
        public int UpperRangeBand { get; set; }
        public bool Ammo { get; set; }
        public int AmmoCapacity { get; set; }
        public string TechLevel { get; set; }
        public bool CanSuppress { get; set; }
    }
}
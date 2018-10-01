using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharactersWithoutNumber.Models
{
    public class Character
    {

        /* 
        Remember -
            A character has one strength but could have multiple weapons. So the Weapons property should be a list - it is also a navigation property which points to a Weapon model Entity
            A character doesn't have to have a partial class. So this should be an enum of form: public PartialClass? PartialClass {get; set;}
            EF interprets a property as a foreign key if it follows the name format <Model><ID>
                Eg StudentID

            https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/adding-a-new-field
        */

        public int ID { get; set; }

        public string Name { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public string Faction { get; set; }
        public string Homeworld { get; set; }

        public string Background { get; set; } //should this be a list? A character chooses ONE background out of MANY potential backgrounds

        public string Class { get; set; }
        public string PartialClasses { get; set; }

        public int Strength { get; set; }
        public int StrengthModifierBonus { get; set; }
            private int _strengthModifier = 0;  //find a way to make this null initially
        public int StrengthModifier //https://stackoverflow.com/questions/7390902/requiredif-conditional-validation-attribute
        {
            get
            {
                return _strengthModifier;
            }
            set
            {
                if (Strength <= 3)
                {
                    _strengthModifier = -2 + StrengthModifierBonus;
                }
                else if (Strength >= 4 && Strength <= 7)
                {
                    _strengthModifier = -1 + StrengthModifierBonus;
                }
                else if (Strength >= 8 && Strength <= 13)
                {
                    _strengthModifier = 0 + StrengthModifierBonus;
                }
                else if (Strength >= 14 && Strength <= 17)
                {
                    _strengthModifier = 1 + StrengthModifierBonus;
                }
                else if (Strength >= 18)
                {
                    _strengthModifier = 2 + StrengthModifierBonus;
                }
                else
                {
                    _strengthModifier = 0;  //TODO: get it to try to put null in maybe?
                }
            }
        }

        public int Dexterity { get; set; }

        public int Constitution { get; set; }

        public int Intelligence { get; set; }

        public int Wisdom { get; set; }

        public int Charisma { get; set; }


        //lookup problem - cqrs

        //public int ExperiencePoints { get; set; }

        //public Character()
        //{
        //    Class = new List<Class>();
        //}

        //public IList<Class> Class { get; /*set;*/ } //same as Background
        //public ICollection<PartialClass> PartialClasses { get; set; } //dependant on Class = Adventurer

        //public ICollection<Skill> Skills { get; set; } //a character has every skill at -1 but can upgrade them to 0, then 1 etc 
        //public ICollection<PsychicSkill> PsychicSkills { get; set; }

        //public int HitPoints { get; set; }

        //public ICollection<Foci> Foci { get; set; } // a character has at least one foci 
        //public ICollection<PsychicTechnique> PsychicTechniques { get; set; } //a character has techniques which are sort of like foci. They require being at least level 0 in some Psychic Skills 

        //public ICollection<Weapon> Weapons { get; set; } // a character has many weapons
        //public ICollection<Armour> Armour { get; set; } // one set of armour
        //public ICollection<Gear> Gear { get; set; } // many items, option to add many custom entries required

    }
}

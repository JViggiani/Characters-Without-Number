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
        */

        public int ID { get; set; }

        public string Name { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public string Faction { get; set; }
        public string Homeworld { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        //public Background Background { get; set; } //should this be a list? A character chooses ONE background out of MANY potential backgrounds

        ////lookup problem - cqrs

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

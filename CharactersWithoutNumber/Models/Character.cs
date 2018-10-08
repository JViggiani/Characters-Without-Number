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

        //public Attribute Strength { get; set; }

        public int Strength { get; set; }   //domain driven design - logic handled on the controller https://www.thereformedprogrammer.net/creating-domain-driven-design-entity-classes-with-entity-framework-core/
        public int StrengthModifierBonus { get; set; }
        public int StrengthModifier 
        {
            get 
            {
                return (new AttributeBonus(Strength, StrengthModifierBonus)).Modifier;
            }
        }

        public int Dexterity { get; set; }
        public int DexterityModifierBonus { get; set; }
        public int DexterityModifier
        {
            get
            {
                return (new AttributeBonus(Dexterity, DexterityModifierBonus)).Modifier;
            }
        }

        public int Constitution { get; set; }
        public int ConstitutionModifierBonus { get; set; }
        public int ConstitutionModifier
        {
            get
            {
                return (new AttributeBonus(Constitution, ConstitutionModifierBonus)).Modifier;
            }
        }

        public int Intelligence { get; set; }
        public int IntelligenceModifierBonus { get; set; }
        public int IntelligenceModifier
        {
            get
            {
                return (new AttributeBonus(Intelligence, IntelligenceModifierBonus)).Modifier;
            }
        }

        public int Wisdom { get; set; }
        public int WisdomModifierBonus { get; set; }
        public int WisdomModifier
        {
            get
            {
                return (new AttributeBonus(Wisdom, WisdomModifierBonus)).Modifier;
            }
        }

        public int Charisma { get; set; }
        public int CharismaModifierBonus { get; set; }
        public int CharismaModifier
        {
            get
            {
                return (new AttributeBonus(Charisma, CharismaModifierBonus)).Modifier;
            }
        }


        //lookup problem - cqrs

        //public int ExperiencePoints { get; set; }

        //public Character()
        //{
        //    Class = new List<Class>();
        //}

        //public IEnumerable<Review> Reviews => _reviews?.ToList(); ==> one-to-many.. IEnumerable means can't add or remove items, instead use access methods in Review class

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

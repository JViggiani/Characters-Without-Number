using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
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
        public string Background { get; set; } //should this be a list? A character chooses ONE background out of MANY potential backgrounds
        public string Class { get; set; }
        public string PartialClasses { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public string Faction { get; set; }
        public string Homeworld { get; set; }

        public int ExperiencePoints { get; set; }
        public int Level
        {
            get
            {
                return (new Level(ExperiencePoints)).level;
            }
        }

        public int Hitpoints { get; set; }
        public int CurrentHitpoints { get; set; }

        public int MaximumSystemStrain { get; set; }
        public int PermanentStrain { get; set; }    //Consider the relationship between SS and CSS and PSS. On the form, on CSS, you shouldnt be able to go any lower than your PSS.
        public int CurrentSystemStrain { get; set; }

        public int ArmourClass { get; set; }
        public int AttackBonus { get; set; }
        public int Encumbrance { get; set; }

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

    internal class Level
    {
        private int experiencePoints;

        public Level(int experiencePoints)
        {
            this.experiencePoints = experiencePoints;
        }

        private readonly List<int> xpRelationship = new List<int> { 0,3,3,6,6,9,12,15,18,21,24 };

        public int level
        {
            /**
             * The relationship between character level and XP in the base game is as follows:
             * 
             * Level    XP Required
             * 1        0
             * 2        3
             * 3        6
             * 4        12
             * 5        18
             * 6        27
             * 7        39
             * 8        54
             * 9        72
             * 10       93
             * 11+      +24 points per level
             * 
             * The xpRelationship readonly list defines the XP difference between each level. 
             * For instance, at the jump between 1st and 2nd level, the xp difference is 3. Between 2nd and 3rd is also 3, between 3rd and 4th is 6. Between 5th and 6th is 9.
             * 
             * Since the level of a character can theoretically be any finite positive integer, the below getter uses the XP difference to calculate the level of a character given their XP level on an ad-hoc basis.
             */
            get
            {
                int cumulativeStep = 0;
                int count = 0;
                int countBeyondArray = 0;

                while (true)
                {
                    cumulativeStep += xpRelationship[count];
                    if (cumulativeStep >= experiencePoints)
                    {
                        return count + countBeyondArray;
                    }

                    if (count != xpRelationship.Count - 1)
                    {
                        count++;
                    }
                    else { countBeyondArray++; }
                }
            }
        }

        public int nextLevelExperience
        {
            get
            {
                int cumulativeStep = 0;
                int count = 0;

                while (true)
                {
                    cumulativeStep += xpRelationship[count];
                    if (cumulativeStep >= experiencePoints)
                    {
                        if (count != xpRelationship.Count - 1)
                        {
                            return cumulativeStep;
                        }
                    }

                    if (count != xpRelationship.Count - 1)
                    {
                        count++;
                    }
                }
            }
        }
    }

    internal class AttributeBonus
    {
        private int Attribute;
        private int AttributeModifierBonus;

        public AttributeBonus(int Attribute, int AttributeModifierBonus)
        {
            this.Attribute = Attribute;
            this.AttributeModifierBonus = AttributeModifierBonus;
        }

        public int Modifier
        {
            get //TODO: put this logic in a different class - give it the character and return the modifier
            {
                if (Attribute <= 3)
                {
                    return -2 + AttributeModifierBonus;
                }
                else if (Attribute >= 4 && Attribute <= 7)
                {
                    return -1 + AttributeModifierBonus;
                }
                else if (Attribute >= 8 && Attribute <= 13)
                {
                    return 0 + AttributeModifierBonus;
                }
                else if (Attribute >= 14 && Attribute <= 17)
                {
                    return 1 + AttributeModifierBonus;
                }
                else if (Attribute >= 18)
                {
                    return 2 + AttributeModifierBonus;
                }
                else
                {
                    return 0;  //TODO: get it to try to put null in maybe?
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharactersWithoutNumber.Models
{
    public class AttributeBonus
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

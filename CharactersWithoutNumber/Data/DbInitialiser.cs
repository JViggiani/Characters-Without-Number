using CharactersWithoutNumber.Models;
using System;
using System.Linq;

namespace CharactersWithoutNumber.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CharacterContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Characters.Any())
            {
                return;   // DB has been seeded
            }

            var characters = new Character[]
            {
            new Character{Name="Josh Viggiani",Species="Human",Gender="Male",Faction="None",Homeworld="Earth",Strength=11,Dexterity=10,Constitution=10,Intelligence=14,Wisdom=12,Charisma=11},
            new Character{Name="Elijah Holt",Species="Human",Gender="Male",Faction="House Holt",Homeworld="Izanami",Strength=9,Dexterity=14,Constitution=15,Intelligence=14,Wisdom=14,Charisma=12},
            new Character{Name="Frederick Danton",Species="Human",Gender="Male",Faction="House Holt",Homeworld="Genesis",Strength=14,Dexterity=9,Constitution=14,Intelligence=11,Wisdom=8,Charisma=18},
            new Character{Name="Yokai",Species="Human-Synth",Gender="Male",Faction="The Remnancy",Homeworld="Amaterasu",Strength=14,Dexterity=14,Constitution=14,Intelligence=11,Wisdom=12,Charisma=12},
            };
            foreach (Character c in characters)
            {
                context.Characters.Add(c);
            }
            context.SaveChanges();

        }
    }
}
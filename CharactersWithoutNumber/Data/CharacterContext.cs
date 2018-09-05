using CharactersWithoutNumber.Models;
using Microsoft.EntityFrameworkCore;

namespace CharactersWithoutNumber.Data
{
    public class CharacterContext : DbContext
    {
        public CharacterContext(DbContextOptions<CharacterContext> options) : base(options)
        {
        }

        // Further database initialisations are irrelevent because the Character class references all other classes. It will create other DBs implicitly

        public DbSet<Character> Characters { get; set; }

        //Override default behaviour by specifying singular (as opposed to plural) table names in the DbContext - purely a disagreement between devs. Should table be called Character or Characters? 
        // Here we specify "Character"

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().ToTable("Character");
        }
    }
}
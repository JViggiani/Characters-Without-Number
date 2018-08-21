using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharactersWithoutNumber.Models
{
    public class Class
    {
        [Key]
        public string Name { get; set; }
        public ICollection<ClassFoci> ClassFoci { get; set; }
    }
}
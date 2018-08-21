using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharactersWithoutNumber.Models
{
    public class PartialClass
    {
        [Key]
        public string Name { get; set; }
        public ICollection<PartialClassFoci> PartialClassFoci { get; set; }
    }
}
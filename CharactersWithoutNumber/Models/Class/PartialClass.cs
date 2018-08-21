using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharactersWithoutNumber.Models
{
    public class PartialClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PartialClassFoci> PartialClassFoci { get; set; }
    }
}
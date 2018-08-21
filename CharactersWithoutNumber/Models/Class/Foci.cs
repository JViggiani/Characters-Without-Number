using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CharactersWithoutNumber.Models
{
    public class Foci
    {
        [Key]
        public string Name { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
    }
}

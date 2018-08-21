using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharactersWithoutNumber.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; } //surrogate key
        public ClassFoci ClassFoci { get; set; } //lookup record
    }
}
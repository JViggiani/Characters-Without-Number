using System.Collections.Generic;

namespace CharactersWithoutNumber.Models
{
    public class Background
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<GrowthTable> GrowthTable { get; set; }
        public ICollection<LearningTable> LearningTable { get; set; }
        //public string[] QuickSkills { get; set; } 
        public ICollection<Skill> Skills { get; set; } //is this right?? Needs to reference existing skills in a table somewhere.. Each background has three associated skills 
    }
}
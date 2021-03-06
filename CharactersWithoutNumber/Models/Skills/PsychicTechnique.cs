﻿using System.ComponentModel.DataAnnotations;
namespace CharactersWithoutNumber.Models
{
    public class PsychicTechnique
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Discipline { get; set; } // how to link with a psychic skill?
        public int Level { get; set; }
    }
}
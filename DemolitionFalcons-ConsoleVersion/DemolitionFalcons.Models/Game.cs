﻿namespace DemolitionFalcons.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Game
    {
        public Game()
        {
            this.Characters = new List<GameCharacter>();
        }

        public int Id { get; set; }

        [MinLength(4)]
        public string Name { get; set; }

        public int? WinnerId { get; set; }
        //public Player Winner { get; set; }

        public int Xp { get; set; }

        public decimal Money { get; set; }

        public TimeSpan? Time { get; set; }

        //public int MapId { get; set; }
        //public Map Map { get; set; }

        public ICollection<GameCharacter> Characters { get; set; }
    }
}

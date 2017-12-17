﻿namespace DemolitionFalcons.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Character
    {
        public Character()
        {
            this.Games = new List<GameCharacter>();
        }

        public int Id { get; set; }

        [MinLength(3)]
        public string Name { get; set; }

        public int Hp { get; set; }

        public int Armour { get; set; }

        public int? PlayerId { get; set; }
        public Player Player { get; set; }

        public int? GameId { get; set; }
        public Game Game { get; set; }

        //matrix coordinates/current position
        public int X { get; set; }
        public int Y { get; set; }

        public ICollection<GameCharacter> Games { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Bingo.Domain.Models
{
    public class Player
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Board Board { get; set; }
    }
}

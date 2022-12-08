using System;

namespace Bingo.Domain.Models
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Board Board { get; set; }
    }
}

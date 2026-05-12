using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Backend.Models
{
    internal class GeneratorState
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public double StoredAmount { get; set; } = 0;
        public DateTime LastCollected { get; set; }
    }
}

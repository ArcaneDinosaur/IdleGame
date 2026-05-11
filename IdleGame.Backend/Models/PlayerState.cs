using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Backend.Models
{
    internal class PlayerState
    {
        public List<ResourceState> Resources { get; set; } = new List<ResourceState>();
        public List<GeneratorState> Generators { get; set; } = new List<GeneratorState>();
        public ArcaneDustGeneratorState? ArcaneDustGenerator { get; set; } = new ArcaneDustGeneratorState();
        public List<Unlocks> Unlocks { get; set; } = new List<Unlocks>();
        public List<Crafts> Crafts { get; set; } = new List<Crafts>();
    }
}

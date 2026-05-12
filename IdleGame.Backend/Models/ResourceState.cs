using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Backend.Models
{
    internal class ResourceState
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int TotalEarned { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}

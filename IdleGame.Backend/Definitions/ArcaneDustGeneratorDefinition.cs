using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Backend.Definitions
{
    internal class ArcaneDustGeneratorDefinition
    {
        public int BasePassiveRate { get; init; }
        public int PassiveRatePerLevel { get; init; }
        public int BaseTapAmount { get; init; }
        public int TapAmountPerLevel { get; init; }
        public int BaseUpgradeCost { get; init; }
        public double UpgradeCostMultiplier { get; init; }
    }
}

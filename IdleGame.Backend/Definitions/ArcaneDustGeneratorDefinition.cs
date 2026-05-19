namespace IdleGame.Backend.Definitions
{
    public class ArcaneDustGeneratorDefinition
    {
        public int BasePassiveRate { get; init; }
        public int PassiveRatePerLevel { get; init; }
        public int BaseTapAmount { get; init; }
        public int TapAmountPerLevel { get; init; }
        public int BaseUpgradeCost { get; init; }
        public double UpgradeCostMultiplier { get; init; }
    }
}

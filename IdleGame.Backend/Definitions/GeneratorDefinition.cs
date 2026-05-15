namespace IdleGame.Backend.Definitions
{
    internal class GeneratorDefinition
    {
        public string Id { get; init; }

        public double BaseAmountPerCycle { get; init; }

        public double AmountPerLevel { get; init; } = 0;

        public int BaseUpgradeCost { get; init; }

        public double UpgradeCostMultiplier { get; init; } = 1.12;

        public string Description { get; init; }

        public double ProductionIntervalSeconds { get; init; }

        public double ProductionMultiplier { get; init; } = 1.10;

        public double MaxStorageAmount { get; init; }

        public double StoragePerLevel { get; init; } = 0;

        public double StorageMultiplier { get; init; } = 1.08;

        public Guid ProducesResourceId { get; init; }

        public UnlockConditionDefinition UnlockCondition { get; init; }
    }
}

namespace IdleGame.Backend.Definitions
{
    public class GeneratorDefinition
    {
        public required string Id { get; init; }
        public double BaseAmountPerCycle { get; init; }
        public double AmountPerLevel { get; init; }
        public int BaseUpgradeCost { get; init; }
        public double UpgradeCostMultiplier { get; init; }
        public string? Description { get; init; }
        public double ProductionIntervalSeconds { get; init; }
        public double ProductionMultiplier { get; init; }
        public double MaxStorageAmount { get; init; }
        public double StoragePerLevel { get; init; }
        public double StorageMultiplier { get; init; }
        public Guid ProducesResourceId { get; init; }
        //public UnlockConditionDefinition UnlockCondition { get; init; }
    }
}

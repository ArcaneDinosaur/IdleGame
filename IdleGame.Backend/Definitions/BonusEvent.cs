namespace IdleGame.Backend.Definitions
{
    public class BonusEvent
    {
        public Guid Id { get; }
        public required string Type { get; set; }
        public double ChancePercent { get; set; }
        public int DurationSeconds { get; set; }
        public Dictionary<string, object> BonusData { get; set; } = new Dictionary<string, object>();
    }
}
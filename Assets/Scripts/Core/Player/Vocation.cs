namespace Core.Player
{
	public class Vocation {
		public string Name { get; set; }
		public string Description { get; set; }
		public float HealthGrowth { get; set; }
		public float ManaGrowth { get; set; }
		public float CapGrowth { get; set; }
		public float MagicLevelGrowth { get; set; }
		public float OneHandedGrowth { get; set; }
		public float TwoHandedGrowth { get; set; } //1.1, 0
		public float AxeFightingGrowth { get; set; } //0.9
		public float SwordFightingGrowth { get; set; }
		public float ClubFightingGrowth { get; set; }
		public float DistanceFightingGrowth { get; set; }
		public float FistFightingGrowth { get; set; }
		public float ShieldingGrowth { get; set; }
		public float FishingGrowth { get; set; }
		public float FarmLevelGrowth { get; set; }
		public float CraftLevelGrowth { get; set; }
	}
}



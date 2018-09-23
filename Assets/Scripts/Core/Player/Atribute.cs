using System;

namespace Core.Player
{
    public enum AtributeType
    {
        Health = 1,
        Mana = 2,
        Stamina = 3,
        Speed = 4,
        Capacity = 5,
        Hunger = 6,	
        MagicLevel = 7,	
        OneHanded = 8,	
        TwoHanded = 9,	
        AxeFighting = 10,	
        SwordFighting = 11,	
        ClubFighting = 12,	
        DistanceFighting = 13,	
        FistFighting = 14,	
        Shielding = 15,	
        Fishing = 16,	
        FarmLevel = 17,	
        CraftLevel = 18,
        Duration = 19,
        Charges = 20,
        Armor = 21,
        Defense = 22,
        BlockChance = 23,
        PhysicalDamage = 24,
        PhysicalResistance = 25,
        CriticalChance = 26,
        CriticalMultiplier = 27,
        FireDamage = 28,        
        FireResistance = 29,
        IceDamage = 30,
        IceResistance = 31,
        EarthDamage = 32,
        EarthResistance = 33,
        HolyDamage = 34,
        HolyResistance = 35,
        DeathDamage = 36,
        DeathResistance = 37,
        MagicDamage = 38,
        MagicResistance = 39,
        EnergyDamage = 40,
        EnergyResistance = 41
    }
    
    public class Atribute
    {
        public AtributeType AtributeType { get; set; }
        public Flag IsNegative { get; set; }
        public Flag IsPercent { get; set; }
        public string Description { get; set; }
        public float Value { get; set; }
    }
}
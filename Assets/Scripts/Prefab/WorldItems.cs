using Boo.Lang;
using Core.Player;


namespace Prefab
{
    public static class WorldItems
    {
        public static List<Item> Rings = new List<Item>()
        {
            new Item()
            {
                Id = 10001,
                Name = "Speed Ring",
                Description = "This ring raise your speed.",
                IsRing = new Flag() {Value = true},
                Atributes = new System.Collections.Generic.List<Atribute>()
                
                {
                    new Atribute()
                    {
                        Value = 100,
                        AtributeType = AtributeType.Speed,
                        Description = "speed",
                        IsNegative = new Flag() {Value = false}
                    }
                }


            }
        };
    }
}
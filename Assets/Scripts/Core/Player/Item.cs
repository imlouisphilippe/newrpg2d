using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Player
{
	public class Item {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Flag IsStackable { get; set; }
		public Flag IsInventory { get; set; }
		public Flag IsConsumable { get; set; }
		public Flag IsCurrency { get; set; }
		public Flag IsAmmunition { get; set; }
		public Flag IsDragable { get; set; }
		public Flag IsWeapon { get; set; }
		public Flag IsChestplate { get; set; }
		public Flag IsLeg { get; set; }
		public Flag IsBoot { get; set; }
		public Flag IsHelmet { get; set; }
		public Flag IsShield { get; set; }
		public Flag IsRing { get; set; }
		public Flag IsNecklace { get; set; }
		public List<Slot> Inventory { get; set; }
		public List<Item> Stack { get; set; }
		public int Count { get { return Stack.Count(); } }
		public List<Atribute> Atributes { get; set; }
	}
}



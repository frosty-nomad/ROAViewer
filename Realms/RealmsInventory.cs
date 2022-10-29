using System.Collections.Generic;

namespace Realms
{
    public class RealmsInventory
    {
        public const int OffsetInventory = 30;
        public const int SizeBackpack = 10;

        public RealmsItem Main { get; set; }
        public RealmsItem Offhand { get; set; }
        public RealmsItem Ranged { get; set; }
        public RealmsItem Ammo { get; set; }
        public RealmsItem Armor { get; set; }
        public RealmsItem Trinket { get; set; }
        public RealmsItem Spellbook { get; set; }
        public List<RealmsItem> Backpack { get; set; }

        public static RealmsInventory LoadInventory(byte[] data, int index, List<RealmsItem> items)
        {
            var offPlayer = RealmsPlayer.OffsetPlayer + (index * RealmsPlayer.SizePlayer);
            var offInventory = offPlayer + OffsetInventory;
            var inventory = new RealmsInventory
            {
                Main = RealmsItem.Copy(data[offInventory + 0], data[offInventory + 1], items),
                Offhand = RealmsItem.Copy(data[offInventory + 2], data[offInventory + 3], items),
                Ranged = RealmsItem.Copy(data[offInventory + 4], data[offInventory + 5], items),
                Ammo = RealmsItem.Copy(data[offInventory + 6], data[offInventory + 7], items),
                Armor = RealmsItem.Copy(data[offInventory + 8], data[offInventory + 9], items),
                Trinket = RealmsItem.Copy(data[offInventory + 10], data[offInventory + 11], items),
                Spellbook = RealmsItem.Copy(data[offInventory + 12], data[offInventory + 13], items)
            };
            inventory.Backpack = new List<RealmsItem>();
            for(var b = 0; b < SizeBackpack; b++)
            {
                inventory.Backpack.Add(RealmsItem.Copy(data[offInventory + (b * 2) + 14], data[offInventory + (b * 2) + 15], items));
            }
            return inventory;
        }

        public static void UpdateInventory(byte[] data, int index, RealmsInventory inventory)
        {
            var offPlayer = RealmsPlayer.OffsetPlayer + (index * RealmsPlayer.SizePlayer);
            var offInventory = offPlayer + OffsetInventory;
            RealmsData.UpdateData(data, offInventory + 0, inventory.Main != null ? inventory.Main.Data[0] : 0);
            RealmsData.UpdateData(data, offInventory + 1, inventory.Main != null ? inventory.Main.Data[1] : 0);
            RealmsData.UpdateData(data, offInventory + 2, inventory.Offhand != null ? inventory.Offhand.Data[0] : 0);
            RealmsData.UpdateData(data, offInventory + 3, inventory.Offhand != null ? inventory.Offhand.Data[1] : 0);
            RealmsData.UpdateData(data, offInventory + 4, inventory.Ranged != null ? inventory.Ranged.Data[0] : 0);
            RealmsData.UpdateData(data, offInventory + 5, inventory.Ranged != null ? inventory.Ranged.Data[1] : 0);
            RealmsData.UpdateData(data, offInventory + 6, inventory.Ammo != null ? inventory.Ammo.Data[0] : 0);
            RealmsData.UpdateData(data, offInventory + 7, inventory.Ammo != null ? inventory.Ammo.Data[1] : 0);
            RealmsData.UpdateData(data, offInventory + 8, inventory.Armor != null ? inventory.Armor.Data[0] : 0);
            RealmsData.UpdateData(data, offInventory + 9, inventory.Armor != null ? inventory.Armor.Data[1] : 0);
            RealmsData.UpdateData(data, offInventory + 10, inventory.Trinket != null ? inventory.Trinket.Data[0] : 0);
            RealmsData.UpdateData(data, offInventory + 11, inventory.Trinket != null ? inventory.Trinket.Data[1] : 0);
            RealmsData.UpdateData(data, offInventory + 12, inventory.Spellbook != null ? inventory.Spellbook.Data[0] : 0);
            RealmsData.UpdateData(data, offInventory + 13, inventory.Spellbook != null ? inventory.Spellbook.Data[1] : 0);
            var bp = 0;
            foreach (var back in inventory.Backpack)
            {
                RealmsData.UpdateData(data, offInventory + (bp * 2) + 14, back != null ? back.Data[0] : 0);
                RealmsData.UpdateData(data, offInventory + (bp * 2) + 15, back != null ? back.Data[1] : 0);
                bp++;
            }
        }
    }
}

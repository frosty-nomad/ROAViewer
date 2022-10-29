using System.Collections.Generic;

namespace Realms
{
    public class RealmsWeapon
    {
        public string Name { get; set; }
        public string TypeName { get; set; }
        public int Action { get; set; }
        public string DamageType { get { return string.Join("", DamageTypes); } }
        public List<string> DamageTypes { get; set; }
        public int Hit { get; set; }
        public int MinDmg { get; set; }
        public int MaxDmg { get; set; }
        public List<string> Properties { get; set; }
        public string Props { get { return string.Join(",", Properties); } }
        public int Value { get; set; }

        public static RealmsWeapon ToWeapon(RealmsItem item)
        {
            return new RealmsWeapon
            {
                Name = item.Name,
                TypeName = item.TypeName,
                Value = item.Value,
                Hit = item.Data[6],
                Action = item.Data[7],
                MinDmg = item.Data[8],
                MaxDmg = item.Data[8] + item.Data[9],
                DamageTypes = RealmsItem.DamageTypes(item.Data[4]),
                Properties = RealmsItem.Properties(item.Data)
            };
        }
    }
}

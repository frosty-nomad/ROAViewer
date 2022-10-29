using System.Collections.Generic;

namespace Realms
{
    public class RealmsArmor
    {
        public string Name { get; set; }
        public string TypeName { get; set; }
        public int Defense { get; set; }
        public int Movement { get; set; }
        public int Reduce { get; set; }
        public int Resist { get; set; }
        public int Value { get; set; }
        public string Effect { get; set; }
        public string DamageType { get { return string.Join("", DamageTypes); } }
        public string Props { get { return string.Join(",", Properties); } }
        public List<string> DamageTypes { get; set; }
        public List<string> Properties { get; set; }

        public static RealmsArmor ToArmor(RealmsItem item)
        {
            return new RealmsArmor
            {
                Name = item.Name,
                TypeName = item.TypeName,
                Value = item.Value,
                Defense = item.Data[6],
                Movement = item.Data[7],
                Reduce = item.Data[8],
                Resist = item.Data[9],
                DamageTypes = RealmsItem.DamageTypes(item.Data[4]),
                Properties = RealmsItem.Properties(item.Data),
                Effect = RealmsItem.GetEffect(item.Data[10], item.Data[11])
            };
        }
    }
}

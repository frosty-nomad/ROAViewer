namespace Realms
{
    public class RealmsHealth
    {
        public const int OffsetHealth = 548;
        public const int SizeHealth = 32;

        public int Fatigue { get; set; }
        public int Health { get; set; }
        public int Stamina { get; set; }
        public int Wounds { get; set; }

        public static RealmsHealth LoadHealth(byte[] data, int index)
        {
            var offHealth = OffsetHealth + (index * SizeHealth);

            return new RealmsHealth
            {
                Wounds = RealmsData.ConvertInt(data[offHealth], data[offHealth + 1]),
                Health = RealmsData.ConvertInt(data[offHealth + 2], data[offHealth + 3]),
                Fatigue = RealmsData.ConvertInt(data[offHealth + 4], data[offHealth + 5]),
                Stamina = RealmsData.ConvertInt(data[offHealth + 6], data[offHealth + 7])
            };
        }

        public static void UpdateHealth(byte[] data, int index, RealmsHealth health)
        {
            var offHealth = OffsetHealth + (index * SizeHealth);
            RealmsData.UpdateData(data, offHealth + 0, health.Wounds, 2);
            RealmsData.UpdateData(data, offHealth + 4, health.Fatigue, 2);
        }
    }
}

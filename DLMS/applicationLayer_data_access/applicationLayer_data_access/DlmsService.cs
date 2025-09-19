
    // DLMS Service class
    public class DlmsService
    {
        private MeterObject[] meterObjects;
        private int meterObjectCount;

        // Predefined OBIS codes
        public static readonly ObisCode obis_voltage = new ObisCode(1, 0, 32, 7, 0, 255);
        public static readonly ObisCode obis_energy = new ObisCode(1, 0, 1, 8, 0, 255);

        public DlmsService(MeterObject[] objects)
        {
            meterObjects = objects;
            meterObjectCount = objects.Length;
        }

        // === GET Service ===
        public void DlmsGet(ObisCode obis)
        {
            for (int i = 0; i < meterObjectCount; i++)
            {
                if (obis.Match(meterObjects[i].Obis))
                {
                    Console.WriteLine($"[GET] {meterObjects[i].Name} = {meterObjects[i].Value}");
                    return;
                }
            }
            Console.WriteLine("[GET] OBIS not found.");
        }

        // === SET Service ===
        public void DlmsSet(ObisCode obis, int newValue)
        {
            for (int i = 0; i < meterObjectCount; i++)
            {
                if (obis.Match(meterObjects[i].Obis))
                {
                    meterObjects[i].Value = newValue;
                    Console.WriteLine($"[SET] {meterObjects[i].Name} updated to {newValue}");
                    return;
                }
            }
            Console.WriteLine("[SET] OBIS not found.");
        }

        // === ACTION Service ===
        public void DlmsAction(ObisCode obis, string method)
        {
            if (string.Equals(method, "RESET", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("[ACTION] Resetting meter values...");
                for (int i = 0; i < meterObjectCount; i++)
                {
                    meterObjects[i].Value = 0;
                }
                Console.WriteLine("[ACTION] Reset complete.");
            }
            else if (string.Equals(method, "SYNC_TIME", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("[ACTION] Synchronizing meter clock to system time...");
                // Time sync logic here
            }
            else
            {
                Console.WriteLine("[ACTION] Unknown method.");
            }
        }
    }

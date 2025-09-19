using System;

namespace DLMS.Services
{ 
    // Example usage
    public class Program
    {
        public static void Main()
        {
            // Create meter objects
            MeterObject[] meterObjects = new MeterObject[]
            {
                new MeterObject("Voltage", DlmsService.obis_voltage, 200),
                new MeterObject("Energy", DlmsService.obis_energy, 1540)
                // Add more meter objects as needed
            };

            // Create DLMS service instance
            DlmsService dlms = new DlmsService(meterObjects);

            // GET example
            dlms.DlmsGet(DlmsService.obis_voltage);
            //Get Energy
            dlms.DlmsGet(DlmsService.obis_energy);

            // SET example
            dlms.DlmsSet(DlmsService.obis_voltage, 240);
            dlms.DlmsSet(DlmsService.obis_energy, 2000);

            // ACTION example
            dlms.DlmsAction(DlmsService.obis_energy, "RESET");

            //Now checking again the values
            dlms.DlmsGet(DlmsService.obis_voltage);
            //Get Energy
            dlms.DlmsGet(DlmsService.obis_energy);
        }
    }
}
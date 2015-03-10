
namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GSMTest
    {
        public static void Test()
        {
            List<GSM> gsms = new List<GSM>();
            gsms.Add(
                new GSM("Sony xperia e4", "Sony", 150.00m, "Pesho",
                    new Battery("2300 mah", 24, 13, BatteryType.LiIon),
                    new Display(5, 32000000)));
            gsms.Add(
                new GSM("LG L Fino", "LG", 150.00m, "Pesho",
                    new Battery("1900 mah", 27, 12, BatteryType.LiIon),
                    new Display(4, 32000000)));
            gsms.Add(
                new GSM("Lenovo S90", "Lenovo", 400.00m, "Gosho",
                new Battery("2300 mah", 22, 11, BatteryType.NiMH),
                new Display(6, 32000000)));

            foreach (var item in gsms)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(GSM.IPhone4S);
        }
    }
}

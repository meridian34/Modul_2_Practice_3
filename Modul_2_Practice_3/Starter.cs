using System;
using Modul_2_Practice_3.Services;
using Modul_2_Practice_3.Helpers;
using Modul_2_Practice_3.Model.Enum;

namespace Modul_2_Practice_3
{
    public class Starter
    {
        public void Run()
        {
            var generator = new FlatGeneratorService();
            var flat = generator.GenerateFlat(10);
            foreach (var item in flat.GetDevices())
            {
                Console.WriteLine($"{item.AppliancesSubType} {item.AppliancesType} {item.Class} {item.Category} {item.Power} {item.IsIncluded}");
            }

            Console.WriteLine();

            var device = flat.FindSampleDevice(AppliancesSubType.Computer, true);

            if (device == null)
            {
                Console.WriteLine("Included computer not faund");
            }
            else
            {
                Console.WriteLine("Included computer faund");
            }

            Console.WriteLine();

            Console.WriteLine($"Sum power included devices: {flat.GetSumPowerIncludedDevices()}");
        }
    }
}

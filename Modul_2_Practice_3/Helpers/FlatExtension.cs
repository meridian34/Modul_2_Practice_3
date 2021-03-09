using Modul_2_Practice_3.Model;
using Modul_2_Practice_3.Model.Enum;

namespace Modul_2_Practice_3.Helpers
{
    public static class FlatExtension
    {
        public static SampleDevice FindSampleDevice(this Flat flat, AppliancesSubType subTypeAppliance, bool isIncluded)
        {
            foreach (var item in flat.GetDevices())
            {
                if (item.IsIncluded == isIncluded && item.AppliancesSubType == subTypeAppliance)
                {
                    return item;
                }
            }

            return null;
        }

        public static int GetSumPowerIncludedDevices(this Flat flat)
        {
            var sumPower = 0;
            foreach (var item in flat.GetDevices())
            {
                if (item.IsIncluded)
                {
                    sumPower += item.Power;
                }
            }

            return sumPower;
        }
    }
}

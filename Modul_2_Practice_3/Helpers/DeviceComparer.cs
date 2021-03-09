using System.Collections;
using Modul_2_Practice_3.Model;

namespace Modul_2_Practice_3.Helpers
{
    public class DeviceComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var device1 = x as SampleDevice;
            var device2 = y as SampleDevice;
            if (device1.AppliancesSubType > device2.AppliancesSubType)
            {
                return 1;
            }
            else if (device1.AppliancesSubType < device2.AppliancesSubType)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}

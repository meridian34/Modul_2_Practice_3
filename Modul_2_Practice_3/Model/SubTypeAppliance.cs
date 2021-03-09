using Modul_2_Practice_3.Model.Enum;

namespace Modul_2_Practice_3.Model
{
    public abstract class SubTypeAppliance : TypeAppliance
    {
        public SubTypeAppliance(int power, bool isIncluded)
            : base(power, isIncluded)
        {
        }

        public abstract AppliancesSubType AppliancesSubType { get; set; }
    }
}

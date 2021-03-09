using Modul_2_Practice_3.Model.Enum;

namespace Modul_2_Practice_3.Model
{
    public abstract class TypeAppliance : ClassAppliance
    {
        public TypeAppliance(int power, bool isIncluded)
            : base(power, isIncluded)
        {
        }

        public abstract AppliancesType AppliancesType { get; set; }
    }
}

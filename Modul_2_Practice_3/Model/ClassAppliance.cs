using Modul_2_Practice_3.Model.Enum;

namespace Modul_2_Practice_3.Model
{
    public abstract class ClassAppliance : CategoryAppliance
    {
        public ClassAppliance(int power, bool isIncluded)
            : base(power, isIncluded)
        {
        }

        public abstract Class Class { get; set; }
    }
}

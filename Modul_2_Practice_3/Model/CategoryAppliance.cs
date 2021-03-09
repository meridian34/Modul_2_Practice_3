using Modul_2_Practice_3.Model.Enum;

namespace Modul_2_Practice_3.Model
{
    public abstract class CategoryAppliance : ElectricalAppliance
    {
        public CategoryAppliance(int power, bool isIncluded)
            : base(power, isIncluded)
        {
        }

        public abstract Category Category { get; set; }
    }
}

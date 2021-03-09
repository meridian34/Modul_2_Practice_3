namespace Modul_2_Practice_3.Model
{
    public abstract class ElectricalAppliance
    {
        public ElectricalAppliance(int power, bool isIncluded)
        {
            Power = power;
            IsIncluded = isIncluded;
        }

        public int Power { get; set; }

        public bool IsIncluded { get; set; }
    }
}

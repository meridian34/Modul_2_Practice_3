using Modul_2_Practice_3.Model.Enum;

namespace Modul_2_Practice_3.Model
{
    public class SampleDevice : SubTypeAppliance
    {
        private AppliancesSubType _appliancesSubType;
        private AppliancesType _appliancesType;

        public SampleDevice(AppliancesSubType appliancesSubType, Class appliancesClass, int power, bool isIncluded)
            : base(power, isIncluded)
        {
            AppliancesSubType = appliancesSubType;
            Class = appliancesClass;
        }

        public override AppliancesSubType AppliancesSubType
        {
            get
            {
                return _appliancesSubType;
            }

            set
            {
                switch (value)
                {
                    case AppliancesSubType.Computer:
                        AppliancesType = AppliancesType.ComputerAppliances;
                        break;
                    case AppliancesSubType.Notebook:
                        AppliancesType = AppliancesType.ComputerAppliances;
                        break;
                    case AppliancesSubType.Kettle:
                        AppliancesType = AppliancesType.SmallHouseholdAppliances;
                        break;
                    case AppliancesSubType.Mixer:
                        AppliancesType = AppliancesType.SmallHouseholdAppliances;
                        break;
                    case AppliancesSubType.Fridge:
                        AppliancesType = AppliancesType.LargeHomeAppliances;
                        break;
                    case AppliancesSubType.Washer:
                        AppliancesType = AppliancesType.LargeHomeAppliances;
                        break;
                    case AppliancesSubType.Smartphone:
                        AppliancesType = AppliancesType.MobileAppliances;
                        break;
                }

                _appliancesSubType = value;
            }
        }

        public override AppliancesType AppliancesType
        {
            get
            {
                return _appliancesType;
            }

            set
            {
                switch (value)
                {
                    case AppliancesType.ComputerAppliances:
                        Category = Category.DigitalAppliances;
                        break;
                    case AppliancesType.LargeHomeAppliances:
                        Category = Category.HouseholdAppliances;
                        break;
                    case AppliancesType.MobileAppliances:
                        Category = Category.DigitalAppliances;
                        break;
                    case AppliancesType.SmallHouseholdAppliances:
                        Category = Category.HouseholdAppliances;
                        break;
                }

                _appliancesType = value;
            }
        }

        public override Class Class { get; set; }

        public override Category Category { get; set; }
    }
}

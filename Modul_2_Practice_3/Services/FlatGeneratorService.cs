using System;
using Modul_2_Practice_3.Services.Abstract;
using Modul_2_Practice_3.Model;
using Modul_2_Practice_3.Model.Enum;

namespace Modul_2_Practice_3.Services
{
    public class FlatGeneratorService : IFlatGeneratorService
    {
        private readonly Random _random;
        private readonly int _minRandValue;
        private readonly int _maxRandValue;

        public FlatGeneratorService()
        {
            _minRandValue = 0;
            _maxRandValue = 7;
            _random = new Random();
        }

        public Flat GenerateFlat(int maxAppliance)
        {
            var appliances = new SampleDevice[1];
            var currentSize = 0;
            var pointer = 0;
            var isIncluded = false;
            while (currentSize <= maxAppliance)
            {
                isIncluded = _random.Next(0, 2) == 1 ? true : false;
                switch (_random.Next(_minRandValue, _maxRandValue))
                {
                    case 0:
                        appliances[pointer] = new SampleDevice(AppliancesSubType.Computer, Class.A, 800, isIncluded);
                        break;
                    case 1:
                        appliances[pointer] = new SampleDevice(AppliancesSubType.Fridge, Class.A, 2200, isIncluded);
                        break;
                    case 2:
                        appliances[pointer] = new SampleDevice(AppliancesSubType.Kettle, Class.A, 1000, isIncluded);
                        break;
                    case 3:
                        appliances[pointer] = new SampleDevice(AppliancesSubType.Mixer, Class.A, 400, isIncluded);
                        break;
                    case 4:
                        appliances[pointer] = new SampleDevice(AppliancesSubType.Notebook, Class.A, 300, isIncluded);
                        break;
                    case 5:
                        appliances[pointer] = new SampleDevice(AppliancesSubType.Smartphone, Class.A, 100, isIncluded);
                        break;
                    case 6:
                        appliances[pointer] = new SampleDevice(AppliancesSubType.Washer, Class.A, 1800, isIncluded);
                        break;
                }

                currentSize++;

                if (currentSize >= maxAppliance)
                {
                    break;
                }

                Array.Resize(ref appliances, appliances.Length + 1);
                pointer++;
            }

            return new Flat(appliances);
        }
    }
}

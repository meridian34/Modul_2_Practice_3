namespace Modul_2_Practice_3.Model
{
    public class Flat
    {
        private readonly SampleDevice[] _sampleDevices;

        public Flat(SampleDevice[] sampleDevices)
        {
            _sampleDevices = sampleDevices;
        }

        public SampleDevice[] GetDevices()
        {
            return _sampleDevices;
        }
    }
}

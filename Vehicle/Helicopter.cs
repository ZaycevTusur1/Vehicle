namespace Vehicle
{
    public class Helicopter : BaseVehicle
    {
        private int _powerHeli;
        public int PowerHeli
        {
            get
            {
                return _powerHeli;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(PowerHeli));
                else
                    _powerHeli = value;
            }
        }
        public override int CalculateFuel(int range)
        {
            return range / (FuelConsumption + EngineCapacity + PowerHeli);
        }
    }
}

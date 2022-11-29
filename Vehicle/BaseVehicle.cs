namespace Vehicle
{
    public abstract class BaseVehicle : IVehicle
    {
        private int _engineCapacity;
        private int _fuelConsumption;
        private int _tankCapacity;

        public string Name { get; set; }
        public int EngineCapacity
        {
            get
            {
                return _engineCapacity;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(EngineCapacity));
                else
                    _engineCapacity = value;
            }
        }
        public int FuelConsumption
        {
            get
            {
                return _fuelConsumption;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(FuelConsumption));
                else
                    _fuelConsumption = value;
            }
        }
        public int TankCapacity
        {
            get { return _tankCapacity; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(TankCapacity));
                else
                    _tankCapacity = value;
            }
        }

        public virtual int  CalculateFuel(int range)
        {
            return range / (FuelConsumption + EngineCapacity);
        }

      
    }
}

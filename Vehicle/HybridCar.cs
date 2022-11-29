namespace Vehicle
{
    public class HybridCar : BaseVehicle
    {
        private int _batteryCopacity;
        public int BatteryCopacity 
        {
            get
            {
                return _batteryCopacity;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(BatteryCopacity));
                else
                    _batteryCopacity = value;
            }
        }
        public override int CalculateFuel(int range)
        {
            return ((range + BatteryCopacity) / (FuelConsumption + EngineCapacity)) ;
        }

    }
}

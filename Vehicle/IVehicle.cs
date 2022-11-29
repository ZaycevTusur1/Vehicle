namespace Vehicle
{
    public interface IVehicle
    {
        public string Name { get; set; }
        public int EngineCapacity { get; set; }
        public int FuelConsumption { get; set; }
        public int TankCapacity { get; set; }
        public int CalculateFuel(int range);
        
    }
}
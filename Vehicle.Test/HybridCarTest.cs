namespace Vehicle.Test
{
    public class HybridCarTest
    {
        HybridCar car;
        [Fact]
        public void SetEngineCapacity_Int_Int()
        {
            car = new HybridCar();
            car.BatteryCopacity = 1;
            Assert.True(1 == car.BatteryCopacity);
        }
        [Fact]
        public void SetEngineCapacity_NegativeInt_ArgumentOutOfRangeException()
        {
            car = new HybridCar();
            Assert.Throws<ArgumentOutOfRangeException>(() => car.BatteryCopacity = -1);
        }
        [Fact]
        public int CalculateFuel_int_return_int()
        {
            Random random = new Random();
            car = new HybridCar();
            int range = random.Next(0, 100);
            int fuelConsumption = random.Next(0, 100); 
            int engineCapacity = random.Next(0, 100);
            int batteryCopacity = random.Next(0, 100); 

            car.EngineCapacity = engineCapacity;
            car.FuelConsumption = fuelConsumption;
            car.BatteryCopacity = batteryCopacity;
            var result = car.CalculateFuel(range);
            Assert.Equal( ((range + batteryCopacity) / (fuelConsumption + engineCapacity)), result);
            return result;

        }
    }
}

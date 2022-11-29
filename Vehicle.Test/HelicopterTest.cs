namespace Vehicle.Test
{
    public class HelicopterTest
    {
        Helicopter car;
        [Fact]
        public void SetEngineCapacity_Int_Int()
        {
            car = new Helicopter();
            car.PowerHeli = 1;
            Assert.True(1 == car.PowerHeli);
        }
        [Fact]
        public void SetEngineCapacity_NegativeInt_ArgumentOutOfRangeException()
        {
            car = new Helicopter();
            Assert.Throws<ArgumentOutOfRangeException>(() => car.PowerHeli = -1);
        }
        [Fact]
        public int CalculateFuel_int_return_int()
        {
            Random random = new Random();
            car = new Helicopter();
            int range = random.Next(0, 100);
            int fuelConsumption = random.Next(0, 100);
            int engineCapacity = random.Next(0, 100);
            int powerHeli = random.Next(0, 100);

            car.EngineCapacity = engineCapacity;
            car.FuelConsumption = fuelConsumption;
            car.PowerHeli = powerHeli;
            var result = car.CalculateFuel(range);
            Assert.Equal( (range / (fuelConsumption + engineCapacity + powerHeli)), result);
            return result;
        }
    }
}

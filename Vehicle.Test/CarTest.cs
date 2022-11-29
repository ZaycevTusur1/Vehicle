namespace Vehicle.Test;

public class CarTest
{
    Car car;
    [Fact]
    public void SetEngineCapacity_Int_Int()
    {
        car = new Car();
        car.EngineCapacity = 1;
        Assert.True(1 == car.EngineCapacity);
    }
    [Fact]
    public void SetEngineCapacity_NegativeInt_ArgumentOutOfRangeException()
    {
        car = new Car();
        Assert.Throws<ArgumentOutOfRangeException>(() => car.EngineCapacity = -1);
    }
    [Fact]
    public void SetFuelConsumption_Int_return_Int()
    {
        car = new Car();
        car.FuelConsumption = 1;
        Assert.True(1 == car.FuelConsumption);
    }
    [Fact]
    public void SetEngineCapacity_NegativeInt_return_ArgumentOutOfRangeException()
    {
        car = new Car();
        Assert.Throws<ArgumentOutOfRangeException>(() => car.FuelConsumption = -1);
    }
    [Fact]
    public void SetTankCapacity_Int_return_Int()
    {
        car = new Car();
        car.TankCapacity = 1;
        Assert.True(1 == car.TankCapacity);
    }
    [Fact]
    public void SetTankCapacity_NegativeInt_return_ArgumentOutOfRangeException()
    {
        car = new Car();
        Assert.Throws<ArgumentOutOfRangeException>(() => car.TankCapacity = -1);
    }
    [Fact]
    public int CalculateFuel_int_return_int()
    {
        Random random = new Random();   
        car = new Car();
        int range = random.Next(0, 100);
        int fuelConsumption = random.Next(0, 100); ;
        int engineCapacity = random.Next(0, 100); ;
        car.EngineCapacity = engineCapacity;
        car.FuelConsumption = fuelConsumption;
        var result = car.CalculateFuel(range);
        Assert.Equal(range / (fuelConsumption + engineCapacity), result);
        return result;

    }
}
// See https://aka.ms/new-console-template for more information
using Vehicle;

List<IVehicle> vehicles = new List<IVehicle>();
while (true)
{
    Console.WriteLine("Add vehicle to list");
    Console.WriteLine("Enter vehicle type: 1 - car 2 - hybrid car 3 - helicopter 4 - break");
    int type = 0;
    
    try
    {
        int.TryParse(Console.ReadLine(), out type);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    if (type == 1)
    {
        try
        {
            Car car = new Car();
            Console.WriteLine("Enter name");
            car.Name = Console.ReadLine();
            Console.WriteLine("Enter Engine Capacity");
            car.EngineCapacity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Tank Capacity");
            car.TankCapacity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fuel Consumption");
            car.FuelConsumption = int.Parse(Console.ReadLine());
            vehicles.Add(car);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    if (type == 2)
    {
        try
        {
            HybridCar hCar = new HybridCar();
            Console.WriteLine("Enter name");

            hCar.Name = Console.ReadLine();
            Console.WriteLine("Enter Engine Capacity");

            hCar.EngineCapacity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Tank Capacity");

            hCar.TankCapacity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fuel Consumption");

            hCar.FuelConsumption = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Battery Copacity");
            hCar.BatteryCopacity = int.Parse(Console.ReadLine());

            vehicles.Add(hCar);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    if (type == 3)
    {
        try
        {
            Helicopter hCar = new Helicopter();
            Console.WriteLine("Enter name");

            hCar.Name = Console.ReadLine();
            Console.WriteLine("Enter Engine Capacity");

            hCar.EngineCapacity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Tank Capacity");

            hCar.TankCapacity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fuel Consumption");

            hCar.FuelConsumption = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Force Power");
            hCar.PowerHeli = int.Parse(Console.ReadLine());
            vehicles.Add(hCar);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    if (type == 4)
        break;
}
foreach (var vehicle in vehicles)
{
    Console.WriteLine($"{vehicle.Name} for 100 kilometers needs {vehicle.CalculateFuel(100)} liters of fuel");
}



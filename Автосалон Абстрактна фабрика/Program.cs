// Абстрактний клас для легкових автомобілів
public abstract class Car
{
    public abstract void DisplayInfo();
}

// Абстрактний клас для вантажних автомобілів
public abstract class Truck
{
    public abstract void DisplayInfo();
}

// Конкретна реалізація легкового автомобіля
public class Sedan : Car
{
    public override void DisplayInfo()
    {
        Console.WriteLine("Це легковий автомобіль типу седан.");
    }
}

// Конкретна реалізація вантажного автомобіля
public class PickupTruck : Truck
{
    public override void DisplayInfo()
    {
        Console.WriteLine("Це вантажний автомобіль типу пікап.");
    }
}

// Абстрактна фабрика
public abstract class VehicleFactory
{
    public abstract Car CreateCar();
    public abstract Truck CreateTruck();
}

// Фабрика для виробництва легкових і вантажних автомобілів
public class AutomobileFactory : VehicleFactory
{
    public override Car CreateCar()
    {
        return new Sedan();
    }

    public override Truck CreateTruck()
    {
        return new PickupTruck();
    }
}

class Program
{
    static void Main()
    {
        // Використання абстрактної фабрики для створення автомобілів
        VehicleFactory factory = new AutomobileFactory();

        Car car = factory.CreateCar();
        Truck truck = factory.CreateTruck();

        // Виведення інформації про автомобілі
        car.DisplayInfo();
        truck.DisplayInfo();
    }
}

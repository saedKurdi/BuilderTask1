public interface Builder
{
    public void Reset();
    public void SetSeats(int count);
    public void SetEngine(string engine);
    public void SetTripComputer();
    public void SetGPS();
}

public class Client
{
    Director ? director;

    public Client()
    {
        director = new Director();  
        
    }
}

public class Director
{
    public Builder? Builder { get; set; }
    public void MakeSuv(Builder ? builder)
    {
        Console.WriteLine("Maked Suv For Builder ! : {0}",Builder);
    }
    public void MakeSportsCar(Builder ? builder)
    {
        Builder?.Reset();
        Builder?.SetSeats(2);
        Builder?.SetEngine("Super Engine v2");
        Builder?.SetTripComputer();
        Builder?.SetGPS();
    } 
}

public class CarBuilder : Builder
{
    Car ? car;

    public void Reset()
    {
        this.car = new Car();
        Console.WriteLine("Reseted For CarBuilder !");
    }

    public void SetEngine(string engine)
    {
        Console.WriteLine("Engine Was Set For CarBuilder !");
    }

    public void SetGPS()
    {
        Console.WriteLine("GPS Was Set For CarBuilder !");
    }

    public void SetSeats(int count)
    {
        Console.WriteLine("{0} Seats was set for carbuilder !",count);
    }

    public void SetTripComputer()
    {
        Console.WriteLine("Trip Was Set For CarBuilder !");
    }

    public Car ? GetResult() => this.car;
}

public class CarManualBuilder : Builder
{
    Manual? manual;

    public void Reset()
    {
        this.manual = new Manual();
        Console.WriteLine("Reseted For CarManualBuilder !");
    }

    public void SetEngine(string engine)
    {
        Console.WriteLine("Engine Was Set For CarManualBuilder"); ;
    }

    public void SetGPS()
    {
        Console.WriteLine("GPS was Set For ManualCarBuilder ! ");
    }

    public void SetSeats(int count)
    {
        Console.WriteLine("Seats Ws Set For ManualCarBuilder !"); ;
    }

    public void SetTripComputer()
    {
        Console.WriteLine("Trip computer was set for ManualCarBuilder!");
    }

    public Manual ? GetResult() => this.manual;
}

public class Car
{
}

public class Manual
{
}

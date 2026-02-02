using System;
class Vehicle{
    public string brand="ford";

    public void brake()
    {
        
Console.WriteLine("It has brake");
    }

}
class Car :Vehicle{
    Car(){
        Console.WriteLine("It has engine");
    }
    public static void Main(){
        Vehicle v1=new Vehicle();
        Console.WriteLine("The brand is "+ v1.brand);
        v1.brake();
        Car c1=new Car();

    }
}
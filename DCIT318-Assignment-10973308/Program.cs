class Program
{
    static void Main(string[] args)
    {
        Animal genericAnimal = new Animal();
        genericAnimal.MakeSound();

        Dog myDog = new Dog();
        myDog.MakeSound();

        Cat myCat = new Cat();
        myCat.MakeSound();

        Circle circle = new Circle(3.0);
        Console.WriteLine("Circle Area: " + circle.GetArea());

        Rectangle rectangle = new Rectangle(4.0, 5.0);
        Console.WriteLine("Rectangle Area: " + rectangle.GetArea());

        Car myCar = new Car();
        myCar.Move();

        Bicycle myBicycle = new Bicycle();
        myBicycle.Move();
    }
}
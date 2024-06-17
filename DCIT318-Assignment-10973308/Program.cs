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
    }
}
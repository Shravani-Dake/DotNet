/*
Inheritance : Inheritance allows a class to access
              properties and methods of another class.
              child class inherits the properties of parent class.
              it can be accesed with : ( class Dog : Animal)
              Dog inherits Animal
              Can use Animal's methods
*/

using System;

// Parent class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating...");
    }
}

// Child class inherits Animal
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking...");
    }
}

class Program
{
    static void Main()
    {
        Dog d1 = new Dog();

        d1.Eat();   // Inherited method
        d1.Bark();  // Own method

        Console.ReadLine();
    }
}

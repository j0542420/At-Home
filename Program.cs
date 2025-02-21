using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace At_Home
{
    class Animal
    {
        //properties //Attributes //fields  of an animal
        public string name { get; set; }
        public string skinColor { get; set; }
        public int numberOfLegs { get; set; }
        public int age { get; set; }
        public string sound { get; set; }

        //default constructor: is a method has the same name of the class to build/imitate the object // worker to build the object
        //assign default
        public Animal()
        {
            name = "Fluffy";
            skinColor = "black";
            numberOfLegs = 4;
            age = 1;
            sound = "meouw";
        }

        //custome constructor to create an animal with specific attributes
        public Animal(string Aname, string AskinColor, int AnumberOfLegs, int Aage, string Asound)
        {
            name = Aname;
            skinColor = AskinColor;
            numberOfLegs = AnumberOfLegs;
            age = Aage;
            sound = Asound;
        }

        //behavior/ action/ methods
        public void Introduce()
        {
            Console.WriteLine($"I am {name}, I am {age} years old, I have {numberOfLegs} legs my skin color is {skinColor}");
        }
        public void MakeSound()
        {
            Console.WriteLine(name + " sounds " + sound);
        }
        // **NEW: Methods to update attributes**
        // Working with Example 2
        public void SetName(string newName)
        {
            name = newName;
        }

        public void SetSkinColor(string newColor)
        {
            skinColor = newColor;
        }

        public void SetAge(int newAge)
        {
            age = newAge;
        }

        public void SetSound(string newSound)
        {
            sound = newSound;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example 1 starts

            Animal animal1 = new Animal();
            Console.WriteLine("This is a Cat");
            animal1.Introduce();
            animal1.MakeSound();

            Animal animal2 = new Animal("Bergie", "Brown", 4, 2, "bark sound");
            Console.WriteLine("This is a dog");
            animal2.Introduce();
            animal2.MakeSound();

            // Create an animal
            Animal myAnimal = new Animal("Leo", "Golden", 4, 3, "Roar");
            myAnimal.Introduce();
            myAnimal.MakeSound();

            // Update properties
            //Example 2 starts

            Console.WriteLine("\nUpdating animal details...");
            myAnimal.SetName("Simba");
            myAnimal.SetSkinColor("Light Brown");
            myAnimal.SetSound("Loud Roar");

            // Display updated information
            myAnimal.Introduce();
            myAnimal.MakeSound();

            //Directly updating info (different way)
            myAnimal.name = "Simba";
            myAnimal.skinColor = "Light Brown";

            //Example 3: creating a List
            List<Animal> animals = new List<Animal>()
        {
            new Animal("Charlie", "White", 4, 2, "Bark"), // Dog
            new Animal("Whiskers", "Gray", 4, 3, "Meow"), // Cat
            new Animal("Freddy", "Green", 4, 1, "Ribbit"), // Frog
            new Animal("Max", "Brown", 4, 4, "Neigh"), // Horse
            new Animal("Oscar", "Yellow", 2, 2, "Chirp"), // Bird
            new Animal("Rocky", "Black", 4, 5, "Growl"), // Bear
            new Animal("Daisy", "Pink", 4, 3, "Oink"), // Pig
            new Animal("Bubbles", "Orange", 0, 1, "Blub"), // Fish
            new Animal("Milo", "White & Black", 4, 6, "Moo"), // Cow
            new Animal("Zara", "Golden", 4, 7, "Roar") // Lion
        };

            Console.WriteLine("\nList of Different Animals:");
            foreach (Animal a in animals)
            {
                a.Introduce();
                a.MakeSound();
            }
        }
    }
}

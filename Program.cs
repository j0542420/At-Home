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
        //properties //Attributes //fields
        public string name { get; set; }
        public string skinColor { get; set; }
        public int numberOfLegs { get; set; }
        public int age { get; set; }
        public string sound { get; set; }

        //default constructor: is a method has the same name of the class to build/inmitate the object // worker to build the object
        //assign default
        public Animal()
        {
            name = "Fluffy";
            skinColor = "black";
            numberOfLegs = 4;
            age = 1;
            sound = "meouw";
        }

        //custome constructor
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
            Console.WriteLine($"I am {name}, I have {numberOfLegs} legs my skin color is {skinColor}");
        }
        public void MakeSound()
        {
            Console.WriteLine(name + " sounds " + sound);
        }
        // **NEW: Methods to update attributes**
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

            Animal animal2 = new Animal("Bergie", "Brown", 4, 1, "bark sound");
            Console.WriteLine("This is a dog");
            animal2.Introduce();
            animal2.MakeSound();

            // Create an animal
            Animal myAnimal = new Animal("Leo", "Golden", 4, 3, "Roar");
            myAnimal.Introduce();

            // Update properties
            //Example 2 starts

            Console.WriteLine("\nUpdating animal details...");
            myAnimal.SetName("Simba");
            myAnimal.SetSkinColor("Light Brown");
            myAnimal.SetSound("Loud Roar");

            // Display updated information
            myAnimal.Introduce();
            myAnimal.MakeSound();

            myAnimal.name = "Simba";
            myAnimal.skinColor = "Light Brown";

            Animal ani;
            List<Animal> animals = new List<Animal>();
            for (int i = 0; i < 10; i++)
            {
                ani = new Animal("name" + i, "Color" + i, 4, 2, "sound" + 1);//initiate object
                animals.Add(ani);
            }

            foreach (Animal a in animals)
            {
                a.Introduce();

            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Labka4
{
    public class Zoo
    {
        public string ZName { get; }
        public string City { get; }
        public int Capacity { get; }
        public List<Animal> animals { get; }

        public static void Sound(Animal animal) { animal.Sound(); }
        public static void MovementType(Animal animal) { animal.MovementType(); }



        public Zoo(string name, string city, int capacity)
        {
            ZName = name;
            City = city;
            Capacity = capacity;
            animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            if (animals.Count < Capacity)
                animals.Add(animal);
            else
                Console.WriteLine("Заполнено");
        }


        public double MaxFleightHeight()
        {
            double maxHeight = 0;
            foreach (Animal animal in animals)
            {
                if (animal.Flheight > maxHeight)
                    maxHeight = animal.Flheight;
            }
            return maxHeight;
        }

        public double TopSpeed()
        {
            double maxSpeed = 0;
            foreach (Animal animal in animals)
            {
                if (animal.Speed > maxSpeed)
                    maxSpeed = animal.Speed;
            }
            return maxSpeed;
        }

        public void Info()
        {
            foreach (var animal in animals) { Console.Write($"--{animal.Species}--\t\t");}
            Console.WriteLine();
            foreach (var animal in animals) { Console.Write($"Возраст: {animal.Age} лет\t\t"); }
            Console.WriteLine();
            foreach (var animal in animals) { Console.Write($"Звук: "); Sound(animal); Console.Write($"\t\t"); }
            Console.WriteLine();
            foreach (var animal in animals) { Console.Write($""); MovementType(animal); Console.Write($"\t\t\t"); }
            Console.WriteLine();
            foreach (var animal in animals) { Console.Write($"Высота полёта: {animal.Flheight} км\t"); }
            Console.WriteLine();
            foreach (var animal in animals) { Console.Write($"Скорость: {animal.Speed} км/ч\t"); }
            Console.WriteLine("");
            
        }
    }
}

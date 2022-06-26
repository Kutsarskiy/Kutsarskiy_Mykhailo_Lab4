using System;

namespace Labka4
{
    public abstract class Animal
    {
        public string Species { get; }
        public int Age { get; }
        public double Speed { get; }
        public double Flheight { get; }
        public bool Flyable { get; }

        public Animal(string species, int age, double speed, double flheight, bool flyable)
        {
            this.Species = species;
            this.Age = age;
            this.Speed = speed;
            this.Flheight = flheight;
            this.Flyable = flyable;

            if (!Flyable) this.Flheight = 0;
            else this.Flheight = flheight;
        }

        public Animal(string species, int age, double speed, double flheight)
        {
            this.Species = species;
            this.Age = age;
            this.Speed = speed;
            this.Flheight = 0;
            Flyable = false;
        }

        public Animal(string species, int age, double speed)
        {
            this.Species = species;
            this.Age = age;
            this.Speed = speed;
        }

        public abstract void Sound();
        public abstract void MovementType();
    }

    public class Bird : Animal
    {
        public Bird(string species, int age, double speed, double flheight, bool flyable) :
            base(species, age, speed, flheight, flyable)
        { }
        public override void Sound()
        {
            if (Flyable)
            {
                switch (Species)
                {
                    case "������": Console.Write("������"); break;
                    case "����": Console.Write("����"); break;
                    case "�������": Console.Write("�-�-�"); break;
                    default: Console.Write("�-�-�"); break;
                }
            }
            else
            {
                switch (Species) { case "���": Console.Write("�����"); break;
                                   default: Console.Write("����"); break; }
               
            }

        }

        public override void MovementType()
        {
            if (!Flyable) { Console.Write("�����"); }
            else { Console.Write("������"); }
        }
    }

    public class Owl : Bird
    {
        public Owl(string species, int age, double speed, double flheight, bool flyable) :
              base(species, age, speed, flheight, true){}
        public override void Sound() { Console.Write("��-��"); }
    }

    public class Dog : Animal
    {
        public Dog(string species, int age, double speed) :
            base(species, age, speed){}
        public override void Sound() { Console.Write("���"); }
        public override void MovementType() { Console.Write("������"); }
    }
}
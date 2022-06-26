using System;


namespace Labka4
{
    class Program
    {

        static void Main()
        {

            Zoo myZoo = new("КПИ", "Киев", 5);

            myZoo.AddAnimal(new Dog("Мопс", 5, 15));
            myZoo.AddAnimal(new Owl("Очковая сова", 6, 80, 1, true));
            myZoo.AddAnimal(new Bird("Колибри", 5, 96, 1, true));

            int option_again = 0;
            while (option_again == 0)
            {
                Console.Write("––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––\n");
                Console.Write("Доступные опции:\n" +
                                  "[1] Показать зоопарк\n" +
                                  "[2] Разместить нового зверя в свободную клетку\n" +
                                  "[3] Выйти из приложения\n" +
                                  "\nВы выбрали: ");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {

                    case 1:
                        option_again = 0;
                        Console.WriteLine("\nИнформация про зоопарк: ");
                        Console.WriteLine($"Название: {myZoo.ZName}" +
                                          $"\nРасположение: {myZoo.City}" +
                                          $"\nВмещает {myZoo.Capacity} клеток, " +
                                          $"{myZoo.Capacity - myZoo.animals.Count} клетки сейчас свободны");

                        Console.WriteLine("\nЗвери:\n");
                        myZoo.Info();

                        Console.Write("\nПоказать лучшие результаты зверей? [Y/N]: ");
                        TopStats();
                        break;


                    case 2:
                        option_again = 0; 

                        if (myZoo.animals.Count < myZoo.Capacity)
                        {
                            int add_again = 0;
                            string onemore;

                            while (add_again == 0)
                            {
                                Console.Write("\nНажмите [1/2/3] чтобы добавить собаку, сову или птицу: ");
                                int choice = Convert.ToInt32(Console.ReadLine());
                                Console.Write("\nРасскажите нам про ваше животное: ");

                                if (choice == 1 || choice == 2 || choice == 3)
                                {
                                    Console.Write("\nВид: "); string species = Console.ReadLine();
                                    Console.Write("Возраст: "); int age = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Скорость: "); double speed = Convert.ToDouble(Console.ReadLine());

                                    switch (choice)
                                    {

                                        case 1:

                                            myZoo.AddAnimal(new Dog(species, age, speed));
                                            Console.WriteLine($"\nДобавляем собаку...\n");
                                            myZoo.Info();

                                            if (myZoo.animals.Count < myZoo.Capacity)
                                            {
                                                int free_rooms = myZoo.Capacity - myZoo.animals.Count;
                                                Console.Write($"\n{free_rooms} клетка ещё свободны. Хотите добавить ещё животных? [Y/N]: ");
                                                onemore = Console.ReadLine();
                                                switch (onemore)
                                                {
                                                    case "Y": add_again = 0; break;
                                                    case "N":
                                                        add_again = 1;
                                                        Console.Write($"\nПоказать обновлённую статистику? [Y/N]: ");
                                                        TopStats(); break;
                                                    default: add_again = 0; break;
                                                }
                                            }
                                            else
                                            {
                                                add_again = 1;
                                                Console.WriteLine("\nПоздравляем, вы заполнили зоопарк! Свободных клеток больше нет");
                                                Console.Write($"\nПоказать обновлённую статистику? [Y/N]: ");
                                                TopStats();

                                            }
                                            break;



                                        case 2:

                                            bool flyable = true; 
                                            Console.Write("Высота полёта: "); double flheight = Convert.ToDouble(Console.ReadLine());
                                            myZoo.AddAnimal(new Owl(species, age, speed, flheight, flyable));
                                            Console.WriteLine($"\nДобавляем сову...\n");
                                            myZoo.Info();

                                            if (myZoo.animals.Count < myZoo.Capacity)
                                            {
                                                int free_rooms = myZoo.Capacity - myZoo.animals.Count;
                                                Console.Write($"\n{free_rooms} клетка ещё свободны. Хотите добавить ещё животных? [Y/N]: ");
                                                onemore = Console.ReadLine();

                                                switch (onemore)
                                                {
                                                    case "Y": add_again = 0; break;
                                                    case "N":
                                                        add_again = 1;
                                                        Console.Write($"\nПоказать обновлённую статистику? [Y/N]: ");
                                                        TopStats(); break;
                                                    default: add_again = 0; break;
                                                }
                                            }
                                            else
                                            {
                                                add_again = 1;
                                                Console.WriteLine("\nПоздравляем, вы заполнили зоопарк! Свободных клеток больше нет");
                                                Console.Write($"\nПоказать обновлённую статистику? [Y/N]: ");
                                                TopStats();
                                            }
                                            break;



                                        case 3:

                                            Console.Write("Летает? [True/False]: "); bool flyable2 = Convert.ToBoolean(Console.ReadLine()); ;

                                            switch (flyable2)
                                            {
                                                case true:
                                                    Console.Write("Высота полёта: "); double flheight2 = Convert.ToDouble(Console.ReadLine());
                                                    myZoo.AddAnimal(new Bird(species, age, speed, flheight2, flyable2));
                                                    Console.WriteLine($"\nДобавляем птичку...\n");
                                                    myZoo.Info();
                                                    break;

                                                case false:
                                                    double flheight3 = 0;
                                                    myZoo.AddAnimal(new Bird(species, age, speed, flheight3, flyable2));
                                                    Console.WriteLine($"\nДобавляем птичку...\n");
                                                    myZoo.Info();
                                                    break;
                                            }

                                            if (myZoo.animals.Count < myZoo.Capacity)
                                            {
                                                int free_rooms = myZoo.Capacity - myZoo.animals.Count;
                                                Console.Write($"\n{free_rooms} клетка ещё свободны. Хотите добавить ещё животных? [Y/N]: ");
                                                onemore = Console.ReadLine();

                                                switch (onemore)
                                                {
                                                    case "Y": add_again = 0; break;
                                                    case "N":
                                                        add_again = 1;
                                                        Console.Write($"\nПоказать обновлённую статистику? [Y/N]: ");
                                                        TopStats(); break;
                                                    default: add_again = 0; break;
                                                }
                                            }
                                            else
                                            {
                                                add_again = 1;
                                                Console.WriteLine("\nПоздравляем, вы заполнили зоопарк! Свободных клеток больше нет");
                                                Console.Write($"\nПоказать обновлённую статистику? [Y/N]: ");
                                                TopStats();
                                            }
                                            break;

                                        default:
                                            add_again = 0;
                                            break;
                                    }
                                }

                                else
                                {
                                    Console.WriteLine("Ошибка! Возможно, вы нажали что-то не то");
                                    add_again = 0;
                                }

                            }
                        }
                        else
                            Console.WriteLine("К сожалению, ваш зоопарк уже заполнен");
                        break;

                    case 3:
                        option_again = 1;
                        Console.WriteLine("\nРабота программы завершена");
                        Console.WriteLine("––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                        break;

                    default:
                        option_again = 0;
                        Console.WriteLine("Ошибка! Возможно, вы нажали что-то не то");
                        break;
                }
            }


            void TopStats()
            {
                string top_stats = Console.ReadLine();
                switch (top_stats)
                {
                    case "Y":
                        Console.WriteLine($"Наивысшая высота полёта: {myZoo.MaxFleightHeight()} км");
                        Console.WriteLine($"Наивысшая скорость: {myZoo.TopSpeed()} км/ч");
                        break;
                    case "N": break;
                    default: Console.WriteLine("Ошибка! Возможно, вы нажали что-то не то. Попробуйте снова"); ; break;
                }
            }
        }
    }
}
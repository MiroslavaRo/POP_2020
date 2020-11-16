using System;
using static POP_Class_work_lesson_6.Enums;
namespace POP_Class_work_lesson_6
{
    class Program
    {
        private static Catalogue<Car> cars = new Catalogue<Car>();

        private static void Main(string[] args)
        {
            cars.Add(new Car { Make = Make.Ford, Model = Model.Escape, Color = Color.Blue, Year = 2020 });
            cars.Add(new Car { Make = Make.Ford, Model = Model.Focus, Color = Color.Blue, Year = 2020 });
            cars.Add(new Car { Make = Make.Renault, Model = Model.Megane, Color = Color.Blue, Year = 2020 });
            cars.Add(new Car { Make = Make.Toyota, Model = Model.Corolla, Color = Color.Blue, Year = 2020 });
            cars.Add(new Car { Make = Make.Toyota, Model = Model.Camry, Color = Color.Blue, Year = 2020 });

            while (true)
            {
                DisplayMenu();
                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    break;
                }
                else
                {
                    switch (choice)
                    {
                        case "1":
                            AddNewCar();
                            break;

                        case "2":
                            RemoveCar();
                            break;

                        case "3":
                            ListAllCars();
                            break;

                        case "4":
                            SearchCar();
                            break;

                    }
                }
            }
        }
        
        private static void ListAllCars()
        {
            Console.Clear();

            cars.List();

            EnterToContinue();
        }
        private static void EnterToContinue()
        {
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
        }
        private static void RemoveCar()
        {
            Console.Clear();
            Console.Write("Please enter an index of car to remove (1-...): ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int i))
            {
                if (cars.Remove(i-1))
                {
                    Console.WriteLine("Car was removed from the list");
                }
                else
                {
                    Console.WriteLine("Car was NOT removed from the list");
                }
            }
            else
            {
                Console.WriteLine("Please enter a number for the index.");
            }

            EnterToContinue();
        }        
        private static void SearchCar()
        {
            Console.Write("Please enter make or model or color or year of the searching car with capital letter: ");
            string input =  Console.ReadLine();
            
            Console.WriteLine($"Result of searching: {cars.Search(input)}");
            

            EnterToContinue();
        }
        private static void AddNewCar()
        {
            Console.Clear();
            bool overall = true;            
            var m = new Make();
            var mo = new Model();
            var c = new Color();
            while (overall) {
               // bool check = true;
                var make2 = ChooseMake(m);
                if(make2 == Make._null)
                {
                    break;
                }
                var makename2 = MakeName(make2);
                if (makename2 == null)
                {
                    break;
                }
                var model2 = ChooseModel(mo, make2);
                if (model2 == Model._null)
                {
                    break;
                }
                var modelname2 = ModelName(model2);
                if (modelname2 == null)
                {
                    break;
                }
                var color2 = ChooseColor(c);
                if (color2 == Color._null)
                {
                    break;
                }
                var colorname2 = NameColor(color2);
                if (colorname2 == null)
                {
                    break;
                }

                var year2 = ChooseYear();
                var user = new Car();
                if (year2 == 0)
                {
                    break;
                }
                else
                {
                    if (make2 != Make.other|| model2!=Model.other|| color2 != Color.other)
                    {
                        user = new Car { Make = make2, MakeName = makename2, Model = model2, ModelName= modelname2, Color = color2, ColorName = colorname2, Year = year2 };
                        cars.Add(user);
                        Console.WriteLine("\nCar was added to the list");
                    }
                    else
                    {
                        user = new Car { Make = make2, MakeName = makename2, Model = model2, ModelName = modelname2, Color = color2, ColorName = colorname2,Year = year2 };
                        cars.Add(user);
                        Console.WriteLine("\nCar was added to the list");
                    }
                    Console.WriteLine("List of cars: \n");
                    ListAllCars();
                    overall = false;
                }
                
            }
            

        }
        private static Make ChooseMake(Make m)
        {
            var make = m;
            bool correct1 = true;
            Console.WriteLine("Please choose make of your car (1-5)...\nPossible possible options: \n1.Toyota \n2.Ford \n3.Renault \n4.Peugeot \n5.Other");
            Console.WriteLine("\n\t Enter 'e' to exit");
            while (correct1)
            {
                string str = Console.ReadLine();

                if (str == "e")
                {
                    make = Make._null;
                    break;
                }

                switch (str)
                {
                    case "1":
                        make = Make.Toyota;
                        Console.WriteLine(make);
                        correct1 = false;
                        break;

                    case "2":
                        make = Make.Ford;
                        Console.WriteLine(make);
                        correct1 = false;
                        break;

                    case "3":
                        make = Make.Renault;
                        Console.WriteLine(make);
                        correct1 = false;
                        break;

                    case "4":
                        make = Make.Peugeot;
                        Console.WriteLine(make);
                        correct1 = false;
                        break;
                    case "5":
                        make = Make.other;
                        correct1 = false;
                        break;
                    default:
                        Console.WriteLine("Enter number from 1 to 5. Please, try again...");
                        correct1 = true;
                        break;
                }
            }
            return make;

        }
        private static string MakeName(Make make2)
        {
            string makeName = "";
            if (make2 == Make.other)
            {
                Console.WriteLine("Please enter make of your car: ");
                Console.WriteLine("\n\t Enter 'e' to exit");
                makeName = Console.ReadLine();
                if (makeName == "e")
                {
                    makeName = null;
                    EnterToContinue();
                    Console.Clear();
                    return makeName;
                }
                else if (makeName.Length <= 10)
                {
                    EnterToContinue();
                    Console.Clear();
                    return makeName;
                }
                else
                {
                    Console.WriteLine("Color name must be shorter than 10 letters. Please, try again...");
                }

            }
            else
            {
                EnterToContinue();
                Console.Clear();
                return make2.ToString();
            }
            EnterToContinue();
            Console.Clear();
            return makeName;
        }
        private static Model ChooseModel(Model mo, Make make2)
        {
            var model = mo;
            bool correct2 = true; Console.WriteLine("Please choose model of your car(1-8)...\nPossible possible options: \nToyota: 1.Camry \t2.Corolla  \nFord: 3.Focus \t4.Escape  \nRenault: 5.Megane \nPeugeot: 6.306, \t7.406  \n8.Other");
            Console.WriteLine("\n\t Enter 'e' to exit");
            while (correct2)
            {
                string str2 = Console.ReadLine();
                if (str2 == "e")
                {
                    model = Model._null;
                    break;
                }
                else if (make2 == Make.Toyota)
                {
                    switch (str2)
                    {
                        case "1":
                            model = Model.Camry;
                            Console.WriteLine(model);
                            correct2 = false;
                            break;

                        case "2":
                            model = Model.Corolla;
                            Console.WriteLine(model);
                            correct2 = false;
                            break;
                        case "8":
                            model = Model.other;
                            correct2 = false;
                            break;
                        default:
                            Console.WriteLine("This model is not available for current . Please, try again...");
                            correct2 = true;
                            break;
                    }
                }

                else if (make2 == Make.Ford)
                {
                    switch (str2)
                    {
                        case "3":
                            model = Model.Focus;
                            Console.WriteLine(model);
                            correct2 = false;
                            break;

                        case "4":
                            model = Model.Escape;
                            Console.WriteLine(model);
                            correct2 = false;
                            break;
                        case "8":
                            model = Model.other;
                            correct2 = false;
                            break;
                        default:
                            Console.WriteLine("This model is not available for current . Please, try again...");
                            correct2 = true;
                            break;

                    }
                }
                else if (make2 == Make.Peugeot)
                {
                    switch (str2)
                    {
                        case "5":
                            model = Model._306;
                            Console.WriteLine(model);
                            correct2 = false;
                            break;
                        case "6":
                            model = Model._406;
                            Console.WriteLine(model);
                            correct2 = false;
                            break;

                        case "8":
                            model = Model.other;
                            correct2 = false;
                            break;
                        default:
                            Console.WriteLine("This model is not available for current . Please, try again...");
                            correct2 = true;
                            break;
                    }

                }
                else if (make2 == Make.Renault)
                {
                    switch (str2)
                    {
                        case "7":
                            model = Model.Megane;
                            Console.WriteLine(model);
                            correct2 = false;
                            break;
                        case "8":
                            model = Model.other;
                            correct2 = false;
                            break;
                        default:
                            Console.WriteLine("This model is not available for current . Please, try again...");
                            correct2 = true;
                            break;
                    }
                }
                else
                {
                    model = Model.other;
                    break;
                }
                EnterToContinue();
                Console.Clear();
            }
            return model;
        }
        private static string ModelName(Model model2)
        {
            string modelName = "";
            if (model2 == Model.other)
            {
                Console.WriteLine("Please enter model of your car: ");
                Console.WriteLine("\n\t Enter 'e' to exit");
                modelName = Console.ReadLine();
                if (modelName == "e")
                {
                    modelName = null;
                    EnterToContinue();
                    Console.Clear();
                    return modelName;
                }
                else if (modelName.Length <= 10)
                {
                    EnterToContinue();
                    Console.Clear();
                    return modelName;
                }
                else
                {
                    Console.WriteLine("Color name must be shorter than 10 letters. Please, try again...");
                }

            }
            else
            {
                EnterToContinue();
                Console.Clear();
                return model2.ToString();
            }
            EnterToContinue();
            Console.Clear();
            return modelName;
        }
        private static Color ChooseColor(Color c)
        {
            var color = c;
            bool correct = true;
            Console.WriteLine("Please choose color of your car: \nPossible possible options: \n1.Red \n2.Blue\n3.Yellow\n4.Other");
            Console.WriteLine("\n\t Enter 'e' to exit");
            var str = Console.ReadLine();
            while (correct)
            {
                if (str == "e")
                {
                    color = Color._null;
                    break;
                }
                switch (str)
                {
                    case "1":
                        color = Color.Red;
                        correct = false;
                        break;
                    case "2":
                        color = Color.Blue;
                        correct = false;
                        break;
                    case "3":
                        color = Color.Yellow;
                        correct = false;
                        break;
                    case "4":
                        color = Color.other;
                        correct = false;
                        break;
                    default:
                        Console.WriteLine("This option is not available. Please, try again...");
                        break;
                }
            }
           
            return color;            
        }
        private static string NameColor(Color color2)
        {
            string colorName = "";
            if (color2 == Color.other)
            {                 
                Console.WriteLine("\nPlease enter color of your car: ");
                Console.WriteLine("\n\t Enter 'e' to exit");
                colorName = Console.ReadLine();
                if (colorName == "e")
                {
                    colorName = null;
                    EnterToContinue();
                    Console.Clear();
                    return colorName;
                }
                else if (colorName.Length <= 10)
                {
                    EnterToContinue();
                    Console.Clear();
                    return colorName;
                }
                else
                {
                    Console.WriteLine("Color name must be shorter than 10 letters. Please, try again...");
                }

            }
            else
            {
                return color2.ToString();
            }
            EnterToContinue();
            Console.Clear();
            return colorName;
        }
        private static int ChooseYear()
        {
            int year = 0;
            bool correct = true;
            Console.Write("Please enter year of your car (year must be between 1900 to 2050): ");
            Console.WriteLine("\n\t Enter 'e' to exit");
            while (correct)
            {
                string str = Console.ReadLine();
                bool checkYear = int.TryParse(str, out year);
                if (str == "e")
                {                   
                    correct = false;
                    return year;
                }
                else if (checkYear && year >= 1900 && year <= 2050)
                {
                    correct = false;
                }
                else
                {
                    Console.WriteLine("Enter number for year (year must be between 1900 to 2050). Please, try again...");
                }
            }

            EnterToContinue();
            Console.Clear();
            return year;
        }
        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("=========================");
            Console.WriteLine("1. Add new car");
            Console.WriteLine("2. Remove car");
            Console.WriteLine("3. List all cars");
            Console.WriteLine("4. Search for car");
            Console.WriteLine("5. Exit");
            Console.WriteLine("=========================");
            Console.Write("Please enter your choice (1-5): ");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using static POP_Class_work_lesson_7.Enums;

namespace POP_Class_work_lesson_7
{
    public class Catalogue<T> where T : IVehicle
    {
        string RegistrationNumber { get; set; }

        public int Year { get; set; }

        private List<T> Items;
        private Dictionary<Make, List<Model>> MakeModels = new Dictionary<Make, List<Model>>();

        public Catalogue()
        {
            Items = new List<T>();

            MakeModels.Add(Make.Ford, new List<Model> { Model.Focus, Model.Escape });
            MakeModels.Add(Make.Toyota, new List<Model> { Model.Camry, Model.Corolla });
            MakeModels.Add(Make.Peugeot, new List<Model> { Model._306, Model._406 });
            MakeModels.Add(Make.Renault, new List<Model> { Model.Megane });
           
        }

        public void Add(T item)
        {
            Items.Add(item);
        }

        public bool Remove(int itemIndex)
        {
            if (itemIndex > 0 && itemIndex <= Items.Count)
            {
                Items.RemoveAt(itemIndex);
                return true;
            }
            return false;
        }
        public string Search(string userinput)
        {
            var userinputString = userinput.Split(" ");
            //var array = new string[userinputString.Length];
            string index = "";
            string searchingCar = "not found anything";
            var arrayOfCars = new StringBuilder(10);
            foreach(var i in Items)
            {
                for (int u = 0; u < userinputString.Length; u++)
                {
                    if (i.ToString().ToLower().Contains(userinputString[u]))
                    {
                        index = i.ToString();
                    }
                    else
                    {
                        index = null;
                        break;
                    }
                }
                    arrayOfCars.Append("\n" + index);
                

            }
            if (arrayOfCars.Length == 0)
            {
                arrayOfCars.Append(searchingCar);
                return arrayOfCars.ToString();
            }
            else
            {
                return  arrayOfCars.ToString();
            }
            
        }
        public string Search (int userinput)
        {
            string searchingCar = "not found anything";
            var arrayOfCars = new StringBuilder(10);
            for(int i = 0; i < Items.Count; i++)
            { 
                T temp = Items[i];
                var item = Convert.ToString(userinput);
                if(userinput>=1900&& userinput <= 2050)
                {
                    if (Items[i].Year == userinput)
                    {
                        arrayOfCars.Append("\n" + temp);
                        return arrayOfCars.ToString();
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (Items[i].RegistrationNumber == item)
                {
                    arrayOfCars.Append("\n"+temp);
                    return arrayOfCars.ToString();
                }
                else
                {
                    continue;
                }
            }
            if (arrayOfCars.Length == 0)
            {
                arrayOfCars.Append(searchingCar);
                return arrayOfCars.ToString();
            }
            else
            {
                return arrayOfCars.ToString();
            }
        }
        public void Ordering (string choice)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                T temp = Items[i];
                int j = i;

                switch (choice)
                {
                    case "1":
                        while (j > 0 && temp.Year < Items[j - 1].Year)
                        {
                            Items[j] = Items[j - 1];
                            j = j - 1;
                        }
                        break;

                    case"2": // RegistrationNumber
                        while (j > 0 && string.Compare(temp.RegistrationNumber, Items[j - 1].RegistrationNumber) < 0)
                        {
                            Items[j] = Items[j - 1];
                            j = j - 1;
                        }
                        break;
                }
                Items[j] = temp;
            }

        }
    
        public void List()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}

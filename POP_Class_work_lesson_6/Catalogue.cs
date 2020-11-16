using System;
using System.Collections.Generic;
using System.Text;
using static POP_Class_work_lesson_6.Enums;

namespace POP_Class_work_lesson_6
{
    public class Catalogue<T>
    {
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
            var arrayOfCars = new StringBuilder(10);
            string searchingCar = "not found anything";
            foreach (var i in Items)
            {
                if (userinput.Length >= 4) {
                    if (i.ToString().ToLower().Contains(userinput.ToLower()))
                    {
                        arrayOfCars.Append("\n");
                        arrayOfCars.Append(i.ToString());
                    }

                }               
                else
                {
                    arrayOfCars.Append(searchingCar);
                    return arrayOfCars.ToString();
                }
            }
            if (arrayOfCars.Length == 0)
            {
                arrayOfCars.Append(searchingCar);
                return arrayOfCars.ToString();
            }
            return arrayOfCars.ToString();

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

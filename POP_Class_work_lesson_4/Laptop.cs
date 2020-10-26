using System;
using System.Collections.Generic;
using System.Text;

namespace POP_Class_work_lesson_4
{
   
    public class Laptop
        {
        private string model;
        private string manufacturer;
        private string processor;
        private string RAM;
        private string graphics_card;
        private string HDD;
        private string screen;        
        private int battery_life;
        private decimal price;
        private string nameofbattery;
        
        public Laptop(string model, string manufacturer, string processor, string RAM, string graphics_card, string HDD, string screen, string nameofbattery, int battery_life, decimal price)
        {
            Model = model;
            Manufacturer = manufacturer;
            Processor= processor;
            ram= RAM;
            Graphics_card =graphics_card;
            hdd = HDD;
            Screen = screen;
            Nameofbattery = nameofbattery;
            Battery_life = battery_life;
            Price = price;
            

        }
        public Laptop(string model, int price) 
        {
            this.model = model;
            this.price = price;

        }
         
        public string Model
        {
            get => model;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model can`t be empty!");
                }
                model = value;
            }
        }
        public string Manufacturer
        {
            get => manufacturer;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Manufacturer can`t be empty!");
                }
                manufacturer = value;
            }
        }
        public string Processor
        {
            get => processor;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Processor can`t be empty!");
                }
                processor = value;
            }
        }
        public string ram
        {
            get => RAM;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Ram can`t be empty!");
                }
                RAM = value;
            }
        }
        public string Graphics_card
        {
            get => graphics_card;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Graphics card can`t be empty!");
                }
                graphics_card = value;
            }
        }
        public string hdd
        {
            get => HDD;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("HDD can`t be empty!");
                }
                HDD = value;
            }
        }
        
        public string Screen
        {
            get => screen;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Screen can`t be empty!");
                }
                screen = value;
            }
        }
        
        public string Nameofbattery
        {
            get => nameofbattery;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(" can`t be empty!");
                }
                nameofbattery = value;
            }
        }
        public int Battery_life
        {
            get => battery_life;

            set
            {
                if (value<=0)
                {
                    throw new ArgumentNullException("Battery life hours can`t be negative!");
                }
                battery_life = value;
            }
        }
        
        public decimal Price
        {
            get => price;

            set
            {
                if (value<=0)
                {
                    throw new ArgumentNullException("Price can`t be negative!");
                }
                price = value;
            }
        }
        public override string ToString()
        {
            
            return $"Laptop Model: {Model}, Manufacturer: {Manufacturer}, Processor: {Processor}, RAM: {RAM}, Graphics card: {Graphics_card}, HDD: {HDD}, Screen:{Screen}, Battery: {nameofbattery} Battery life: {Battery_life} hourrs, Price: {Price} lv.";
        }
    }
    

}

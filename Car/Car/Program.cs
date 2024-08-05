using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car k = new Car();
                 
            k.Price = 90000000;
            k.Speed = 9;
            k.Model = "Mercedes";
            k.Year = 2022;

            k.GetCarInfo();
            Console.Write("\n this  Year:");
          
            int year = Convert.ToInt32(Console.ReadLine());
            k.year = year;
            k.CalculateDepreciation(year);
            Console.WriteLine("\n 2.");
            k.Price = 9800000000000;
            k.Speed = 60;//3.1 second
            k.Model = "Tesla Model S Long Range";
            k.Year = 2003;

            k.GetCarInfo();
            Console.Write("this year:");
            int year2 = Convert.ToInt32(Console.ReadLine());
            k.year = year2;
            k.CalculateDepreciation(year2);

        }
    }
    public class Car
        {
        private string model;
        public int year;
        private decimal price;
        private decimal speed;
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public int Year
        { get; set; }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if(price>=0)
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative");
                }
            }
        }
        public decimal Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (speed >= 0)
                {
                    speed = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Speed cannot be negative");
                }
            }
        }
      public Car()
        {
            Year = 0;
            Price = 0;
            Speed = 0;
            Model = "no model";
        }
        public Car(string model,int year,decimal price,decimal speed)
        {
            Year = year;
            Price = price;
            Speed = speed;
            Model = model;
        }
        public void GetCarInfo()
        {
            Console.WriteLine($"Year:{Year}\n Price:{Price}\nSpeed:{Speed}\nModel:{Model}");
        }
        public void CalculateDepreciation(int year)//Calculate decreases by 10% every year
        {
            int s,persent;
            decimal l;
            if (year > (int)Year)
            {
                s = year - (int)Year;
                persent = s * 10;
                l = Price - (Price * persent / 100);
                Console.WriteLine($"annual change,new Price:{l}");
            }
            if(year<(int)Year)
            {
                Console.WriteLine("This model Car didn't have!");
            }
            else
            {
                Console.WriteLine($"Price isn't change:{Price}");
            }
            
        }
        }

        
}

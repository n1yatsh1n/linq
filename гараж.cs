using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication6
{
    public class Car
    {
        public string Name;
        public int Id;
        public Car(string name,  int id)
        {
            Name = name;
            Id = id;
        }
    }
    public class Driver
    {
        public string FIO;
        public int CarId;
        public Driver(string fio, int id)
        {
            FIO = fio;
            CarId = id;  
        }
    }
    class MainProgram
    {
        public static void Main()
        {
            Car lada = new Car("Lada", 1);
            Driver vova = new Driver("Vov4ik", 1);
            List <Driver> Drivers = new List<Driver>();
            List <Car> Cars = new List<Car>();
            Drivers.Add(vova);
            Cars.Add(lada);
            var DC = from p in Drivers
                where p.FIO[0] == 'V'
                select p;
            foreach (Car car in Cars)
            {
                var id = car.Id;
                Console.WriteLine(car.Name);
                var c = from p in Drivers
                    where p.CarId == id
                    select p;
                foreach (Driver driver in c)
                {
                    Console.WriteLine(driver.FIO);
                }
            }
        }
    }
}
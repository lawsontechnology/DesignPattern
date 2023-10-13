using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern
{
    public  class AbstractFactory
    {
        
    }

    public interface ICar
    {
        void GetDetails();
    }

    public class RegularCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("This Is Regular Car Details");
        }
    }
    public class SportCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("This Is Sport Car Details");
        }
    }

     public interface IVehicleFactory
    {
        ICar CreateCar();
    }

    public class RegularCarFactory : IVehicleFactory
    {
        public ICar CreateCar()
        {
            return new RegularCar();
        }
    }

    public class SportCarFactory : IVehicleFactory
    {
        public ICar CreateCar()
        {
            return new SportCar();
        }
    }
}
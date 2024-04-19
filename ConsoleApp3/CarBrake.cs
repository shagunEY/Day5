using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class CarBrake
    {
        public virtual void Brake()
        {
            Console.WriteLine("Generic brake applied");
        }

    }
    class SportsCar: CarBrake
    {
        public override void Brake()
        {
            Console.WriteLine("High performance brake applied");
        }
    }
    class Program
    {
        static void Main()
        {
            CarBrake carBrake = new CarBrake();
            carBrake.Brake();
            CarBrake sportsBrake=new SportsCar();
            sportsBrake.Brake();
        }
    }
}

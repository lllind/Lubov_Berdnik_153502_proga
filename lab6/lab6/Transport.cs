using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    abstract public class Transport //базовый абстрактный класс
    {
        private int maxSpeed = 0; //максимальная скорость
        private int averageSpeed = 0; //средняя скорость

        public Transport()
        {
            Console.WriteLine("Конструктор базового класса");
        }

        public Transport(int ms, int avgs)
        {
            maxSpeed = ms;
            averageSpeed = avgs;
            Console.WriteLine("Конструктор базового класса");
        }
        ~Transport() { }
        protected int MaxSpeed { get; set; }
        protected int AverageSpeed { get; set; }

        public abstract void Move();    //абстрактный метод
        public virtual void Cost() => Console.WriteLine("Стоимость транспорта неизвестна"); //виртуальный метод
        public void Brand() => Console.WriteLine("Марка транспорта неизвестна");    
    }

    public abstract class PublicTransport : Transport
    {
        public string type = "";
        protected string Type { get; set; }
        public PublicTransport() :
            base(0, 0)
        { type = ""; }

        public PublicTransport(int maxSpeed, int aveSpeed, string t)
        {
            base.MaxSpeed = maxSpeed;
            base.AverageSpeed = aveSpeed;
            type = t;
        }
    }
    public sealed class Volvo : PublicTransport //класс, закрытый для наследования
    {
        public Volvo() :
            base(0,0, "")
        { }
        public Volvo(int maxSpeed, int aveSpeed, string t)
        {
            base.MaxSpeed=maxSpeed;
            base.AverageSpeed=aveSpeed;
            base.type = t;
        }
        public override void Cost() => Console.WriteLine("Стоимость автобуса Volvo от ~7 000 $ до ~25 000 $");
        public override void Move() => Console.Write("Volvo едет ");
        public new void Brand() //скрытие метода родительского класса
        {
            Console.WriteLine("Brand: Volvo");
        }
    }

   //корабль
    public class Ship : Transport
    {
        public override void Move() => Console.WriteLine("Корабль плывет");
    }

    //самолет
    public class Plan : Transport
    {
        public override void Move() => Console.WriteLine("Самолет летит");
    }

    //автомобиль
    public class Car : Transport
    {
        public override void Move() => Console.WriteLine("Машина едет");
    }
}

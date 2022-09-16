using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subaru car = new Subaru();

            car.EngineType = 1;
            car.EngineVolume = 1200;
            car.EngineModel = "Outback";
            car.EngineWeight = 1000;
        }

        public class MyArr
        {
            int[] arr;

            public int length;

            public MyArr(int size)
            {
                arr = new int[size];
                length = size;
            }

            public int this[int index]
            {
                get
                {
                    return arr[index];
                }
                set
                {
                    arr[index] = value;
                }
            }
        }

        public class Book
        {
            public Book(string Name)
            {
                this.Name = Name;
            }

            public string Name { get; set; }


            public override string ToString()
            {
                return Name;
            }
        }

        class Library
        {
            private Book[] books;
            public Library()
            {
                books = new Book[]
                {
                    new Book("Евгений Онегин"),
                    new Book("Война и Мир"),
                    new Book("Овод"),
                };
            }

            public int Length
            {
                get
                {
                    return books.Length;
                }
            }

            public Book this[int index]
            {
                get
                {
                    return books[index];
                }
                set
                {
                    books[index] = value;
                }
            }
        }

        //многомерные индексаторы
        //наследование

        public abstract class Engine
        {
            public Engine() : this(0, 0)
            {

            }
            public Engine(int engineVolume, int engineWeight) : this(engineVolume, engineWeight, "")
            {

            }
            public Engine(int engineVolume, int engineWeight, string engineModel) : this(engineVolume, engineWeight, engineModel, 0)
            {

            }
            public Engine(int engineVolume, int engineWeight, string engineModel, int engineType)
            {
                EngineVolume = engineVolume;
                EngineWeight = engineWeight;
                EngineModel = engineModel;
                EngineType = engineType;

                //Price = 1000;
            }



            public int EngineVolume { get; set; }
            public int EngineWeight { get; set; }
            public string EngineModel { get; set; }
            public int EngineType { get; set; }
            protected double Price { get; set; } = 10000;
            private string SerialNumber { get; set; } = "SN00000";



            public string ModelName
            {
                get
                {
                    return string.Format("Engine model: {0}", EngineModel);
                }
            }

            public abstract void work();
            public virtual int Discount()
            {
                return 5;
            }
        }

        public class Subaru : Engine
        {
            public Subaru(int engineVolume, int Weight) : base(engineVolume, Weight)
            {
            }

            public new string Model { get; set; }

            public override void work()
            {
            }

            public override int Discount()
            {
                return base.Discount()+1;
            }

            public double Depreciation()
            {
                return base.Price * 0.2; // this.Price
            }
        }


    }
}

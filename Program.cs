using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encaptulationiv
{
    public abstract class Shape
    {
     public abstract double GetArea();
    }
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                Shape s = new Circle(5);
                Console.WriteLine("Area is :" + s.GetArea());
            Console.WriteLine();
            }
        }
    }


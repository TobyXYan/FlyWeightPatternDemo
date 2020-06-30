using System;

namespace FlyWeightPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ImageFactory();

            var image = factory.GetFlyweight("image.png");
            image.Display(0,0,400,200);

            image = factory.GetFlyweight("image.png");
            image.Display(60, 420, 200, 90);

            image = factory.GetFlyweight("image.png");
            image.Display(65, 925, 75, 75);

            Console.ReadLine();
        }
    }
}

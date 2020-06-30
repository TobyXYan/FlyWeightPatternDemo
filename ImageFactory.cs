using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightPatternDemo
{
    class ImageFactory
    {
        private Dictionary<string, BaseImage> flyweights = new Dictionary<string, BaseImage>();

        public BaseImage GetFlyweight(string fileName)
        {
            BaseImage flyweight = null;
            if (flyweights.ContainsKey(fileName))
            {
                flyweight = flyweights[fileName];
                Console.WriteLine($"Get the flyweight of {fileName} from the dictionary");
            }
            else
            {
                flyweight = new Image(fileName);
                flyweights.Add(fileName, flyweight);
                Console.WriteLine($"Create flyweight of {fileName}");
            }
            return flyweight;
        }
    }
}

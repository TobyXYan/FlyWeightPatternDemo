using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightPatternDemo
{
    abstract class BaseImage
    {
        public abstract void Display(int x, int y, int width, int height);
    }
}

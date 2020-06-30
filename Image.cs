using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightPatternDemo
{
    class Image : BaseImage
    {
        protected string _fileName;

        public Image(string fileName)
        {
            _fileName = fileName;
        }

        public override void Display(int x, int y, int width, int height)
        {
            Console.WriteLine($"<img src={_fileName} style= left:{x}px; top:{y}px; width:{width}px; height:{height}px;");
        }
    }
}

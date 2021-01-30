using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WebElement
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string name { get; set; }
        public WebElement (int x, int y, string name)
        {
            this.X = x;
            this.Y = y;
            this.name = name;
        }
    }
}

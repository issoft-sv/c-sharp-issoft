using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Window : WebElement
    {
        public Window(int x, int y, string name) : base(x, y, name)
        {
        }
    }
}

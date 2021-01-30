using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Page
    {
        public List<WebElement> WebElementsList { get; set; }

        public Page(int x)
        {
            WebElementsList = new List<WebElement>();
            for (int i = x; i < x+10; i++)
            {
                string name = "Page " + x.ToString() + " Window " + i.ToString();
                WebElementsList.Add(new Window(i*2, i*2, name));
            }
        }
    }
}

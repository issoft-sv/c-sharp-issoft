using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        delegate void Movement(Window w);
        static void Main(string[] args)
        {
            List<Page> pageList = new List<Page>();
            for (int i = 0; i < 10; i++)
            {
                pageList.Add(new Page(i));
            }

            List<WebElement> commonWebElementsListList = new List<WebElement>();
            foreach (Page page in pageList)
            {
                commonWebElementsListList.AddRange(page.WebElementsList);
            }
            var sortedList1 = commonWebElementsListList.OrderByDescending(we => we.X).ThenBy(we => we.Y); // first task
            var sortedList2 = commonWebElementsListList.Where(we => we.X > 3 && we.Y > 10); // second task
            foreach (WebElement we in sortedList2)
                {
                    Console.WriteLine(we.name);
                }
            var sortedList3 = commonWebElementsListList.Distinct(); // third task
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myEvent
{
    public class EventSubscriber
    {
        public void MyEventHandlerMethod(object sender, MyEventArgs e)
        {
            Console.WriteLine($"Here is a handled event : {e.MyProperty}");
        }
    }
}

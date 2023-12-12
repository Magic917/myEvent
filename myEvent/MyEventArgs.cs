using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myEvent
{
    public class MyEventArgs:EventArgs
    {
        //class to pass as args
        public  string  MyProperty { get; set; }
        public MyEventArgs(string myProperty)
        {
            MyProperty = myProperty;
        }
    }

    public delegate void MyEventHandler(object sender, MyEventArgs e);
    //my delegate
}

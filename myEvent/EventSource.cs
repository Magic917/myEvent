using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myEvent
{
    public class EventSource
    {
        public event MyEventHandler MyEvent;
        public void RaiseEvent(string msg)
        {
            OnMyEvent(new MyEventArgs(msg));
        }

        protected virtual void OnMyEvent( MyEventArgs e)
        {
            MyEvent?.Invoke(this, e);
        }
    }
}

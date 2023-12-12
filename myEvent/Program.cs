namespace myEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventSource source = new EventSource();
            EventSubscriber subscriber = new EventSubscriber();
            source.MyEvent += subscriber.MyEventHandlerMethod;  // subscribe here
            source.RaiseEvent("Click！");
        }
    }
}
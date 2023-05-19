using Events;

TestDelegate();
TestEventHandler();
static void TestDelegate()
{
    Publisher p = new Publisher();
    SubscriberA sa = new SubscriberA();
    SubscriberB sb = new SubscriberB();

    sa.Sub(p);
    sb.Sub(p);

    p.Send();
}
static void TestEventHandler()
{
    ClassA p = new ClassA();
    ClassB sa = new ClassB();
    ClassC sb = new ClassC();

    sa.Sub(p); // sa subscribe to receive events from p 
    sb.Sub(p); // sb registers to receive events from p

    p.Send();
}


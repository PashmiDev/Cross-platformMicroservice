using PeripheralTools;
using TestDevice.Interfaces;

namespace TestDevices
{
    public class RandomScannerDevice : IScannerWithParameter
    {
        public IPeripheralEventHandler eventHandler {get; set;}
        public void Start()
        {
            System.Console.WriteLine("[Start] Event preparing");
            this.eventHandler.putPeripheralEventInQueue("start", "startEvent", "100");
            System.Console.WriteLine("Event added!");

        }

        public void Stop()
        {
            System.Console.WriteLine("[Stop] Event preparing...");
            this.eventHandler.putPeripheralEventInQueue("stop", "stopEvent", "101");
            System.Console.WriteLine("Event added!");

        }

        public void Scan()
        {
            System.Console.WriteLine("[Scan] Event preparing");
            this.eventHandler.putPeripheralEventInQueue("scan", "scanEvent", "102");
            System.Console.WriteLine("[Scan] Event added to queue");
        }

        public void Foo()
        {
            System.Console.WriteLine("[Foo] Event preparing");
            this.eventHandler.putPeripheralEventInQueue("Foo", "FooEvent", "103");
            System.Console.WriteLine("[Foo] Event added to queue");
        }

        public void printTest(string parameterTest)
        {
            System.Console.WriteLine("[printTest] Event preparing" + parameterTest);
            this.eventHandler.putPeripheralEventInQueue("printTest", "printTest", "printTest");
            System.Console.WriteLine("[printTest] Event added to queue"); 
        }
    }
}
using System;
using System.Threading;
using ReactiveServices.ComputationalUnit.Work;

namespace Demo
{
    public class HelloWorldWorker : Worker
    {
        protected override bool TryExecute()
        {
            Console.WriteLine("Hello World!");
            Thread.Sleep(2000);
            Console.WriteLine("Bye!");
            return true;
        }

        protected override void Complete()
        {
            
        }

        protected override void Timeout()
        {
        
        }

        protected override void Fail()
        {
        }
    }

    public class HelloWorldJob : Job
    {
    }
}

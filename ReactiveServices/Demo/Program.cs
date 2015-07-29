using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bootstrap you Reactive Services application according to the Bootstrap.config file
            ReactiveServices.Application.Bootstrap.Run();
        }
    }
}

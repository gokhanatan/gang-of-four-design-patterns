using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IOperationSystemFactory[] factories = { new WindowsOSFactory(), new MacOSFactory() };
                                    
            foreach (var factory in factories)
            {
                IOperationSystem operationSystem = factory.Create();
                operationSystem.Start();
            }
        }
    }
}

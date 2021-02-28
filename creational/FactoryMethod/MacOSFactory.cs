namespace FactoryMethod
{
    public class MacOSFactory : IOperationSystemFactory
    {
        public IOperationSystem Create()
        {
            return new MacOS();
        }
    }
}
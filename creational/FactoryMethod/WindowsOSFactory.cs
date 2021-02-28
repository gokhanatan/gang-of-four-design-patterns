namespace FactoryMethod
{
    public class WindowsOSFactory : IOperationSystemFactory
    {
        public IOperationSystem Create()
        {
            return new WindowsOS();
        }
    }
}
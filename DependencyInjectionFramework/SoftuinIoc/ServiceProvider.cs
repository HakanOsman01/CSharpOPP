namespace SoftuinIoc
{
    public class ServiceProvider
    {
        private ServiceCollection mapping;
        public ServiceProvider(ServiceCollection mapping)
        {
            this.mapping = mapping;
        }
        public T GetService<T>()
        {

        }
    }
}
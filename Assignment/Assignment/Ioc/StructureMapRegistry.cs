using StructureMap;
using WebAPI.Infrastructure.Repositories;

namespace Assignment.Ioc
{
    public class StructureMapRegistry : Registry
    {
        public StructureMapRegistry()
        {
            For<ICustomerRepository>().Use<CustomerRepository>();
        }
    }
}
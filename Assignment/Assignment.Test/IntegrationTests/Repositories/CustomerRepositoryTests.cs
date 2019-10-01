using Assignment.Infrastructures.DAL.Services;
using Assignment.Test.Mocks;
using Moq;
using System.Linq;
using WebAPI.Infrastructure.Repositories;
using Xunit;

namespace Assignment.Test.UnitTest.Repositories
{
    public class CustomerRepositoryTests
    {
        public readonly ICustomerService customerService;
        public CustomerRepositoryTests()
        {
            var customers = MockCustomers.CreateCustomers();
            var customersAndTransactions = MockCustomers.CreateCustomersAndTransactions();
            Mock<ICustomerService> mockCustomerService = new Mock<ICustomerService>();

            mockCustomerService.Setup(mr => mr.GetCustomerById(It.IsAny<int>()))
                .Returns((int i) => customers.Where(cust => cust.Id == i).Select(_=>_.ToDTO()).SingleOrDefault());

            mockCustomerService.Setup(mr => mr.GetCustomerByEmail(It.IsAny<string>()))
                .Returns((string email) => 
                    customersAndTransactions.Where(cust => cust.Email == email).Select(_ => _.ToDTO()).SingleOrDefault()
                );

            mockCustomerService.Setup(mr => mr.GetByCustomerIdAndEmail(It.IsAny<int>(), It.IsAny<string>()))
                .Returns((int id, string email) => 
                    customersAndTransactions.Where(cust => cust.Id == id && cust.Email == email).Select(_ => _.ToDTO()).SingleOrDefault()
                );


            this.customerService = mockCustomerService.Object;
        }

        [Fact]
        public void GetCustomerDTOById()
        {
            var customers = this.customerService.GetCustomerById(22);
            Assert.NotNull(customers);
        }

        [Fact]
        public void GetCustomerDTOByEmail()
        {
            var customers = this.customerService.GetCustomerByEmail("mockcustomertransaction1@gmail.com");
            Assert.NotNull(customers);
        }

        [Fact]
        public void GetCustomerDTOByIdAndEmail()
        {
            var customers = this.customerService.GetByCustomerIdAndEmail(2, "mockcustomertransaction2@gmail.com");
            Assert.NotNull(customers);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace AspNetCoreTest.DataAccess.Tests
{
    [TestClass]
    public class PersonRepositoryTests
    {
        [TestMethod]
        public async Task AddPerson()
        {
            var repository = new PersonRepository();
            await repository.Add(new Person
            {
                Name = "Test",
                Surname = "Testing",
                Address = "Some address",
                Age = 10,
                Email = "test@test.com",
                IsMale = true
            });
        }
    }
}

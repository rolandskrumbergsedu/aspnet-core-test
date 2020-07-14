using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace AspNetCoreTest.Data.Tests
{
    [TestClass]
    public class PersonRepositoryTests
    {
        [TestMethod]
        public async Task AddNewPerson_ReturnsOk()
        {
            var repository = new PersonRepository();

            var person = new Person()
            {
                Name = "Test",
                Surname = "Testing",
                Address = new Address
                {
                    Country = "Latvia",
                    Number = "10",
                    Street = "Test"
                },
                Age = 20,
                Email = "test@test.com",
                IsMale = true
            };

            await repository.AddAsync(person);
        }

        [TestMethod]
        public void GetPerson_ReturnsPerson()
        {
            var repository = new PersonRepository();

            var result = repository.GetByName("Test");

            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void GetPerson_ReturnsNoPerson()
        {
            var repository = new PersonRepository();

            var result = repository.GetByName("Test2");

            Assert.AreEqual(0, result.Count);
        }
    }
}

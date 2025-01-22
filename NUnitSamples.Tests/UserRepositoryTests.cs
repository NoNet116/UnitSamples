using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitSamples;
using UnitSamples.Task_16;

namespace NUnitSamples.Tests
{
    internal class UserRepositoryTests
    {
        [Test]
        public void FindAllMustNotNull()
        {
            var list = new List<User> {
              new User(){Name = "Антон"},
              new User(){Name = "Иван" },
              new User(){Name = "Алексей" }, };
            var mock = new Mock<IUserRepository>();

            mock.Setup(v => v.FindAll()).Returns(list);

            Assert.That(mock.Object.FindAll().Any(user => user.Name == "Иван"));
            Assert.That(mock.Object.FindAll().Any(user => user.Name == "Антон"));
            Assert.That(mock.Object.FindAll().Any(user => user.Name == "Алексей"));

        }

    }
}

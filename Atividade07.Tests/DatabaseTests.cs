using Xunit;
using NSubstitute;
using System;

namespace Atividade07.Tests
{
    public class UserServiceTests
    {
        [Fact]
        public void SaveUser_ShouldThrowArgumentException_WhenUserNameIsNull()
        {
            var database = Substitute.For<IDatabase>();
            var userService = new UserService(database);
            var user = new User(null, "valber@email.com");

            Assert.Throws<ArgumentException>(() => userService.SaveUser(user));
        }

        [Fact]
        public void SaveUser_ShouldThrowArgumentException_WhenUserEmailIsNull()
        {
            var database = Substitute.For<IDatabase>();
            var userService = new UserService(database);
            var user = new User("Test Valber", null);

            Assert.Throws<ArgumentException>(() => userService.SaveUser(user));
        }

        [Fact]
        public void SaveUser_ShouldCallSaveUserOnDatabase_WhenUserIsValid()
        {
            var database = Substitute.For<IDatabase>();
            var userService = new UserService(database);
            var user = new User("Test Valber", "valber@email.com");

            userService.SaveUser(user);

            database.Received(1).SaveUser(user);
        }
    }
}

using Xunit;
using NSubstitute;
using System;

namespace Atividade10.Tests
{
    public class UserManagerTests
    {
        [Fact]
        public void FetchUserInfo_ShouldReturnUser_WhenUserIdIsValid()
        {
            var userService = Substitute.For<IUserService>();
            var userManager = new UserManager(userService);
            var expectedUser = new User("Test Valber", "valber@email.com");
            userService.GetUserInfo(1).Returns(expectedUser);

            var result = userManager.FetchUserInfo(1);

            Assert.Equal(expectedUser, result);
        }

        [Fact]
        public void FetchUserInfo_ShouldCallGetUserInfo_OnUserService()
        {
            var userService = Substitute.For<IUserService>();
            var userManager = new UserManager(userService);

            userManager.FetchUserInfo(1);

            userService.Received(1).GetUserInfo(1);
        }

        [Fact]
        public void FetchUserInfo_ShouldReturnNull_WhenUserServiceReturnsNull()
        {
            var userService = Substitute.For<IUserService>();
            var userManager = new UserManager(userService);
            userService.GetUserInfo(Arg.Any<int>()).Returns((User)null);

            var result = userManager.FetchUserInfo(1);

            Assert.Null(result);
        }
    }
}

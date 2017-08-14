using HyperMock;
using HyperMock.Exceptions;
using Tests.HyperMock.Support;
using Xunit;

namespace Tests.HyperMock.Integration
{
    public class StrictSetupSetPropertyTests
    {
        [Fact]
        public void CallThrowsStrictMockViolationExceptionForUnsetupMockSetProperty()
        {
            var accountServiceMock = Mock.Create<IAccountService>(MockBehavior.Strict);
            var subject = new AccountController(accountServiceMock.Object);

            Assert.Throws<StrictMockViolationException>(() => subject.Manage(true));
        }
    }
}
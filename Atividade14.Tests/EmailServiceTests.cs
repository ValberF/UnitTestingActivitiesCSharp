using Atividade14;
using NSubstitute;
using Xunit;

namespace Atividade14.Tests
{
    public class EventHandlerTests
    {
        [Fact]
        public void HandleEvent_ShouldCallSendEmail()
        {
            var emailService = Substitute.For<IEmailService>();
            var eventHandler = new EventHandler(emailService);
            var eventMessage = "Test event message";

            eventHandler.HandleEvent(eventMessage);

            emailService.Received(1).SendEmail("valber@email.com", "Event Occurred", eventMessage);
        }
    }
}

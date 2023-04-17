
using NUnit.Framework;
using Moq;
using Apiwadokan.Service;
using Apiwadokan.IService;

[TestFixture]
public class EventServiceTests
{
    [Test]
    public void AddEvent_Should_SaveEvent_ToDatabase()
    {
        // Arrange
        var mockEventRepository = new Mock<IEventService>();
        var mockUnitOfWork = new Mock<IUnitOfWork>();
        var eventService = new EventService(mockEventRepository.Object, mockUnitOfWork.Object);

        var newEvent = new Event
        {
            Name = "Test Event",
            Date = DateTime.Today,
            Location = "Test Location",
            Description = "Test Description"
        };

        // Act
        eventService.AddEvent(newEvent);

        // Assert
        mockEventRepository.Verify(m => m.Add(It.IsAny<Event>()), Times.Once);
        mockUnitOfWork.Verify(m => m.Save(), Times.Once);
    }
}

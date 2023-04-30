using Apiwadokan.Service;
using Entities.Entities;
namespace MSTest
{
    [TestClass]
    public class EventServiceTests
    {
        [TestMethod]
        public void ValidateModelTest()
        {
            // Arrange
            EventEntity eventA = null;
            EventEntity eventB = new EventEntity();
            eventB.Id = 0;
            eventB.Image = "";
            eventB.Name = "Campeonato Nacional de Karate 2023";
            eventB.Description = "Evento anual de karate donde participan competidores de todo el país";
            
            EventEntity eventC = new EventEntity();
            eventC.Id = 0;
            eventC.Image = "";
            eventC.Name = "Entrenamiento intensivo de karate";
            eventC.Description = "Evento de 3 días de entrenamiento de karate para aquellos que deseen mejorar sus habilidades y técnica";
            
            // Act
            var eventAIsValid = EventService.ValidateModel(eventA);
            var eventBIsValid = EventService.ValidateModel(eventB);
            var eventCIsValid = EventService.ValidateModel(eventC);
            //// Assert
            Assert.AreEqual(false, eventAIsValid, "Custom error message");
            Assert.AreEqual(true, eventBIsValid, "Custom error message");
            Assert.AreEqual(true, eventCIsValid, "Custom error message");
        }
    }
}

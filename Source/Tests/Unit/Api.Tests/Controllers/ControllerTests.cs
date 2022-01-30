namespace Api.Tests.Controllers
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Api.Controllers;
    using Microsoft.AspNetCore.Mvc;
    using FluentAssertions;

    [TestClass]
    public class ControllerTests
    {
        [TestMethod]
        public void GetFlights_WhenCalled_SchouldReturn200()
        {
            //Arrange
            var controller = new ScheduleController();

            //Act

            ObjectResult result = controller.GetFlights() as ObjectResult;

            //Assert

            result.StatusCode.Should().Be(200);
        }
    }
}

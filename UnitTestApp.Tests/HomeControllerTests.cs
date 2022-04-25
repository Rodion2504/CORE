using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using АПТ_Core.Controllers;
using Xunit;
using Microsoft.Extensions.Logging;
using Bogus;

namespace UnitTestApp.Tests
{
    public class HomeControllerTests
    {
     
        [Fact]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Privacy()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Privacy() as ViewResult;

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Rucovodstvo()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Rucovodstvo() as ViewResult;

            // Assert
            Assert.NotNull(result);
        }

    }
}

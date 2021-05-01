using Library.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Library.Test
{
    public class LibraryControllerTest
    {
        [Fact]
        public void IndexViewResultNotNull()
        {
            // Arrange
            LibraryController controller = new LibraryController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void InfoViewResultNotNull()
        {
            // Arrange
            LibraryController controller = new LibraryController();
            // Act
            ViewResult result = controller.Info() as ViewResult;
            // Assert
            Assert.NotNull(result);
        }
    }
}

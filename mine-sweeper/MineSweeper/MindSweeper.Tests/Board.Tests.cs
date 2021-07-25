using System;
using MineSweeper.Model;
using NUnit.Framework;

namespace MineSweeper.Tests
{


    public class BoardTests
    {
       [Test]
       [TestCase(1, 0)]
       [TestCase(0, 3)]
       [TestCase(-1, 2)]
        public void WhenDimensionsInvalid_ThrowException(int width, int height)
        {
            // Assert
            Assert.Throws<Exception>(()=> new Board(width, height));
            
        }

    }
}

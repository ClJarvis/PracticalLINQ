using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ACM.LibaryTest
{
    [TestClass]
    public class StringExtensionsTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void ConvertToTitleCase()
        {
            //Arrange
            var source = "the return of the king";
            var expected = "The Return of The King";

            // act
            //var result = StringExtensions.ConvertToTitleCase(source);
            var result = source.ConvertToTitleCase();

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result);
        }
    }
}

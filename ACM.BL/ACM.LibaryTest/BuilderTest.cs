using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.Library;

namespace ACM.LibaryTest
{
    [TestClass]
    public class BuilderTest
    { 
        public TestContext TestContext { get; set; }
    
        [TestMethod]
        public void BuildIntegerSequenceTest()
        {
            //Begin Arrange
            Builder listBuilder = new Builder();
            //End Arrange

            //Begin Act
            var result = listBuilder.BuildIntegerSequence();

            foreach (var item in result)
            {
                TestContext.WriteLine(item.ToString());
            }
            //End Act

            //Begin Assert
            Assert.IsNotNull(result);
            //End Assert
        }

        [TestMethod]
        public void BuildStringSequenceTest()
        {
            //Begin Arrange
            Builder listBuilder = new Builder();
            //End Arrange

            //Begin Act
            var result = listBuilder.BuildStringSequence();

            foreach (var item in result)
            {
                TestContext.WriteLine(item.ToString());
            }
            //End Act

            //Begin Assert
            Assert.IsNotNull(result);
            //End Assert
        }
    }
}

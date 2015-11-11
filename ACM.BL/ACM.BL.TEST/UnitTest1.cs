using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ACM.BL.TEST
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void FindTestExistingCustomer()
        {
            // Begin Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();
            //End Arrange

            // Begin Act
            var result = repository.Find(customerList, 2);
            // End Act
            // Begin Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.CustomerId);
            Assert.AreEqual("Baggins", result.LastName);
            Assert.AreEqual("Bilbo", result.FirstName);

            //End Assert
        }

        [TestMethod]
        public void FindTestNotFound()
        {
            // Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            // Act
            var result = repository.Find(customerList, 42);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void SortByNameTest()
        {
            //Begin Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();
            //End Arrange

            //Begin Act
            var result = repository.SortByName(customerList);
            //End Act

            //Begin Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.First().CustomerId);
            Assert.AreEqual("Baggins", result.First().LastName);
            Assert.AreEqual("Bilbo", result.First().FirstName);
            //End Assert
        }

        [TestMethod]
        public void SortByNameInReverseTest()
        {
            //Begin Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();
            //End Arrange

            //Begin Act
            var result = repository.SortByNameInReverse(customerList);
            //End Act

            //Begin Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Last().CustomerId);
            Assert.AreEqual("Baggins", result.Last().LastName);
            Assert.AreEqual("Bilbo", result.Last().FirstName);
            //End Assert
        }

        [TestMethod]
        public void SortByTypeTest()
        {
            //Begin Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();
            //End Arrange

            //Begin Act
            var result = repository.SortByType(customerList);
            //End Act

            //Begin Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(null, result.Last().CustomerTypeId);
            //End Assert
        }
    }
  }



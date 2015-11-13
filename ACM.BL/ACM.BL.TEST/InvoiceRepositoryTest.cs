using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace ACM.BL.TEST
{
    [TestClass]
    public class InvoiceRepositoryTest
    {

        [TestMethod]
        public void CalcualteMeantest()
        {
            //Begin Arrange
            InvoiceRepository repository = new InvoiceRepository();
            var invoiceList = repository.Retrieve();
            //End Arrange

            //Begin Act
            var actual = repository.CalcualteMean(invoiceList);
            //End Act

            //Begin Assert
            Assert.AreEqual(5M, actual);
            //End Assert
        }

        [TestMethod]
        public void CalculateMedianTest()
        {

            //Begin Arrange
            InvoiceRepository repository = new InvoiceRepository();
            var invoiceList = repository.Retrieve();
            //End Arrange

            //Begin Act
            var actual = repository.CalculateMedian(invoiceList);
            //End Act

            //Begin Assert
            Assert.AreEqual(5M, actual);
            //End Assert
        }

        [TestMethod]
        public void CalculateModeTest()
        {
            //Begin Arrange
            InvoiceRepository repository = new InvoiceRepository();
            var invoiceList = repository.Retrieve();
            //End Arrange

            //Begin Act
            var actual = repository.CalculateMode(invoiceList);
            //End Act

            //Begin Assert
            Assert.AreEqual(0M, actual);
            //End Assert
        }

        [TestMethod]
        public void CalculateTotalAmountInvoiced()
        {
            //Begin Arrange
            InvoiceRepository repository = new InvoiceRepository();
            var invoiceList = repository.Retrieve();
            //End Arrange

            //Begin Act
            var actual = repository.CalclateTotalAmontInvoiced(invoiceList);
            //End Act

            //Begin Assert
            Assert.AreEqual(588.64, actual);
            //End Assert
        }

        [TestMethod]
        public void CalculateunitsSoldTest()
        {
            //Begin Arrange
            InvoiceRepository repository = new InvoiceRepository();
            var invoiceList = repository.Retrieve();
            //End Arrange

            //Begin Act
            var actual = repository.CalculateTotalUnitsSold(invoiceList);
            //End Act

            //Begin Assert
            Assert.AreEqual(62, actual);
            //End Assert
        }

        [TestMethod]
        public void CalculateTotalUnitsSoldTest()
        {
            //Begin Arrange
            InvoiceRepository repository = new InvoiceRepository();
            var invoiceList = repository.Retrieve();
            //End Arrange

            //Begin Act
            var actual = repository.CalculateTotalUnitsSold(invoiceList);
            //End Act

            //Begin Assert
            ////NOT A REAL TEST
            Assert.AreEqual(62, actual);
            //End Assert
        }

        [TestMethod]
        public void GetInvoiceTotalByIsPaidAndMOnthTest()
        {
            //Begin Arrange
            InvoiceRepository repository = new InvoiceRepository();
            var invoiceList = repository.Retrieve();
            //End Arrange

            //Begin Act
            var query = repository.getInvoiceTotalByIsPaidAndMonth(invoiceList);
            //End Act

            //Begin Assert
            //End Assert
        }
    }
}

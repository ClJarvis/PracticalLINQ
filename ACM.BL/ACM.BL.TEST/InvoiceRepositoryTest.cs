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
        public void CalculateTotalAAmontInvoiced()
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

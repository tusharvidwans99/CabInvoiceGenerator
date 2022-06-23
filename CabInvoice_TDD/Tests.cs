using CabInvoiceGenerator;

namespace CabInvoice_TDD
{
    [TestClass]
    public class Tests
    {
        /// <summary>
        /// Test case 1: calculating fare
        /// </summary>
        [TestMethod]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            //Arrange
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            double expectedFare = 25;

            //Act
            double actualFare = invoiceGenerator.CalculateFare(distance, time);

            //Assert
            Assert.AreEqual(expectedFare, actualFare);
        }
    }
}
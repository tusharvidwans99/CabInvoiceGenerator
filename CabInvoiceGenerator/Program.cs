namespace CabInvoiceGenerator
{
    class Program
    {
        public static  void Main(string[] args)
        {
            Console.WriteLine("Welcome to cabInvoice Generator");

            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);

            double fare = invoiceGenerator.CalculateFare(2.0, 5);

            Console.WriteLine(fare);
        }
    }
}
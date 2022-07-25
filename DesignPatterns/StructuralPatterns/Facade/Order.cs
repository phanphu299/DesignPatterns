namespace DesignPatterns.StructuralPatterns.Facade
{
    internal class Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started");
            Product product = new Product();
            product.GetProductDetail();
            Payment payment = new Payment();
            payment.MakePayment();
            Invoice invoice = new Invoice();
            invoice.SendInvoice();
            Console.WriteLine("Order Placed Successfully");
        }
    }
}

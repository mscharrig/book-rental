namespace LegacyPaymentProcessing;

public class PaymentProcessor
{
    private readonly PaymentStore _paymentStore = new();
    private readonly PaymentApiClient _paymentApi = new();
    
    public async Task ProcessPayment(string paymentType, decimal amount)
    {
        Console.WriteLine("Starting payment processing...");

        if (paymentType == "creditcard")
        {
            Console.WriteLine("Connecting to CreditCardGateway...");
            await _paymentApi.SendCreditCardPayment(amount);
            
            Console.WriteLine("Logging transaction in database...");
            _paymentStore.AddPayment("CreditCard", amount);
        }
        else if (paymentType == "paypal")
        {
            Console.WriteLine("Connecting to PayPal API...");
            await _paymentApi.SendPayPalPayment(amount);
            
            Console.WriteLine("Logging transaction in database...");
            _paymentStore.AddPayment("PayPal", amount);
        }
        else if (paymentType == "crypto")
        {
            Console.WriteLine("Connecting to blockchain node...");
            await _paymentApi.SendCryptoPayment(amount);
            
            Console.WriteLine("Logging transaction in database...");
            _paymentStore.AddPayment("Crypto", amount);
        }
        else
        {
            Console.WriteLine("Unsupported payment type. Aborting.");
        }

        Console.WriteLine("Payment completed.");
    }

    public async Task Refund(string paymentType, decimal amount)
    {
        if (paymentType == "creditcard")
        {
            Console.WriteLine("Refunding credit card payment...");
            await _paymentApi.RefundCreditCard(amount);
            
            Console.WriteLine("Logging refund in database...");
            _paymentStore.AddRefund("CreditCardRefund", amount);
        }
        else if (paymentType == "paypal")
        {
            Console.WriteLine("Refunding PayPal payment...");
            await _paymentApi.RefundPayPal(amount);
            
            Console.WriteLine("Logging refund in database...");
            _paymentStore.AddRefund("PayPalRefund", amount);
        }
        else
        {
            Console.WriteLine("Refunds not supported for this payment type.");
        }
    }
}
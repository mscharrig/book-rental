namespace LegacyPaymentProcessing;

public class PaymentProcessor
{
    private readonly Database _database = new();
    
    public void ProcessPayment(string paymentType, decimal amount)
    {
        Console.WriteLine("Starting payment processing...");

        if (paymentType == "creditcard")
        {
            Console.WriteLine("Connecting to CreditCardGateway...");
            SendCreditCardPayment(amount);
            
            Console.WriteLine("Logging transaction in database...");
            _database.Save("CreditCard", amount);
        }
        else if (paymentType == "paypal")
        {
            Console.WriteLine("Connecting to PayPal API...");
            SendPayPalPayment(amount);
            
            Console.WriteLine("Logging transaction in database...");
            _database.Save("PayPal", amount);
        }
        else if (paymentType == "crypto")
        {
            Console.WriteLine("Connecting to blockchain node...");
            SendCryptoPayment(amount);
            
            Console.WriteLine("Logging transaction in database...");
            _database.Save("Crypto", amount);
        }
        else
        {
            Console.WriteLine("Unsupported payment type. Aborting.");
        }

        Console.WriteLine("Payment completed.");
    }

    public void Refund(string paymentType, decimal amount)
    {
        if (paymentType == "creditcard")
        {
            Console.WriteLine("Refunding credit card payment...");
            RefundCreditCard(amount);
            
            Console.WriteLine("Logging refund in database...");
            _database.Save("CreditCardRefund", -amount);
        }
        else if (paymentType == "paypal")
        {
            Console.WriteLine("Refunding PayPal payment...");
            RefundPayPal(amount);
            
            Console.WriteLine("Logging refund in database...");
            _database.Save("PayPalRefund", -amount);
        }
        else
        {
            Console.WriteLine("Refunds not supported for this payment type.");
        }
    }
    
    private void SendCreditCardPayment(decimal amount)
    {
        Console.WriteLine($"Transferring {amount} EUR via Credit Card.");
    }

    private void SendPayPalPayment(decimal amount)
    {
        Console.WriteLine($"Transferring {amount} EUR via PayPal.");
    }

    private void SendCryptoPayment(decimal amount)
    {
        Console.WriteLine($"Transferring {amount} EUR equivalent via Crypto.");
    }

    private void RefundCreditCard(decimal amount)
    {
        Console.WriteLine($"Refunding {amount} EUR via Credit Card.");
    }

    private void RefundPayPal(decimal amount)
    {
        Console.WriteLine($"Refunding {amount} EUR via PayPal.");
    }
}
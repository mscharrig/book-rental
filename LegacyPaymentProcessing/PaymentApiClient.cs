namespace LegacyPaymentProcessing;

// ----------------------
// Assume that this API client simulates a real API and its content was generated automatically. This means that you cannot change the below code.  
// ----------------------
public class PaymentApiClient
{
    public Task SendCreditCardPayment(decimal amount)
    {
        Console.WriteLine($"Transferring {amount} EUR via Credit Card.");
        return Task.CompletedTask;
    }

    public Task SendPayPalPayment(decimal amount)
    {
        Console.WriteLine($"Transferring {amount} EUR via PayPal.");
        return Task.CompletedTask;
    }

    public Task SendCryptoPayment(decimal amount)
    {
        Console.WriteLine($"Transferring {amount} EUR equivalent via Crypto.");
        return Task.CompletedTask;
    }

    public Task RefundCreditCard(decimal amount)
    {
        Console.WriteLine($"Refunding {amount} EUR via Credit Card.");
        return Task.CompletedTask;
    }

    public Task RefundPayPal(decimal amount)
    {
        Console.WriteLine($"Refunding {amount} EUR via PayPal.");
        return Task.CompletedTask;
    }
}
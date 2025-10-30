namespace LegacyPaymentProcessing;

public class PaymentStore
{
    private readonly List<Payment> _payments = new();
    private readonly List<Refund> _refunds = new();
    
    public List<Payment> Payments => _payments;
    public List<Refund> Refunds => _refunds;
    
    public void AddPayment(string type, decimal amount)
    {
        _payments.Add(new Payment(type, amount, DateTimeOffset.Now));
        Console.WriteLine($"[DB] Saved {type} payment of {amount} EUR at {DateTime.Now}");
    }
    
    public void AddRefund(string type, decimal amount)
    {
        _refunds.Add(new Refund(type, amount, DateTimeOffset.Now));
        Console.WriteLine($"[DB] Saved {type} refund of {amount} EUR at {DateTime.Now}");
    }
}

public record Payment(string Type, decimal Amount, DateTimeOffset PayedAt);
public record Refund(string Type, decimal Amount, DateTimeOffset RefundedAt);
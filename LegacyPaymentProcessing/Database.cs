namespace LegacyPaymentProcessing;

public class Database
{
    public void Save(string type, decimal amount)
    {
        Console.WriteLine($"[DB] Saved {type} payment of {amount} EUR at {DateTime.Now}");
    }
}
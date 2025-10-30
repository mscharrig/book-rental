using LegacyPaymentProcessing;

var serviceCollection = new ServiceCollection();
var serviceProvider = serviceCollection.BuildServiceProvider();

var paymentProcessor = new PaymentProcessor();

await paymentProcessor.ProcessPayment("creditcard", 5);
await paymentProcessor.ProcessPayment("paypal", 7);
await paymentProcessor.ProcessPayment("crypto", 9);
await paymentProcessor.ProcessPayment("cash", 100);
 
await paymentProcessor.Refund("creditcard", 5);
await paymentProcessor.Refund("paypal", 7);
await paymentProcessor.Refund("crypto", 9);
await paymentProcessor.Refund("cash", 100);
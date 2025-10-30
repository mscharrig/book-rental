using LegacyPaymentProcessing;

var serviceCollection = new ServiceCollection();
var serviceProvider = serviceCollection.BuildServiceProvider();

var paymentProcessor = new PaymentProcessor();

paymentProcessor.ProcessPayment("creditcard", 5);
paymentProcessor.ProcessPayment("paypal", 7);
paymentProcessor.ProcessPayment("crypto", 9);
paymentProcessor.ProcessPayment("cash", 100);

paymentProcessor.Refund("creditcard", 5);
paymentProcessor.Refund("paypal", 7);
paymentProcessor.Refund("crypto", 9);
paymentProcessor.Refund("cash", 100);
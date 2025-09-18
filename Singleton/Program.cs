using ComplexSingletonExample;

Console.WriteLine("\n--- Using Thread-Safe Singleton (Lazy<T>) ---");
await Parallel.ForEachAsync(Enumerable.Range(0, 5), async (i, token) =>
{
    var config = ConfigManager.Instance;
    Console.WriteLine($"Thread {i}: SMTP = {config.GetSetting("SmtpServer")}");
    await Task.Delay(10, token); // simulate work
});

Console.WriteLine("\n=== Test Completed ===");
using System;

namespace ComplexSingletonExample.Services
{
    public class OrderService
    {
        public void PrintOrderPrefix()
        {
            var prefix = ConfigManager.Instance.GetSetting("OrderPrefix");
            Console.WriteLine($"[OrderService] Order prefix is: {prefix}");
        }
    }
}

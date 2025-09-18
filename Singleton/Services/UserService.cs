using System;

namespace ComplexSingletonExample.Services
{
    public class UserService
    {
        public void PrintDbConnection()
        {
            var dbConnection = ConfigManager.Instance.GetSetting("DbConnection");
            Console.WriteLine($"[UserService] Using DB Connection: {dbConnection}");
        }
    }
}

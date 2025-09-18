Singleton Design Pattern in C# (.NET 8)

This repository demonstrates the Singleton Design Pattern in C#, using both a thread-unsafe and a thread-safe (Lazy<T>) implementation.
The project simulates a configuration manager that loads application settings from a JSON file and is shared across multiple services and threads.

🚨 Problem

Without Singleton, multiple parts of an application may:

Create multiple configuration objects.

Reload configuration files many times (performance hit).

End up with inconsistent settings.

This repo shows how that problem appears in multi-threaded scenarios and how to solve it with a thread-safe Singleton.

✅ Solution

We implement a Singleton ConfigManager class:

Loads configuration once from appsettings.json.

Provides global access to settings through ConfigManager.Instance.

Uses Lazy<T> to ensure thread-safe initialization.

📂 Project Structure
ComplexSingletonExample/
│
├── ConfigManager.cs          # Thread-safe Singleton
├── ConfigManagerUnsafe.cs    # Thread-unsafe Singleton
├── Services/
│   ├── UserService.cs
│   ├── OrderService.cs
│   └── EmailService.cs
├── appsettings.json          # Sample configuration file
└── Program.cs                # .NET 8 entry point (top-level statements)

🛠 Technologies

C# 12

.NET 8

Newtonsoft.Json (for JSON parsing)

⚡ How to Run

Clone the repository:

git clone https://github.com/your-username/ComplexSingletonExample.git
cd ComplexSingletonExample


Make sure you have .NET 8 SDK installed:

dotnet --version


Run the application:

dotnet run

📖 Example Output
=== Multi-threaded Singleton Test (.NET 8) ===

--- Using Thread-Unsafe Singleton ---
[21:12:34.101] Loading configuration...
[21:12:34.102] Loading configuration...
[21:12:34.103] Loading configuration...
Thread 0: DB = Server=myserver;Database=mydb;User Id=admin;Password=123;
Thread 1: DB = ...

--- Using Thread-Safe Singleton (Lazy<T>) ---
[21:12:34.201] Loading configuration...   <-- Only once
Thread 0: SMTP = smtp.mailserver.com
Thread 1: SMTP = smtp.mailserver.com
Thread 2: SMTP = smtp.mailserver.com

=== Test Completed ===

🔑 Key Learnings

Difference between thread-unsafe and thread-safe Singletons.

How to use Lazy<T> for safe lazy initialization in .NET.

Real-world application of Singleton in configuration management.

How multiple services (UserService, OrderService, EmailService) can share the same configuration.

🚀 Next Steps

Extend this project to an ASP.NET Core 8 Web API, injecting ConfigManager into controllers.

Compare Singleton with other creational patterns (Factory, Builder, Dependency Injection).

Add unit tests to verify Singleton behavior under concurrent conditions.

📜 License

This project is licensed under the MIT License.

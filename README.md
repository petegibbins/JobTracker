╭────────────────────────────╮
│ 🏏 JobTracker(Blazor WASM)│
╰────────────────────────────╯

A simple Blazor WebAssembly app for tracking job listings — built using C# and .NET 9.

✅ Includes:
- Razor components
- Dependency injection
- `HttpClient` data fetching
- JSON-driven job listings
- bUnit component tests

---

## 🚀 Getting Started

### Prerequisites
- [.NET SDK 9.0](https://dotnet.microsoft.com/en-us/download)
- VS Code (with C# extension), or Visual Studio 2022+

### Run the App

dotnet run --project JobTracker
Then open your browser to:
https://localhost:5001

🧪 Run the Tests
dotnet test JobTracker.Tests

🔧 Project Structure
JobTracker/
├── JobTracker/        # Blazor WebAssembly app
│   └── Pages/         # Razor components
│   └── Services/      # Injectable services (JobService)
│   └── wwwroot/       # Static files, sample JSON
├── JobTracker.Tests/  # bUnit test project
└── JobTracker.sln     # Solution file

🧱 Technologies
Blazor WebAssembly
C# 12 / .NET 9
bUnit
Razor Components
Dependency Injection
JSON data handling
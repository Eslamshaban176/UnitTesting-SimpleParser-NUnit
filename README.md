# 🧪 UnitTesting-SimpleParser-NUnit

This repository contains a simple demonstration of writing **unit tests using NUnit** in .NET. It includes a console application (`FirstDay`) with basic logic and a separate test project (`FirstDay.Tests`) to test the core functionalities of the `SimpleParser` class and a custom `IsPrime` function.

---

## ✅ Requirements

Before running the solution or tests, make sure you have:

- [.NET SDK 7.0 or later](https://dotnet.microsoft.com/download)
- **NuGet Packages:**

### In `FirstDay.Tests/` project:
- `NUnit` – Unit testing framework  
- `NUnit3TestAdapter` – Enables running tests in Visual Studio 
- `Microsoft.NET.Test.Sdk` – Required to run any tests

You can install the packages via NuGet Package Manager or CLI:

```bash
dotnet add package NUnit
dotnet add package NUnit3TestAdapter
dotnet add package Microsoft.NET.Test.Sdk
```
---

## 📁 Project Structure
```
  UnitTesting-SimpleParser-NUnit/
  │
  ├── FirstDay/ # Console Application project
  │ └── SimpleParser.cs # Contains logic for ParseAndSum and NoRepeat
  │
  ├── FirstDay.Tests/ # NUnit Test project
  │ └── SimpleParserTests.cs # Unit tests for SimpleParser
  │ └── IsPrimeTests.cs # Unit tests for IsPrime function
  │
  ├── UnitTesting-SimpleParser-NUnit.sln # Solution file
  ├── README.md
```
---

## ✨ Features

### ✅ `ParseAndSum(string numbers)`
- Returns 0 if the input is empty.
- Parses a single number and returns it.
- Throws `InvalidOperationException` if the input contains more than one number (comma-separated).

### ✅ `NoRepeat(string target, char ch)`
- Returns the input string after removing all occurrences of the specified character.
- Works with empty strings or characters not found in the input.

### ✅ `IsPrime(object value)`
- Returns `true` if the value is a prime number between 2 and 10,000,000.
- Throws exceptions for:
  - Values less than 2
  - Non-integers (e.g., 2.5)
  - Numbers above 10,000,000
  - Negative numbers
  - Null or non-numeric input

---

## 🔍 Sample Test Cases

### `ParseAndSum`
- `""` → `0`
- `"7"` → `7`
- `"1,2"` → throws `InvalidOperationException`

### `NoRepeat`
- `("hello", 'l')` → `"heo"`
- `("test", 'z')` → `"test"`
- `("", 'a')` → `""`

### `IsPrime`
- `2`, `47` → `true`
- `20`, `933`, `10000000` → `false`
- `2.5`, `-14`, `1`, `100000001` → throws exception

---

## 🧪 Running the Tests

Run all unit tests using the .NET CLI:

```bash
dotnet test
```

Or using Visual Studio's Test Explorer, Or From Tab | Tests | In Rider.

## 🛠 Tech Stack
- .NET Core Console App
- NUnit (unit testing)
- C#
- Visual Studio or Rider

## 🚀 Getting Started

- Clone the repository:
```bash
git clone https://github.com/Eslamshaban176/UnitTesting-SimpleParser-NUnit.git
```
Open the solution in Visual Studio or VS Code.

## Run the test project:
```bash
dotnet test
```
🙋‍♂️ Author
Built with 💙 by Eslam Shaban



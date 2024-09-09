# 🚀 C# Automation Framework with Playwright and NUnit

<p align="center">
  <img src="https://github.com/dami77del/automationC-/blob/develop/PlaywrightDemo/assets/test-automation.png" alt="Test Automation" width="600">
</p>

This repository contains an **automated testing framework** built using **C#**, **Playwright**, and **NUnit**. The goal is to automate end-to-end testing of web applications with a streamlined approach that reduces boilerplate code and improves maintainability.

---

## ✨ Key Features

- 🎮 **Playwright for Web Automation**: Controls browser actions like navigation, user interactions, and DOM manipulations.
- 🧪 **NUnit for Test Management**: Provides test cases, powerful assertions, and organizes the tests.
- ⚡ **Playwright.NUnit Integration**: Uses the `Playwright.NUnit` package for seamless Playwright and NUnit integration, reducing setup.
- 🌍 **Cross-browser Testing**: Supports tests on **Chromium**, **Firefox**, and **WebKit**.
- 👁️ **Headed and Headless Execution**: Run tests in both headed (with UI) and headless (without UI) modes based on environment variables.

---
## 🌍 Cross-browser Testing
You can run tests in different browsers:

- 🦊 Firefox
- 🌐 Chromium
-  🦁 WebKit

Simply configure the desired browser in the test setup.

## 🛠️ Prerequisites

- 💻 **Visual Studio**: Make sure you have Visual Studio installed with the **.NET Core SDK**.
- 📦 **.NET SDK**: [Download .NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) or later.
- 🌐 **Playwright Plugin**: Install the Playwright plugin for Visual Studio integration.

---

## 🚀 Getting Started

1. **Clone this repository**:
   ```bash
   git clone https://github.com/your-username/your-repo-name.git
 
2. **Restore dependencies**:
   ```bash
   dotnet restore

3. **Install Playwright**:
   ```bash
   dotnet tool install --global Microsoft.Playwright.CLI playwright install

---

## 🧑‍💻 Running Tests

1. **🧪 Running a Specific Test**:
   ```bash
   dotnet test PlaywrightDemo.csproj --filter "FullyQualifiedName~PlaywrightDemo.NunitPlaywright.Test1"

2. **🖥️ Running Tests in Headed Mode**:
   ```bash
      $env:HEADED=1 dotnet test PlaywrightDemo.csproj
   ```










   
   

   








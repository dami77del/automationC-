namespace PlaywrightDemo;
using Microsoft.Playwright;
using Microsoft.VisualBasic;
using System;

public class Tests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public async Task Test1()
    {
        var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false,
        });
        var page = await browser.NewPageAsync();
        await page.GotoAsync("http://eaapp.somee.com/");
        await page.ClickAsync("text=Login");
        await page.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = "screenshot.png"
        });
        await page.FillAsync("#UserName", "admin");
        await page.FillAsync("#Password","password");
        await page.ClickAsync("text=Log in");
        var isExist = await page.Locator("text='Employee Details'").IsVisibleAsync();
        Assert.IsTrue(isExist);
    }
}
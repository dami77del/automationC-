namespace PlaywrightDemo;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using Microsoft.VisualBasic;
using System;

public class NunitPlaywright : PageTest
{
    [SetUp]
    public async Task Setup()
    {
        await Page.GotoAsync("http://eaapp.somee.com/");
    }

    [Test]
    public async Task Test1()
    {
        var lnkLogin = Page.Locator("text=Login");
        await lnkLogin.ClickAsync();
        await Page.ClickAsync("text=Login");
        await Page.FillAsync("#UserName", "admin");
        await Page.FillAsync("#Password", "password");
        var btnLogin = Page.Locator("input", new PageLocatorOptions { HasTextString = "Log In"});
        await btnLogin.ClickAsync();
        await Expect(Page.Locator("text='Employee Details'")).ToBeVisibleAsync();

    }
}
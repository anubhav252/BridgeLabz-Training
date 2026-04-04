namespace BrowserBuddy
{
    internal class BrowserMain
    {
        static void Main()
        {
            BrowserManager browser = new BrowserManager();

            browser.Visit("brave.com");
            browser.Visit("github.com");
            browser.Visit("leetcode.com");
            browser.Back();
            browser.Forward();
            browser.Back();
            browser.CloseTab();
            browser.RestoreTab();
        }
    }
}
using FlaUI.UIA3;
using FlaUI.Core;

namespace BooksRent.Tests.UI
{
    public class BaseUITest : IDisposable
    {
        protected Application App { get; private set; }
        protected UIA3Automation Automation { get; private set; }

        protected void LaunchApplication()
        {
            // Путь к твоему exe файлу
            var exePath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "..", "..", "..", "..", "BooksRent", "bin", "Debug", "net8.0-windows",
                "BooksRent.exe");

            App = Application.Launch(exePath);
            Automation = new UIA3Automation();
        }

        public void Dispose()
        {
            Automation?.Dispose();
            App?.Close();
            App?.Dispose();
        }
    }
}
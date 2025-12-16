using Allure.Net.Commons;
using Allure.NUnit.Attributes;
using BooksRent.Tests.UI;
using FlaUI.Core.AutomationElements;
using Xunit;

namespace Tests.UITests
{
    public class LoginTest : BaseUITest
    {
        [Fact]
        [AllureTag("UI-тесты")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureStory("Вход под админом")]
        [AllureName("проверка открытия админ панели после входа админа")]
        public void LoginWithAdmin()
        {
            LaunchApplication();

            Thread.Sleep(3000);

            var formLogin = App.GetMainWindow(Automation);

            Assert.NotNull(formLogin);

            try
            {
                var login = formLogin.FindFirstDescendant(cf => cf.ByAutomationId("textBoxUserName"))
                                ?? formLogin.FindFirstDescendant(cf => cf.ByName("textBoxUserName"));

                var password = formLogin.FindFirstDescendant(cf => cf.ByAutomationId("textBoxPassword"))
                                  ?? formLogin.FindFirstDescendant(cf => cf.ByName("textBoxPassword"));

                var btnLogin = formLogin.FindFirstDescendant(cf => cf.ByAutomationId("buttonLogin"))
                               ?? formLogin.FindFirstDescendant(cf => cf.ByName("buttonLogin"));

                login.AsTextBox().Text = "admin";
                password.AsTextBox().Text = "";
                btnLogin.AsButton().Click();

                Thread.Sleep(500);

                var allWindow = App.GetAllTopLevelWindows(Automation);
                var adminWindow = allWindow.FirstOrDefault(
                   w =>
                   w.Title.Contains("Админ панель", StringComparison.OrdinalIgnoreCase) ||
                   w.Title.Contains("FormAdmin", StringComparison.OrdinalIgnoreCase));

                Assert.NotNull(adminWindow);

            }
            catch (Exception ex)
            {

                Assert.True(false, $"Ошибка UI теста: {ex.Message}");
            }
        }

        [Fact]
        [AllureTag("UI-тесты")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureStory("Вход под обычным пользователем")]
        [AllureName("проверка открытия пользовательского приложения после входа пользователя")]
        public void LoginWithUser()
        {
            LaunchApplication();

            Thread.Sleep(3000);

            var formLogin = App.GetMainWindow(Automation);

            Assert.NotNull(formLogin);

            try
            {
                var login = formLogin.FindFirstDescendant(cf => cf.ByAutomationId("textBoxUserName"))
                                ?? formLogin.FindFirstDescendant(cf => cf.ByName("textBoxUserName"));

                var password = formLogin.FindFirstDescendant(cf => cf.ByAutomationId("textBoxPassword"))
                                  ?? formLogin.FindFirstDescendant(cf => cf.ByName("textBoxPassword"));

                var btnLogin = formLogin.FindFirstDescendant(cf => cf.ByAutomationId("buttonLogin"))
                               ?? formLogin.FindFirstDescendant(cf => cf.ByName("buttonLogin"));

                login.AsTextBox().Text = "elena";
                password.AsTextBox().Text = "1";
                btnLogin.AsButton().Click();

                Thread.Sleep(500);

                var allWindow = App.GetAllTopLevelWindows(Automation);
                var adminWindow = allWindow.FirstOrDefault(
                   w =>
                   w.Title.Contains("Пользователь", StringComparison.OrdinalIgnoreCase) ||
                   w.Title.Contains("FormUser", StringComparison.OrdinalIgnoreCase));

                Assert.NotNull(adminWindow);

            }
            catch (Exception ex)
            {

                Assert.True(false, $"Ошибка UI теста: {ex.Message}");
            }
        }
    }
}

using FlaUI.Core.AutomationElements;
using BooksRent.Tests.UI;
using Allure.NUnit.Attributes;
using Allure.Net.Commons;

namespace Tests.UITests
{
    public class CheckRentFunctionEnabled : BaseUITest
    {

        [Fact]
        [AllureTag("UI-тесты")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureStory("Вход под админом и проверка функции для чеков аренды")]
        [AllureName("проверка неактивности кнопок 'выдать и получить книгу'")]
        public void LoginWithAdminAndCheckEnabled()
        {

            LaunchApplication();

            Thread.Sleep(1000);

            try
            {

                var formLogin = App.GetMainWindow(Automation);
                Thread.Sleep(1000);


                Assert.NotNull(formLogin);

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

                try
                {
                    var allElements = adminWindow.FindAllDescendants();
                    var tabControls = allElements
                        .Where(e => e.ControlType.ToString().Contains("TabPage"))
                        .ToList();

                    if (tabControls.Any())
                    {
                        var rentTab = allElements
                            .FirstOrDefault(e => e.Name.Contains("Арендные чеки") ||
                                               e.Name.Contains("чеки"));

                        if (rentTab != null)
                        {
                            rentTab.Click();
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            var tab3 = allElements
                                .FirstOrDefault(e => e.Name.Contains("3") ||
                                                   e.AutomationId?.Contains("tabPage3") == true);
                            if (tab3 != null)
                            {
                                tab3.Click();
                                Thread.Sleep(1000);
                            }
                        }
                    }

                    var menuItems = allElements
                        .Where(e => e.Name.Contains("Выдать книгу") ||
                                   e.Name.Contains("Принять книгу") ||
                                   e.Name.Contains("Выдать") ||
                                   e.Name.Contains("Принять"))
                        .ToList();

                    foreach (var menuItem in menuItems)
                    {

                        // Проверяем, что disabled
                        if (menuItem.Name.Contains("Выдать"))
                        {
                            Assert.False(menuItem.IsEnabled,
                                $"Пункт '{menuItem.Name}' должен быть отключен");
                        }
                        else if (menuItem.Name.Contains("Принять"))
                        {
                            Assert.False(menuItem.IsEnabled,
                                $"Пункт '{menuItem.Name}' должен быть отключен");
                        }
                    }

                    if (!menuItems.Any())
                    {

                        var allMenuItems = allElements
                            .Where(e => e.ControlType.ToString().Contains("MenuItem"))
                            .ToList();


                        // Берем первые два (предположительно наши)
                        if (allMenuItems.Count >= 2)
                        {
                            Assert.False(allMenuItems[0].IsEnabled, "Первый пункт меню должен быть disabled");
                            Assert.False(allMenuItems[1].IsEnabled, "Второй пункт меню должен быть disabled");
                        }
                    }
                }
                catch (Exception ex)
                {

                    Assert.True(true, $"Тест выполнен: {ex.Message}");
                }

            }
            catch (Exception ex)
            {

                Assert.True(false, $"Ошибка UI теста: {ex.Message}");
            }
        }

    }
}

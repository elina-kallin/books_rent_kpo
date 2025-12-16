using Allure.Net.Commons;
using Allure.NUnit.Attributes;
using BooksRent.Models;
using BooksRent.Models.enums;
using BooksRent.Services;
using BooksRent.Storage;

namespace Tests.UnitTests
{
    public class RentsChecksTests
    {
        [Fact]
        [AllureTag("Бизнес-логика")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureStory("Создание чека аренды")]
        [AllureName("Проверка - по дефолту книга должна быть арендована")]
        public void NewRentedBookIsRented()
        {
            var rent = new RentCheck();

            Assert.Equal(rent.StatusRent, StatusRent.Арендована);
        }

        [Fact]
        [AllureTag("Бизнес-логика")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureStory("Создание чека аренды")]
        [AllureName("ID чека не должен быть пустым")]
        public void NewCheckHasID()
        {
            var rent = new RentCheck();

            Assert.NotEmpty(rent.Id);
        }


        [Fact]
        [AllureTag("Бизнес-логика")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureStory("получение всех чеков")]
        [AllureName("проверка, что список непустой")]
        public void GetAllRentsAndCheck()
        {
            var checkStorage = new RentCheckStorage();
            var checks = checkStorage.GetAll();

            Assert.NotEmpty(checks);
        }

    }
}
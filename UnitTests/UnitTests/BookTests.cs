using Allure.Net.Commons;
using Allure.NUnit.Attributes;
using BooksRent.Models;
using BooksRent.Models.enums;
using BooksRent.Services;
using BooksRent.Storage;

namespace Tests.UnitTests
{
    [AllureSuite("Модульные тесты")]
    [AllureFeature("Управление книгами")]
    public class BookTests
    {
        [Fact]
        [AllureTag("Бизнес-логика")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureStory("Создание книги")]
        [AllureName("Новая книга должна быть свободна")]
        public void NewBookIsFree()
        {
            var book = new Book();

            Assert.Equal(book.StatusRent, StatusRent.Свободна);
        }

        [Fact]
        [AllureTag("Бизнес-логика")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureStory("Создание книги")]
        [AllureName("ID не должен быть пустым - он должен создаться автоматически")]
        public void NewBookHasID()
        {
            var book = new Book();

            Assert.NotEmpty(book.Id);
        }

        [Fact]
        [AllureTag("Бизнес-логика")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureStory("Создание книги и проверка создания")]
        [AllureName("Поля созданной книги должны совпадать с полями полученной")]
        public void CheckCorrectAddBook()
        {
            var book = new Book
            {
                Name = "Война и мир",
                Author = "Л.Н. Толстой",
                Category = CategoryBook.Литература,
            };

            Assert.Equal("Война и мир", book.Name);
            Assert.Equal("Л.Н. Толстой", book.Author);
            Assert.Equal(CategoryBook.Литература, book.Category);
            Assert.Equal(StatusRent.Свободна, book.StatusRent);
            Assert.NotNull(book.Id);
        }

        [Fact]
        [AllureTag("Бизнес-логика")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureStory("получение списка книг")]
        [AllureName("проверяем, что список не пустой")]
        public void GetAllBooksAndCheck()
        {
            var bookStorage = new BookStorage();
            var listBooks = bookStorage.GetAll();

            Assert.NotEmpty(listBooks);
        }

        [Fact]
        [AllureTag("Бизнес-логика")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureStory("Фильтраця книг")]
        [AllureName("Фильтруем по автору - Лев Толстой")]
        public void FilterBooksAndCheck()
        {
            var bookStorage = new BookStorage();

            var filters = new BookFilterParams();


            var filteredBooks = bookStorage.GetFilteredBooks(filters.Author = "Лев Толстой", filters.Category = "");

            Assert.All(filteredBooks, book => Assert.Equal(book.Author, "Лев Толстой"));

        }

    }
}
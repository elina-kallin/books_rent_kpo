@echo off
echo Запуск тестов с Allure...

REM Очищаем предыдущие результаты
if exist allure-results rmdir /s /q allure-results
if exist allure-report rmdir /s /q allure-report

REM Запускаем тесты
dotnet test --logger "trx" --results-directory allure-results

REM Генерируем отчет Allure
allure generate allure-results -o allure-report --clean

REM Открываем отчет в браузере
allure open allure-report

echo Готово!
pause
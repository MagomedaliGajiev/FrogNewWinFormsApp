# Frog Puzzle Game - Windows Forms Application

![Game Screenshot](https://github.com/MagomedaliGajiev/FrogNewWinFormsApp/blob/master/FrogNewWinFormsApp/Resources/Frogs.png)

Игра-головоломка "Лягушки" - классическая задача, где нужно поменять местами две группы лягушек за минимальное количество ходов.

## Описание игры
Цель игры - поменять местами **лягушек, смотрящих влево** (синие) и **лягушек, смотрящих вправо** (зеленые), используя свободный лист посередине.

**Правила:**
1. Лягушки могут прыгать только на соседний лист
2. Лягушки могут перепрыгивать через одну лягушку противоположного направления
3. Минимальное количество ходов для решения: 24
4. Игра отслеживает количество сделанных ходов

**Особенности реализации:**
- Визуальное отображение состояния игры
- Подсчет ходов в реальном времени
- Проверка условий победы
- Сравнение с оптимальным решением
- Система меню (рестарт, правила, выход)

## Технологии
- **Платформа**: .NET 8.0
- **Язык**: C#
- **Интерфейс**: Windows Forms (WinForms)
- **Сборка**: MSBuild

## Требования
- Windows 7 или новее
- [.NET 8.0 Runtime](https://dotnet.microsoft.com/download/dotnet/8.0)

## Как запустить
1. Скачайте последнюю версию из [Releases](https://github.com/MagomedaliGajiev/FrogNewWinFormsApp/releases)
2. Распакуйте архив
3. Запустите `FrogGame.exe`

**Или соберите из исходников:**
```bash
git clone https://github.com/MagomedaliGajiev/FrogNewWinFormsApp.git
cd FrogNewWinFormsApp
dotnet build
dotnet run

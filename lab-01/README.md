# Lab 01 - Volna

Застосунок з екраном-заставкою та екраном «Про застосунок».
Практична робота 1 з дисципліни UI/UX дизайн, КБ 603, ХАІ.

## Стек

- .NET 8, WPF
- Логотип вбудований як векторна геометрія (`DrawingImage`), без растрових зображень

## Структура

```
lab-01/
  VolnaApp/
    Assets/
      logo.svg              - основний логотип, вихідний вектор
      logo-wordmark.svg     - текстовий знак
    Resources/
      Logo.xaml             - логотип у вигляді DrawingImage для WPF
    App.xaml                - палітра застосунку, точка входу
    SplashWindow.xaml       - екран-заставка
    MainWindow.xaml         - екран «Про застосунок»
    VolnaApp.csproj
  README.md
```

## Збірка та запуск

Потрібен .NET SDK 8.0 або новіший (Windows).

```bash
cd lab-01/VolnaApp
dotnet build
dotnet run
```

Або відкрити `VolnaApp.csproj` у Visual Studio 2022 і натиснути F5.

## Як працює перехід

Заставка показується першою (`StartupUri` в `App.xaml`).
У `SplashWindow.OnLoaded` викликається `await InitializeAppAsync()`,
після завершення відкривається `MainWindow`, а заставка закривається.
Перехід неблокуючий: використано `async/await`, без `Thread.Sleep`.

## Палітра

| Роль | HEX |
|---|---|
| Фон | #141019 |
| Основний текст | #F5F3FA |
| Акцент | #A78BFA |
| Вторинний текст | #9C96AD |

Контраст основного тексту на фоні - 17.07:1 (WCAG AA вимагає 4.5:1).

## Автор

Арсен Джуртубаєв, група 611п
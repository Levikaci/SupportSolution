# SupportSolution

## Описание проекта
SupportSolution - приложение для учёта и обработки заявок пользователей в службу технической поддержки.

## Технологии
- C#
- .NET 9
- ASP.NET Core Web API
- xUnit
- Git

## Структура проекта
| Модуль | Назначение |
|---|---|
| `Support.Domain` | Предметная модель заявки и бизнес-правила |
| `Support.Application` | Интерфейсы и контракты приложения |
| `Support.Infrastructure` | Реализация хранения заявок в памяти |
| `Support.WebApi` | HTTP API для взаимодействия с приложением |
| `Support.UnitTests` | Модульные тесты |


## Сборка проекта
```bash
dotnet build SupportSolution.sln
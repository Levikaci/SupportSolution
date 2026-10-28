# Модульная структура SupportSolution

| Модуль | Ответственность | Зависимости | Обоснование |
|---|---|---|---|
| Support.Domain | Модель заявки и бизнес-правила | Нет | Содержит основную предметную логику |
| Support.Application | Контракты и интерфейсы | Support.Domain | Отделяет логику приложения от хранения данных |
| Support.Infrastructure | Хранение заявок в памяти | Support.Application, Support.Domain | Реализует технические детали хранения |
| Support.WebApi | HTTP API | Support.Application, Support.Infrastructure | Предоставляет доступ к функциям приложения |
| Support.UnitTests | Модульные тесты | Support.Domain | Проверяет правила предметной области |
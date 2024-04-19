[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/HHNhJHuF)
# Лабораторная 1. Razor Pages.

Цель лабораторной - освоение движка серверного рендеринга Razor и технологии Razor Pages.

## Требования и ограничения

1. Работа выпоняется на языке C# в среде Visual Studio. Актуальная версия .net -  8.0. +
2. Данные приложения будут сохраняться в файловой системе. +
3. Для организации доступа к данным из веб-страниц будет использоваться специализированный класс - репозиторий. +
4. Репозиторий пробрасывается в код страницы через механизм внерения зависимостей. +
5. В коде cshtml реализуется только логика разметки, бизнес-логика реализуется в codebehind файле. +

## Последовательность выполнения

1. Выберите вариант задания, выданный преподавателем. ВАРИАНТ 7 + 
2. Определите класс данных и сопутствующие типы в файле DataClass. Переименуйте класс средствами рефакторинга. +
3. Напишите код сериализации / десериализации данных в файловой системе  используя схему описанную в комментариях. +
4. Зарегистрируйте репозитарий в подсистеме DI в классе Startup как singleton. + // **насчет этого, так как у меня .net -  8.0., то они находятся в program.cs**
5. Добавьте тестовые данные в файл. +
6. Реализуйте разметку и поведение страницы просмотра списка данных. +
7. Реализуйте разметку и поведение страницы добавления нового элемента. +
8. Добавьте и реализуйте разметку и поведение страницы редактирования элемента. +
9. Реализуйте возможность удаления элемента со страницы просмотра списка данных. +
10. Реализуйте навигацию между страницами и протестируйте приложение. +
11. Отправьте исходники в репозиторий +
12. Убедитесь, что после скачивания исходников приложение собирается, запускается и работает. +
13. Уведомьте преподавателя о готовности. +

## Варианты задания

7. Список языков программирования (атрибуты: строка-название, вид (функциональный, императивный, логический, другой), число-рейтинг)

**Работу сделала: Умерова Аделина, ДИНРб-31** 

## В заключении

В ходе лабораторной работы я изучила основные принципы разработки веб-приложений с использованием asp.net и razor pages. ПО заданию создавала простой веб-сайт для управления списка языков программмирования, включая:
- для просмотра,
- добавления, 
- редактирования и удаления языков.
Ну и изучены основы работы с системой внедрения зависимостей в asp.net для управления жизненным циклом сервисов, таких как репозиторий данных. Также были применены с моделями представлений и обработкой форм..
В результате всего я получила навыки и знания!

**скрины работ**

![ScreenShot](https://raw.githubusercontent.com/nazimamin/.PNG "form - Список языков программирования")
![ScreenShot](https://raw.githubusercontent.com/nazimamin/.PNG "Tform - Список языков программирования")

* *

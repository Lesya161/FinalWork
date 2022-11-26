# __Итоговая работа по предмету Итоги специализации.__
Задание:

*Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:*

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

## Описание решения.

[Ссылка](https://app.diagrams.net/#G1lSmT-S2MK8PRZ02UdtRPw6BOZRNPJJr2) на блок схему.
Картинка добавлена в репозиторий.

1. Написан метод для создания массива из стоковых значений.
2. Написан метод для вывода строкового массива на экран терминала.
3. Создание метода для решения задачи.
4. Выделение памяти для нового массива.
5. Создание новой переменной count, цифра которой будет зависеть от выполнения условия if по длине символов равной или меньше трех. Она будет соответствовать новому размеру массива после проверки в основном массиве.
6. Запись элемента в новый массив, который проходит по циклу с условием длины меньше или равной трем.
7. Проходимся по всей длине основного массива и записываем элементы в новый массив.
8. Возвращаем массив с подходящими элементами.



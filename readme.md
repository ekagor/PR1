Итоговая проверочная работа

Задача

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

Текстовое описание решения

Объявляется два массива одинаковой длины. Создается метод, в котором цикл равен длине массива. Внутри цикла производится проверка условия на 3 символа, при прохождении условия элемент первого массива заносится в элемент второго массива. Переменная count применяется для переноса из первого массива во второй. После переноса увеличиваем значение переменной на 1, увеличиваем значение индекса на 1 и переходим к условию цикла. При достижении значения индекса более длины массива выводим получившийся массив.

В папке block diagram представлена блок-схема решения.
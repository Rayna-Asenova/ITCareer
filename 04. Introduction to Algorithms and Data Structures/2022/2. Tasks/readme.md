# Решения на задачи

## 3.1.1. Принадлежи ли дадено число на масив
Напишете програма, която чете от конзолата последователност от цели числа на един ред, разделени с интервал и на втори ред число, което се проверява дали съществува в масива от първия ред.  Ако числото съществува в масива, се извежда **{number} Exists in the List**,  в противен случай **{Number} Not exists in the List**.

## 3.1.2. Метод Insert 
Напишете програма, която чете от конзолата **възходяща последователност от цели числа** на един ред, разделени с интервал и на втори ред число, което се вмъква на такава позиция, че новополучения масив отново да е възходящо подреден. Изведете:
- Новополучения масив
- Двата масива този, преди вмъкването и другия след вмъкването

## 3.1.5. Сбор и Средно аритметично
Напишете програма, която чете от конзолата последователност от числа (на един ред, разделени с интервал). Изчислява и отпечатате сбора и средната стойност на елементите на последователността. Запазва последователността в **List<int>**. Закръглете средната стойност до втората цифра след десетичния разделител.

| **Вход** | **Изход**             |
| -------- | --------------------- |
| 4 5 6    | Sum=15; Average=5.00  |
| 1 1      | Sum=2; Average=1.00   |
|          | Sum=0; Average=0.00   |
| 10       | Sum=10; Average=10.00 |
| 2 2 1    | Sum=5; Average=1.67   |

## 3.2.1. Намиране на най-малко число 
Напишете програма, която чете от конзолата последователност от цели числа на един ред, разделени с интервал. Намерете най-малкото от тях и го изведете. Подсказка: 
- В променлива minimum запишете първото число
- Сравнявайте това число с всички останали (от второто до последното) и ако някое от тях е по-малко, то в minimum запазете неговата стойност
- Изведете стйността на minimum.

## 3.2.2. Наредени двойки
Напишете програма, която чете от конзолата последователност от две цели числа m и n . Да се изведат всички възможни наредени двойки цели числа  (p, q) които се менят съответно за p [1..m] и q [1..n]

## 3.2.4. Подреждане на думи
Определете сложността на програма, която чете от конзолата последователност от думи (символни низове на един ред, разделени с интервал). Подредете ги по азбучен ред. Запазете последователността в **List<string>**. Подсказка:
- Използвайте алгоритъма от задачата "Намиране на най-малко число", променете и допълнете
- Намерете "най-малката" по азбучен ред дума и я запазете в променлива minimum и запомнете поицията ѝ в променлива minimumPos
- На позиция minimumPos в списъка запишете първата дума от списъка
- На първа позиция в списъка запишете стойността minimum
- Повторете  стъпки от 1 до 3 за елементите на списъка от втора до последа позиция

| **Вход**          | **Изход**         |
| ----------------- | ----------------- |
| wow softuni alpha | alpha softuni wow |
| hi                | hi                |

## 3.2.5. Най-дълга последователност
Съставете програма, която намира най-дългата последователност от равни числа в даден списък от цели числа **List<int>** и връща резултата като нов **List<int>**. Ако няколко поредици имат същата най-дълга дължина, върнете най-лявата от тях. 

| **Вход**           | **Изход** |
| ------------------ | --------- |
| 12 2 7 4 **3 3** 8 | 3 3       |
| **2 2 2** 3 3 3    | 2 2 2     |
| 4 4 **5 5 5**      | 5 5 5     |
| **1** 2 3          | 1         |
| **0**              | 0         |
| 4 2 3 **4 4**      | 4 4       |

## 3.2.6. Remove/Add Method 
Определете сложността (максималния брой стъпки) на програма, която чете от конзолата възходящ списък от цели числа на един ред, разделени с интервал и на втори ред число,  за което се проверява дали е в списъка или не. Ако е, то то се премахва от него , а ако го няма – се добавя на такова място, че списъка отново да е подреден. Изведете:
- Новополучения списък
- Двата списъка: входния и новополучения

## 3.2.7. Средно аритметично и сума на спъсък 
Напишете програма, която прочита от конзолата поредица от цели положителни числа. Поредицата спира когато се въведе празен ред. Програмата трябва да изчислява сумата и средното аритметично на поредицата. Използвайте **List<int>**.

## 3.2.8. Обръщане на последователността 
Напишете програма, която прочита N цели числа от конзолата и ги отпечатва в обратен ред. Използвайте класа **Stack<int>**.

## 3.2.9. Филтриране 
Напишете програма, която премахва всички отрицателни числа от дадена редица. Пример: array = {19, -10, 12, -6, -3, 34, -2, 5} -> {19, 12, 34, 5}

## 3.2.10. Филтриране на нечетен броя срещания
Напишете програма, която при дадена редица изтрива всички числа, които се срещат нечетен брой пъти.

| **Вход**                        | **Изход**  |
| ------------------------------- | ---------- |
| 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 | 5, 3, 3, 5 |

## 3.2.11. Честота на срещания
Напишете програма, която по даден масив от цели числа в интервала [0..1000], намира по колко пъти се среща всяко число. Пример: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}

| **Вход**                  | **Изход**                          |
| ------------------------- | ---------------------------------- |
| 3, 4, 4, 2, 3, 3, 4, 3, 2 | 2 - 2 пъти, 3 - 4 пъти, 4 - 3 пъти |

## 3.2.12. BFS обхождане в ширина
Използвайки опашка реализирайте пълно обхождане на всички дирек¬тории на твърдия ви диск и ги отпечатвайте на конзолата. Реализирайте алгоритъма за обхождане в ширина **Breadth-First-Search (BFS)** може да намерите стотици статии за него в Интернет.
 
## 3.2.14. Мажорант на масив
Мажорант на масив от N елемента е стойност, която се среща поне N/2+1 пъти. Напишете програма, която по даден масив от числа намира мажоранта на масива и го отпечатва. Ако мажоранта не съществува, то отпечатва **The majorant does not exists!**.

| **Вход**                  | **Изход**                     |
| ------------------------- | ----------------------------- |
| 2, 2, 3, 3, 2, 3, 4, 3, 3 | 3                             |
| 2, 3, 4, 5, 6, 7, 8, 3    | The majorant does not exists! |

## 3.2.15. Мода на масив
Мода на масив от N елемента е стойност, която се среща най-често. Напишете програма, която по даден масив от числа намира модата на масива и го отпечатва. Ако има няколко моди се извежда средно аритметичната им стойност

| **Вход**                   | **Пояснения**                                  | **Изход** |
| -------------------------- | ---------------------------------------------- | --------- |
| 2,  2, 3, 3, 2, 3, 4, 3, 3 |                                                | 3         |
| 3, 3, 4, 5, 6, 7, 4, 2, 2  | 3, 4 и 5 се срещат по два пъти \=> (3+4+5)/2=6 | 6         |

## 3.3.1. Обръщане на числа със стека
Напишете програма, която чете N цели числа от конзолата и ги обръща в обратен на въвеждането ред, чрез стек. 
Използвайте **Stack<int>** класa от .NET Framework. Просто поставете (put) въвежданите числа в стека и ги вземете (pop) после от стека. 

| **Вход**  | **Изход** |
| --------- | --------- |
| 1 2 3 4 5 | 5 4 3 2 1 |
| 1         | 1         |
| (empty)   | (empty)   |
| 1 -2      | -2 1      |

## 3.3.2. Изчислете редицата с опашка
Дадена е  следната последователност от числа:
- S1 = N
- S2 = S1 + 1
- S3 = 2*S1 + 1
- S4 = S1 + 2
- S5 = S2 + 1
- S6 = 2*S2 + 1
- S7 = S2 + 2
- …
Използвайте класа **Queue<T>** и напишете програма, която извежда първите 50 члена за даденото N.

| **Вход** | **Изход**                                   |
| -------- | ------------------------------------------- |
| 2        | 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, …   |
| -1       | -1, 0, -1, 1, 1, 1, 2, …                    |
| 1000     | 1000, 1001, 2001, 1002, 1002, 2003, 1003, … |

## 3.3.3. Редица N -> M
Дадени са числата n и m и следните операции:
- n -> n + 1
- n -> n + 2
- n -> n * 2
Напишете програма, която намира най-късата редица от операции от списъка по-долу, който започва от n и завършва в m. Ако съществуват няколко най-къси редици, намерете първата от тях.

| **Вход** | **Изход**                  |
| -------- | -------------------------- |
| 3 10     | 3 -> 5 -> 10               |
| 5 -5     | (няма решение)             |
| 10 30    | 10 -> 11 -> 13 -> 15 -> 30 |

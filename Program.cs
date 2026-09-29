// System.Console.WriteLine("Обратный отсчёт");

// int countdown = 5;
// while (countdown >= 1) {
//     System.Console.WriteLine(countdown);
//     countdown--;
// }
// System.Console.WriteLine("Пуск!");

// System.Console.WriteLine();
// System.Console.WriteLine("Сумма чисел от 1 до 10");

// int number = 1;
// int sum = 0;

// while (number <= 10) {
//     sum += number;
//     number++;
// }

// System.Console.WriteLine($"Сумма: {sum}");


// System.Console.WriteLine();
// System.Console.WriteLine("Бесконечный цикл");

// int i = 1;
// while (i <= 5) {
//     System.Console.WriteLine($"Значение i: {i}");
//     i++;
// }


System.Console.WriteLine();
System.Console.WriteLine("Валидация ввода через while");
bool isValid = false;
int enteredAge = 0;

while (!isValid) {
    Console.Write("Введите ваш возраст (целое число): ");
    string input = Console.ReadLine()!;
    isValid = int.TryParse(input, out enteredAge);

    if (!isValid) {
        System.Console.WriteLine("Это не похоже на целое число. Попробуйте ещё раз.");
    }
}
System.Console.WriteLine($"Принято! Ваш возраст: {enteredAge}");
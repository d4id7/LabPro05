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


// System.Console.WriteLine();
// System.Console.WriteLine("Валидация ввода через while");
// bool isValid = false;
// int enteredAge = 0;

// while (!isValid) {
//     Console.Write("Введите ваш возраст (целое число): ");
//     string input = Console.ReadLine()!;
//     isValid = int.TryParse(input, out enteredAge);

//     if (!isValid) {
//         System.Console.WriteLine("Это не похоже на целое число. Попробуйте ещё раз.");
//     }
// }
// System.Console.WriteLine($"Принято! Ваш возраст: {enteredAge}");


// System.Console.WriteLine();
// System.Console.WriteLine("Меню (без выхода, один проход)");

// string menuChoice;

// do {
//     System.Console.WriteLine("1 - Показать дату");
//     System.Console.WriteLine("2 - Показать приветствие");
//     System.Console.WriteLine("0 - Выход");
//     Console.Write("Выберите пункт: ");
//     menuChoice = Console.ReadLine()!;

//     switch (menuChoice) {
//         case "1":
//             System.Console.WriteLine($"Сегодня: {DateTime.Now:dd.MM.yyyy}");
//             break;
//         case "2":
//             System.Console.WriteLine("Здравствуйте! Рады видеть вас снова.");
//             break;
//         case "0":
//             System.Console.WriteLine("До свидания!");
//             break;
//         default:
//             System.Console.WriteLine("Такого пункта нет, попробуйте снова.");
//             break;
//     }
// } while (menuChoice != "0");


System.Console.WriteLine();
System.Console.WriteLine("Прямой счёт");
for (int i = 1; i <= 5; i++) {
    System.Console.WriteLine(i);
}

System.Console.WriteLine();
System.Console.WriteLine("Обратный счёт");
for (int i = 5; i >= 1; i--) {
    System.Console.WriteLine(i);
}

System.Console.WriteLine();
System.Console.WriteLine("Чётные числа от 0 до 20");
for (int i = 0; i <= 20; i += 2) {
    Console.Write($"{i} ");
}
System.Console.WriteLine();
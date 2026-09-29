System.Console.WriteLine("Анализатор текста");
string choice;

do {
    System.Console.WriteLine("1 - Проанализировать предложение");
    System.Console.WriteLine("2 - Найти позицию первой заглавной буквы");
    System.Console.WriteLine("0 - Выход");

    System.Console.WriteLine();
    Console.Write("Введите пункт: ");
    choice = Console.ReadLine()!;

    System.Console.WriteLine();
    switch (choice) {
        case "1":
            System.Console.WriteLine("Введите предложение:");
            string sentence1 = Console.ReadLine()!;
            string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";
            string consonant = "бвгджзйклмнпрстфхцчшщБВГДЖЗЙКЛМНПРСТФХЦЧШЩ";
            int vowelCount = 0;
            int consonantCount = 0;
            int spaceCount = 0;

            foreach (char letter in sentence1) {
                if (vowels.Contains(letter)) {
                    vowelCount++;
                }
                else if (consonant.Contains(letter)) {
                    consonantCount++;
                }
                else if (letter == ' ') {
                    spaceCount++;
                }
            }

            System.Console.WriteLine($"Количество символов в строке: {sentence1.Length}");
            System.Console.WriteLine($"Количество гласных в предложении: {vowelCount}");
            System.Console.WriteLine($"Количество согласных в предложении: {consonantCount}");
            System.Console.WriteLine($"Количество пробелов в предложении: {spaceCount}");
            break;
        case "2":
            System.Console.WriteLine("Введите предложение:");
            string sentence2 = Console.ReadLine()!;
            string capitals = "АЕЁИОУЫЭЮЯБВГДЖЗЙКЛМНПРСТФХЦЧШЩ";
            bool flag = true;

            for (int i = 0; i < sentence2.Length; i++) {
                if (capitals.Contains(sentence2[i])) {
                    System.Console.WriteLine($"Индекс первой заглавной буквы: {i}");
                    flag = false;
                    break;
                }
            }
            if (flag) System.Console.WriteLine("Заглавных букв нет");
            break;
        case "0":
            System.Console.WriteLine("До свидания!");
            break;
        default:
            System.Console.WriteLine("Такого пункта нет, попробуйте снова.");
            break;
    }

    System.Console.WriteLine();
} while (choice != "0");
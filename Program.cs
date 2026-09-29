System.Console.WriteLine("Обратный отсчёт");

int countdown = 5;
while (countdown >= 1) {
    System.Console.WriteLine(countdown);
    countdown--;
}
System.Console.WriteLine("Пуск!");

System.Console.WriteLine();
System.Console.WriteLine("Сумма чисел от 1 до 10");

int number = 1;
int sum = 0;

while (number <= 10) {
    sum += number;
    number++;
}

System.Console.WriteLine($"Сумма: {sum}");
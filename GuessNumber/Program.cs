// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
if (number > 0) {
    Console.WriteLine("Число положительно");
}
else if (number < 0) {
    Console.WriteLine("Число отрицательное");
}
else {
    Console.WriteLine("Число равно 0");
}
Console.Write("Введите балл (0-100):");
int score = int.Parse(Console.ReadLine());
if (score >= 91) { Console.WriteLine("Оценка: Отлично (5)"); }
else if (score >= 71) { Console.WriteLine("Оценка: хорошо (4)"); }
else if (score >= 51) { Console.WriteLine("Оценка: удовлетворительно (3)"); }
else { Console.WriteLine("Оценка: Ты недостоен(2)"); }
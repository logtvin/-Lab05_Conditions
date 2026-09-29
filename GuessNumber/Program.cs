// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Введите число:");
// int number = int.Parse(Console.ReadLine());
// if (number > 0) {
//     Console.WriteLine("Число положительно");
// }
// else if (number < 0) {
//     Console.WriteLine("Число отрицательное");
// }
// else {
//     Console.WriteLine("Число равно 0");
// }
// Console.Write("Введите балл (0-100):");
// int score = int.Parse(Console.ReadLine());
// if (score >= 91) { Console.WriteLine("Оценка: Отлично (5)"); }
// else if (score >= 71) { Console.WriteLine("Оценка: хорошо (4)"); }
// else if (score >= 51) { Console.WriteLine("Оценка: удовлетворительно (3)"); }
//  else { Console.WriteLine("Оценка: Ты недостоен(2)"); }
Console.Write("Введите ваш возраст:");
int age = int.Parse(Console.ReadLine());
string ageGroup = age >= 18 ? "Совершеннолетний" : "Несовершеннолетний";
Console.WriteLine($"Вы {ageGroup}.");
Console.Write("\n Введите температуру за окном(c):");
double temp = double.Parse(Console.ReadLine());
string weather = temp >= 20 ? "тепло" : (temp >= 0 ? "прохладно" : "мороз");
Console.WriteLine($"за окном {weather}");


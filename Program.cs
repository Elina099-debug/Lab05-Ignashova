// int dayNumber = 5;

// switch (dayNumber)
// {
//     case 5 or 6 or 7: Console.WriteLine("Выходной"); break;
//     default: Console.WriteLine("Будний"); break;
// }



// int score = 78;

// switch (score)
// {
//     case >= 0 and < 40:
//         Console.WriteLine("Неудовлетворительно");
//         break;
//     case >= 40 and < 60:
//         Console.WriteLine("Удовлетворительно");
//         break;
//     case >= 60 and < 80:
//         Console.WriteLine("Хорошо");
//         break;
//     case >= 80 and <= 100:
//         Console.WriteLine("Отлично");
//         break;
//     default:
//         Console.WriteLine("Некорректный балл");
//         break;
// }


// Console.Write("Введите температуру: ");
// int temperature = int.Parse(Console.ReadLine());

// string category = temperature switch
// {
//     < 0 => "Мороз",
//     < 15 => "Прохладно",
//     < 25 => "Комфортно",
//     < 35 => "Жарко",
//     _ => "Очень жарко"
// };

// Console.WriteLine(category);


// string role = "teacher";

// string result = role switch
// {
//     "admin" => "Полный доступ",
//     "teacher" => "Доступ преподавателя",
//     not "admin" => "Ограниченный доступ"
// };

// Console.WriteLine(result);


// int age = 20;
// bool hasTicket = true;

// switch (age)
// {
//     case var a when a >= 18 && hasTicket:
//         Console.WriteLine("Вход разрешён");
//         break;
//     case >= 18:
//         Console.WriteLine("Нет билета");
//         break;
//     default:
//         Console.WriteLine("Возраст не подходит");
//         break;
// }


// int level = 2;

// switch (level)
// {
//     case 1:
//         Console.WriteLine("Начальный уровень");
//         break;
//     case 2:
//         Console.WriteLine("Средний уровень");
//         goto case 1;
//     case 3:
//         Console.WriteLine("Продвинутый уровень");
//         break;
// }


// //Задача А
// Console.Write("Введите номер месяца (1-12): ");
// int month = int.Parse(Console.ReadLine());

// string season = month switch
// {
//     12 or 1 or 2 => "Зима",
//     3 or 4 or 5 => "Весна",
//     6 or 7 or 8 => "Лето",
//     9 or 10 or 11 => "Осень",
//     _ => "Неверный месяц"
// };

// Console.WriteLine(season);

// //Задача Б
// Console.Write("Введите возраст: ");
// int age = int.Parse(Console.ReadLine());

// string category = age switch
// {
//     < 0 => "Ошибка",
//     <= 6 => "Ребёнок",
//     <= 17 => "Подросток",
//     <= 64 => "Взрослый",
//     _ => "Пенсионер"
// };

// Console.WriteLine(category);


// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

//Задание 5
// Console.Write("Введите температуру: ");
// int temperature = int.Parse(Console.ReadLine());

// string recommendation = temperature switch
// {
//     < 0 => "Мороз",
//     >= 0 and <= 9 => "Прохладно",
//     >= 10 and <= 19 => "Комфортно",
//     >= 20 and <= 29 => "Тепло",
//     _ => "Жарко"
// };

// Console.WriteLine(recommendation);

//Задание 7
Console.Write("Введите количество очков: ");
int points = int.Parse(Console.ReadLine());

string level = points switch
{
    < 0 => "Ошибка",
    >= 0 and <= 999 => "Новичок",
    >= 1000 and <= 4999 => "Опытный",
    >= 5000 and <= 9999 => "Продвинутый",
    _ => "Мастер"
};

Console.WriteLine(level);
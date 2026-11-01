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


Console.Write("Введите температуру: ");
int temperature = int.Parse(Console.ReadLine());

string category = temperature switch
{
    < 0 => "Мороз",
    < 15 => "Прохладно",
    < 25 => "Комфортно",
    < 35 => "Жарко",
    _ => "Очень жарко"
};

Console.WriteLine(category);
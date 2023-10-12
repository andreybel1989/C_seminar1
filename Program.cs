//однострочный комментарий

/* 
это многострочный
комментарий
*/

// Напишите программу, которая на вход 
// принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

// Задание переменной
// тип_данных имя_переменной = значение;
// 
// Console.Write("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine()); // number = 5

// int result = number * number;

// Console.WriteLine("Квадрат от числа " + number + " = " + result);

// 3. Напишите программу, которая 
// будет выдавать название дня недели 
// по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница
// Console.Write("Ведите день недели ");
// int numberOfDay = Convert.ToInt32(Console.ReadLine());
// if (numberOfDay == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if(numberOfDay == 2)
// {
//     Console.WriteLine("Вторник");
// }
// else if(numberOfDay == 3)
// {
//     Console.WriteLine("Среда");
// }
// else if(numberOfDay == 4)
// {
//     Console.WriteLine("Четверг");
// }
// else if(numberOfDay == 5)
// {
//     Console.WriteLine("Пятница");
// }
// else if(numberOfDay == 6)
// {
//     Console.WriteLine("Суббота");
// }
// else if(numberOfDay == 7)
// {
//     Console.WriteLine("Вскресенье");
// }
// else
// {
//     Console.WriteLine("Это число не соответствует дню недели");
// }

// 5. Напишите программу, которая на вход принимает 
// одно число (N), а на выходе показывает 
// все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number *= -1;
    Console.WriteLine("Вы ввели отрицательное число, я его умножил на -1 ");
}
int negativeNumber = -number;

while (negativeNumber <= number)
{
    Console.Write(negativeNumber + " ");
    negativeNumber += 1;
}
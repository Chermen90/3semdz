Console.Clear();
//просим пользователя ввести 5значное число
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

//Находим значение каждой цифры числа
int first = number / 10000; 
int second = (number / 1000) %10; 
int third = (number / 100) %10; 
int fourth = (number / 10) %10; 
int fifth = number  % 10; 

//Задаём условие -если 1я и 5я цифры друг другу равны и одновременно 2я и 4я цифры
// тоже равны друг другу, то число - палиндром. 
if (first == fifth && second == fourth)
{
    Console.WriteLine("Введённое вами число - палиндром");
}
//Если условия не выполнены, то число не палиндром
else
{
   Console.WriteLine("Введённое вами число - не палиндром"); 
}
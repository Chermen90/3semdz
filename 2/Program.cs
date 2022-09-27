Console.Clear();
Console.Write("Введите A: ");
int xa = int.Parse(Console.ReadLine());

//Console.Write("Введите ya: ");
int ya = int.Parse(Console.ReadLine());

//Console.Write("Введите za: ");
int za = int.Parse(Console.ReadLine());


Console.Write("Введите B: ");
int xb = int.Parse(Console.ReadLine());

//Console.Write("Введите yb: ");
int yb = int.Parse(Console.ReadLine());

//Console.Write("Введите zb: ");
int zb = int.Parse(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow((xb-xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));

Console.WriteLine(Math.Round(AB, 2));
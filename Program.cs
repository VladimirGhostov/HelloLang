using System;

void SayHelloRu()
{
    Console.WriteLine("Привет!");
}

void SayHelloEn()
{
    Console.WriteLine("Hello!");
}

void SayHelloFr()
{
    Console.WriteLine("Salut!");
}

void SelLang() => Console.WriteLine("1.Russian \n2.English \n3.French");

void ExitProgram()
{
    Console.Clear();
    Console.WriteLine("Для выхода из программы нажмите любую клавишу...");
    Console.ReadKey();
}

Console.WriteLine("Введите язык для приветствия");
SelLang();
Console.WriteLine();
string? language = Console.ReadLine();
Thread.Sleep(1000);
Console.WriteLine();
switch (language)
{
    case "2":
        SayHelloEn();
        break;
    case "1":
        SayHelloRu();
        break;
    case "3":
        SayHelloFr();
        break;
}

Thread.Sleep(1500);
ExitProgram();
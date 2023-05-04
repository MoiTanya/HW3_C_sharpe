// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите пятизначное число");
string N = Console.ReadLine();
if (N[0]==N[4] && N[1] == N[3]) 
    Console.WriteLine($"{N} -> да");
else Console.WriteLine($"{N} -> нет");

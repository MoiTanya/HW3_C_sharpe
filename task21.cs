// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите координаты двух точек");
Console.WriteLine("Введите поочередно 3 координаты первой точки");
int[] point1 = new int[3];
for (int i=0; i<3; i++)
{
    point1[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите поочередно 3 координаты второй точки");
int[] point2 = new int[3];
for (int i=0; i<3; i++)
{
    point2[i] = Convert.ToInt32(Console.ReadLine());
}
double[] sqr = new double[3]; 
for (int i =0; i<3; i++)
{
    sqr[i] = Math.Pow((point2[i]-point1[i]), 2);
}
double result = Math.Sqrt(sqr[0]+sqr[1]+sqr[2]);
Console.WriteLine($"Ответ -> {result}");
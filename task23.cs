// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число N!");
int N = Convert.ToInt16(Console.ReadLine());
double[] kube = new double[N];
for (int i=0; i<N; i++)
{
    //kube[i] = (i+1)*(i+1)*(i+1);
    kube[i] = Math.Pow(i+1, 3);
}
//int kube = N*N*N;
Console.Write($"{N} -> ");
for (int i=0; i<N; i++)
Console.Write($"{kube[i]} ");

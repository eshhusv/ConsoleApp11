using ClassLibrary1;

double[,] mas = new double[4, 6];
Random r = new Random();
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 6; j++)
    {
        mas[i, j] = r.NextDouble();
        Console.Write($"{mas[i, j]:F2} ");
    }
    Console.WriteLine();
}
Console.WriteLine(Class1.maxPair(mas)); 
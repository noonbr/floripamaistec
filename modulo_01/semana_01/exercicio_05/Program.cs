int n;
int x = 1, y = 0, z = 0;
n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    // z = 0, x = 1, y = 0
    z = x + y;
    Console.WriteLine(z);
    y = x;
    x = z;
}
void Qube(int num)
{
    int current = 1;
    while(current <= num)
    {int Qube = current * current * current;
        Console.WriteLine(Qube);
        current++;
    }
}
Console.WriteLine("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Qube(n);

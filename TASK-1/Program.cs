
void Palindrom(int num)
{
    if(num<10000 || num>=100000)
    Console.WriteLine("There should be only five digits in your number");
    else
    if(num/10000 == num%10 && num / 1000 % 10 == (num % 100) / 10)
    Console.WriteLine("YES");
    else 
    Console.WriteLine("NO"); 

}
Console.WriteLine("Input your number");
int res = Convert.ToInt32(Console.ReadLine());
Palindrom(res);


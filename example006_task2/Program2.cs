Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a>b)
{
    Console.WriteLine("Число "+a+" больше");
}    
else
{
    if(a==b)
    {
        Console.WriteLine("Числа равны");
    }
    else
    {
        Console.WriteLine("Число "+b+" больше");
    }
}
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число с: ");
int c = Convert.ToInt32(Console.ReadLine());

if(a>b)
{
    if(a>c)
    {
        Console.WriteLine("Число "+a+" больше всех");
    }
    else
    {   
        Console.WriteLine("Число "+c+" больше всех");
    }
}
else
{
   if(b>c)
    {
        Console.WriteLine("Число "+b+" больше всех");
    }
    else
    {   
        Console.WriteLine("Число "+c+" больше всех");
    }    
}
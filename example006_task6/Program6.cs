Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
int b=a/2;
if (b*2==a)
{
    Console.WriteLine("Число "+a+" четное");
}
else
{   
    Console.WriteLine("Число "+a+" нечетное");
}
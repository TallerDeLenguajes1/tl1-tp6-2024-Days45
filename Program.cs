Console.WriteLine("Hello, World!");
int a = 10;
int b = a;
Console.WriteLine("Valor de a:" + a);
Console.WriteLine("Valor de b:" + b);

Console.Write("Por favor, ingrese un numero: ");
string num = Console.ReadLine();
if (double.TryParse(num, out double number))
{
    if (number > 0)
    {
        double reversedNumber = 0;
        while (number > 0)
        {
            reversedNumber = reversedNumber * 10 + number % 10;
            number = Math.Floor(number / 10);
        }
        Console.WriteLine($"El numero invertido es: {reversedNumber}");
    }
    else
    {
        Console.WriteLine("El numero ingresado no es mayor a 0.");
    }
}
else
{
    Console.WriteLine("El texto ingresado no es un numero.");
}

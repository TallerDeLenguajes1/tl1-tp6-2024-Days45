/*Console.WriteLine("Hello, World!");
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
}*/
/*
Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego
pida dos números y que devuelva el resultado de la operación seleccionada. Además
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.
*/
bool siguiente = true;
while (siguiente)
{
    Console.WriteLine("Seleccione una opcion. ");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    string opcion = Console.ReadLine();

    Console.WriteLine("Ingrese el primer numero. ");
    string num1Text = Console.ReadLine();
    Console.WriteLine("Ingrese el segundo numero. ");
    string num2Text = Console.ReadLine();

    int num1=int.Parse(num1Text);
    int num2=int.Parse(num2Text);//Este método intenta convertir una cadena de texto a un número.
    switch (opcion)
    {
        case "1":
            Console.WriteLine($"La suma es: {num1+num2}");
            break;
        case "2":
            Console.WriteLine($"La resta es: {num1 - num2}");
            break;
        case "3":
            Console.WriteLine($"El producto es: {num1*num2}");
            break;
        case "4":
            if (num2 != 0)
            {
                Console.WriteLine($"La division es: {num1/num2}");
            }else{
                Console.WriteLine("No se puede dividir por cero.");
            }
            
            break;
        default:
            Console.WriteLine("Opcion no valida. ");
            break;
    }
    Console.WriteLine("Desea seguir? (s:si/n:no)");
    string respuesta= Console.ReadLine();
    siguiente= respuesta.ToLower() == "s";
}
/**Console.WriteLine("Hello, World!");
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
}**/
/**
Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego
pida dos números y que devuelva el resultado de la operación seleccionada. Además
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.
**/
bool siguiente = true;
bool acertado,esNumeroValido, opcionValida,numValido, valido;
string opcion, num1Text, num2Text;
int opciones;
double num1, num2, num;
while (siguiente)
{
    Console.WriteLine("(Calculadora V1)");
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Operaciones de CalculadoraV2");
    opcion = Console.ReadLine();
    esNumeroValido = int.TryParse(opcion, out opciones);
    if (esNumeroValido)
    {
        if (opciones >= 1 && opciones <= 4)
        {
        Console.WriteLine("Ingrese el primer número:");
        num1Text = Console.ReadLine();
        Console.WriteLine("Ingrese el segundo número:");
        num2Text = Console.ReadLine();
        acertado = double.TryParse(num1Text, out num1);
        acertado = double.TryParse(num2Text, out num2) == acertado;

        if (acertado)
        {
            switch (opciones)
            {
                case 1:
                    Console.WriteLine($"La suma es: {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"La resta es: {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"El producto es: {num1 * num2}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        Console.WriteLine($"La división es: {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                    }
                    break;
            }
        }else
        {
            Console.WriteLine("Alguno o los dos valores ingresados no es un número.");
        }
    }
    else
    {
        if (opciones == 5)
        {
            Console.WriteLine("(Calculadora V2)");
            Console.WriteLine("1. Valor absoluto");
            Console.WriteLine("2. Cuadrado");
            Console.WriteLine("3. Raíz Cuadrada");
            Console.WriteLine("4. Seno");
            Console.WriteLine("5. Coseno");
            Console.WriteLine("6. Parte entera de un número");
            opcion = Console.ReadLine();
            opcionValida = int.TryParse(opcion, out opciones);

            if (opcionValida)
            {
                if (opciones >= 1 && opciones <= 6)
                {
                    Console.WriteLine("Ingrese un número:");
                    opcion = Console.ReadLine();
                    numValido = double.TryParse(opcion, out num);

                    if (numValido)
                    {
                        switch (opciones)
                        {
                            case 1:
                                Console.WriteLine($"El valor absoluto de {num} es {Math.Abs(num)}");
                                break;
                            case 2:
                                Console.WriteLine($"El cuadrado de {num} es {Math.Pow(num, 2)}");
                                break;
                            case 3:
                                Console.WriteLine($"La raíz Cuadrada de {num} es {Math.Sqrt(num)}");
                                break;
                            case 4:
                                Console.WriteLine($"El seno de {num} es {Math.Sin(num)}");
                                break;
                            case 5:
                                Console.WriteLine($"El coseno de {num} es {Math.Cos(num)}");
                                break;
                            case 6:
                                Console.WriteLine($"La parte entera de {num} es {(int)num}");
                                break;
                        }

                        Console.WriteLine("Ingrese el primer número:");
                        string leer = Console.ReadLine();
                        valido = double.TryParse(leer, out double numero1);
                        Console.WriteLine("Ingrese el segundo número:");
                        leer = Console.ReadLine();
                        valido = double.TryParse(leer, out double numero2) && valido;

                        if (valido)
                        {
                            Console.WriteLine("Los números ingresados son válidos, entonces...");
                            Console.WriteLine($"El máximo es {Math.Max(numero1, numero2)}");
                            Console.WriteLine($"El mínimo es {Math.Min(numero1, numero2)}");
                        }
                        else
                        {
                            Console.WriteLine("Alguno o los dos valores ingresados no es un número.");
                        }
                    }else
                    {
                        Console.WriteLine("Entrada invalida. Intente de nuevo.");
                    }
                }else
                {
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                }
            }else
            {
                Console.WriteLine("Entrada invalida. Intente de nuevo.");
            }
        }else
        {
            Console.WriteLine("Opcion invalida. Intente de nuevo.");
        }
    }
    }else
    {
        Console.WriteLine("Entrada invalida. Intente de nuevo.");
    }
     Console.WriteLine("Desea seguir? (s:si/n:no)");
    string respuesta = Console.ReadLine();
    siguiente = respuesta.ToLower() == "s";
}

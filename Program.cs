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
}
*/

bool siguiente = true, numValido, opcionValida;
string opcion;
int opciones;
double num;
while (siguiente)
{
    Console.WriteLine("(Calculadora V2) ");
    Console.WriteLine("1. Valor absoluto.");
    Console.WriteLine("2. Cuadrado.");
    Console.WriteLine("3. Raiz Cuadrada.");
    Console.WriteLine("4. Seno.");
    Console.WriteLine("5. Coseno.");
    Console.WriteLine("6. Parte entera de un float.");
    opcion=Console.ReadLine();
    opcionValida=int.TryParse( opcion, out opciones);
    if (opcionValida)
    {
        if (opciones>=1 && opciones<=6)
        {
            Console.WriteLine("Ingrese un numero.");
            opcion=Console.ReadLine();
            numValido=double.TryParse(opcion, out num);
            if (numValido)
            {
                switch (opciones)
                {
                    case 1:Console.WriteLine($"El valor absoluto de {num} es {Math.Abs(num)}");
                    break;
                    case 2:Console.WriteLine($"El cuadrado de {num} es {Math.Pow(num,2)}");
                    break;
                    case 3:Console.WriteLine($"La raiz Cuadrada de {num} es {Math.Sqrt(num)}");
                    break;
                    case 4:Console.WriteLine($"El seno de {num} es {Math.Sin(num)}");
                    break;
                    case 5:Console.WriteLine($"El coseno de {num} es {Math.Cos(num)}");
                    break;
                    case 6:Console.WriteLine($"La parte entera de {num} es {(int)num}");
                    break;
                }
                Console.WriteLine("Ingrese el primer numero.");
                string leer=Console.ReadLine();
                bool valido = double.TryParse(leer, out double numero1);
                Console.WriteLine("Ingrese el segundo numero.");
                leer=Console.ReadLine();
                valido=double.TryParse(leer,out double numero2 )&&valido;
                if (valido){
                    Console.WriteLine("Los numeros ingresados son validos, entonces...");
                    Console.WriteLine($"El maximo es {Math.Max(numero1,numero2)}");
                    Console.WriteLine($"El minimo es {Math.Min(numero1,numero2)}");
                }else{
                    Console.WriteLine("Alguno de los dos valores ingresados no son numeros.");
                }
            }
            else
            {
                Console.WriteLine("Número inválido. Intente de nuevo.");
            }
        }
        else
        {
            Console.WriteLine("Opción inválida. Intente de nuevo.");
        }
    }
    else
    {
        Console.WriteLine("Opción inválida. Intente de nuevo.");
    }
    Console.WriteLine("Desea seguir? (s:si/n:no)");
    string respuesta = Console.ReadLine();
    siguiente = respuesta.ToLower() == "s";
}

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


Console.WriteLine("Ingrese una cadena.");
string cadena=Console.ReadLine();
//Obtener la longitud de la cadena y muestre por pantalla.
int longitud=cadena.Length;
Console.WriteLine($"La longitud de {cadena} es {longitud}");
//A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas.
Console.WriteLine("Ingrese una segunda cadena.");
string cadena2=Console.ReadLine();
string cadena3=string.Concat(cadena, " ", cadena2);
Console.WriteLine($"Las dos cadenas concatenadas:{cadena3}");
//Extraer una subcadena de la cadena ingresada.
string cadena4= cadena.Substring(0,4);
Console.WriteLine($"la cadena extraida es {cadena4}");//desde sus 5 primeros caracteres
//● Recorrer la cadena de texto con un ciclo Foreach e i
/**foreach (char c in cadena)
{
    Console.WriteLine($"{c}, ");
}
//Buscar la ocurrencia de una palabra determinada en la cadena ingresada
Console.WriteLine($"Ingrese la ocurrencia de la palabra:{cadena} ");
string ocurrencia = Console.ReadLine();
if (cadena.Contains(ocurrencia))
{
    Console.WriteLine($"La palabra '{ocurrencia}' se encontró en la cadena.");
}
else
{
    Console.WriteLine($"La palabra '{ocurrencia}' no se encontró en la cadena.");
}
//Convierta la cadena a mayúsculas y luego a minúsculas.
Console.WriteLine($"Conversion de {cadena} en mayusculas es: {cadena.ToUpper()}");
Console.WriteLine($"Conversion de {cadena} en minusculas es: {cadena.ToLower()}");**/
//Ingrese una cadena separada por caracteres que usted determine y muestre por pantalla los resultados (Revisar el comportamiento de split())
/**string cadenaComa="No,se,que,poner,pero,esta,separada,con,comas,xd";
string[] partess = cadenaComa.Split(',');
Console.WriteLine("Las partes de la cadena son:");
foreach (string parte in partess)
{
    Console.WriteLine(parte);
}
**/
/**Utilizando la calculadora creada anteriormente realizar las operaciones de dos
números y mostrar por pantalla y mostrar en texto el resultado. Por ejemplo para
la suma sería:
“la suma de “ num1 “ y de” num2 “ es igual a: ” resultado.
Donde num1, num2 y resultados son los sumandos y el resultado de la operación
respectivamente. ?
Nota: Busque el comportamiento del Método ToString();
**/
/**Console.WriteLine("Ingrese el primer número:");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número:");
double num2 = double.Parse(Console.ReadLine());

double suma = num1 + num2;
double resta = num1 - num2;
double multiplicacion = num1 * num2;
double division = num1 / num2;

Console.WriteLine($"La suma de {num1} y {num2} es igual a: {suma}");
Console.WriteLine($"La resta de {num1} y {num2} es igual a: {resta}");
Console.WriteLine($"La multiplicación de {num1} y {num2} es igual a: {multiplicacion}");
Console.WriteLine($"La división de {num1} y {num2} es igual a: {division}");
**/
//Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación
//simple como cadena de caracteres y que el sistema lo resuelva. Por ej. ingrese por pantalla Console.WriteLine("Ingrese una ecuación simple (por ejemplo, 582+2):");

Console.WriteLine("Ingrese una ecuación simple (por ejemplo, 582+2):");
string ecuacion = Console.ReadLine();
string[] partes = ecuacion.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
double num1_ecuacion = double.Parse(partes[0]);
double num2_ecuacion = double.Parse(partes[1]);
double resultado_ecuacion = 0;

string operador = new string(ecuacion.Except(partes[0]).Except(partes[1]).ToArray()).Trim();

switch (operador)
{
    case "+":
        resultado_ecuacion = num1_ecuacion + num2_ecuacion;
        break;
    case "-":
        resultado_ecuacion = num1_ecuacion - num2_ecuacion;
        break;
    case "*":
        resultado_ecuacion = num1_ecuacion * num2_ecuacion;
        break;
    case "/":
        resultado_ecuacion = num1_ecuacion / num2_ecuacion;
        break;
    default:
        Console.WriteLine("Ecuación no válida.");
        break;
}
Console.WriteLine($"El resultado de {ecuacion} es: {resultado_ecuacion}");
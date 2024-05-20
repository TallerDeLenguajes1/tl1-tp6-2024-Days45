using System;
class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");
      int a;
      int b;
      a=10;
      b=a;
      Console.WriteLine("Valor de a:"+a);
      Console.WriteLine("Valor de b:"+b);
      //aqui ejercicio 1
      Console.Write("Por favor, ingrese un número: ");
      string num = Console.ReadLine();//lee una cadena de texto
      if (double.TryParse(num, out double number))// Intenta convertir la cadena de texto 'num' a un número de punto flotante. Si la conversión es exitosa, asigna el número a la variable 'number' y ejecuta el código dentro del bloque 'if'.
      {
        if (number > 0)
        {
            double reversedNumber = ReverseNumber(number);
            Console.WriteLine($"El numero invertido es: {reversedNumber}");//concatena texto con una variable
        }else{
            Console.WriteLine("El numero ingresado no es mayor a 0.");
        }
      }else
      {
        Console.WriteLine("El texto ingresado no es un numero.");
      }
    }

    static double ReverseNumber(double number)
    {
        double reversedNumber = 0;
        while (number > 0)
        {
          //estoy asignando en esta variable el ultimo digito. Ej: 123
          //it 1. 0*10 + 3=3, it 2. 3*10 + 2=32, it 3. 32*10 + 1=321
            reversedNumber = reversedNumber * 10 + number % 10;
            number = Math.Floor(number / 10); //achico number
        }
        return reversedNumber;
        
    }
}
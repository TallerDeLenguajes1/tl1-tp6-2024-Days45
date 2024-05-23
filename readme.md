# Preguntas sobre el tipo String
## ¿String es un tipo por valor o un tipo por referencia?
Ecaracteres almacenada en el montón (heap). Aunque se almacena como un tipo por referencia, su comportamiento es especial: cada vez que modificas una cadena, en realidad estás creando una nueva cadena en memoria y reasignándola. Esto hace que se comporte de manera similar a un tipo por valor.

## ¿Qué secuencias de escape tiene el tipo string?
Las secuencias de escape en una cadena de texto (string) permiten incluir caracteres especiales o representar caracteres que normalmente no se pueden escribir directamente.
\\ - Barra invertida
\' - Comilla simple
\" - Comilla doble
\0 - Carácter nulo
\a - Campana de alerta
\b - Retroceso
\f - Avance de página
\n - Nueva línea
\r - Retorno de carro
\t - Tabulación horizontal
\v - Tabulación vertical
\uXXXX - Carácter Unicode (donde XXXX es un valor hexadecimal de 4 dígitos)
\xXX - Carácter Unicode (donde XX es uno o más dígitos hexadecimales)

## ¿Qué sucede cuando utilizas el carácter @ y $ antes de una cadena de texto?
El carácter @ antes de una cadena de texto (string) en C# se utiliza para crear cadenas literales verbatim. Esto significa que los caracteres de escape (como \n o \") no se interpretan dentro de la cadena.
El carácter $ antes de una cadena de texto se utiliza para crear cadenas interpoladas. En una cadena interpolada, puedes incluir expresiones dentro de llaves {} para que se evalúen y se inserten en la cadena.

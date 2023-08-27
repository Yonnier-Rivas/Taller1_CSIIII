// Ejercicio 1: Calculadora de Fracciones
// Objetivo: Crear una calculadora que maneje fracciones. El usuario ingresará dos fracciones y un operador.
// La calculadora deberá realizar la operación. Debes manejar sumas, restas, multiplicaciones y divisiones.
// Si el usuario intenta dividir entre cero, deberás mostrar un mensaje de error.

using System;

class Program
{
    static void Main(string[] args)
    {
        double resultado; // Variable para almacenar el resultado de la operacion

        Console.WriteLine("Calculadora de Fracciones");

        // Solicitar al usuario los valores de la primera fraccion
        Console.WriteLine("Ingrese el numerador de la primera fracción: ");
        double numUno = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el denominador de la primera fracción: ");
        double numDos = Int32.Parse(Console.ReadLine());

        // Validar que el denominador de la primera fracción no sea 0
        while (numDos == 0)
        {
            Console.WriteLine("Error: No se puede dividir entre 0. Ingrese un valor distinto: ");
            numDos = Int32.Parse(Console.ReadLine());
        }

        // Solicitamos al usuario los valores de la segunda fracción
        Console.WriteLine("Ingrese el numerador de la segunda fracción: ");
        double numTres = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el denominador de la segunda fracción: ");
        double numCuatro = Int32.Parse(Console.ReadLine());

        // Validar que el denominador de la segunda fracción no sea 0
        while (numCuatro == 0)
        {
            Console.WriteLine("Error: No se puede dividir entre 0. Ingrese un valor distinto: ");
            numCuatro = Int32.Parse(Console.ReadLine());
        }

        // Solicitar al usuario el operador de la operacion a realizar
        Console.WriteLine("Ingrese el operador con el que desea realizar la operación:\nTeniendo en cuenta.\nPara suma utilizar (+)\nPara resta utilizar el (-)\nPara multiplicación el (*)\nPara la división el (/)");
        string signo = Console.ReadLine();

        // Realizar la operación según el operador ingresado por el usuario
        switch (signo)
        {
            case "+":
                resultado = (((numUno * numCuatro) + (numDos * numTres)) / (numDos * numCuatro));
                Console.WriteLine(resultado);
                break;

            case "-":
                resultado = (((numUno * numCuatro) - (numDos * numTres)) / (numDos * numCuatro));
                Console.WriteLine(resultado);
                break;

            case "*":
                resultado = ((numUno * numTres) / (numDos * numCuatro));
                Console.WriteLine(resultado);
                break;

            case "/":
                resultado = ((numUno * numCuatro) / (numDos * numTres));
                Console.WriteLine(resultado);
                break;

            default:
                Console.WriteLine("Operador incorrecto.");
                break;
        }
    }
}


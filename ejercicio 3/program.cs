// Ejercicio 3: Número especial
// Objetivo: Crear un programa que determine si un número ingresado por el usuario es un número "especial".
// Un número es "especial" si cumple con los siguientes criterios:
// 1. Es divisible entre 5.
// 2. No es divisible entre 2 ni 3.
// 3. La suma de sus dígitos es mayor a 10.

int sumaDigitos = 0; // Variable para almacenar la suma de los digitos del numero
Console.WriteLine("Numero Especial");
Console.WriteLine("Ingresa un numero: ");
int num = Int32.Parse(Console.ReadLine()); // Leer el número ingresado por el usuario
int numAux = num; // Variable auxiliar para manipular el número sin modificarlo

if (num % 5 == 0) // Comprobar si el número es divisible entre 5
{
    Console.WriteLine("El numero es divisible entre 5.");

    if (num % 2 != 0 && num % 3 != 0) // Comprobar si el número no es divisible entre 2 ni 3
    {
        Console.WriteLine("El numero no es divisible entre 3 o 2.");

        // Calcular la suma de los dígitos del número
        while (numAux > 0)
        {
            int digito = numAux % 10; // Obtener el último dígito del número
            sumaDigitos += digito; // Sumar el dígito al total de la suma
            numAux /= 10; // Eliminar el ultimo digito del número para procesar el siguiente
        }

        if (sumaDigitos > 10) // Comprobar si la suma de los digitos es mayor a 10
        {
            Console.WriteLine("La suma de los dígitos es mayor a 10.\nEl numero " + num + " es un numero ESPECIAL");
        }
        else
        {
            Console.WriteLine("La suma de los dígitos es menor a 10, No es un numero ESPECIAL");
        }

    }
    else
    {
        Console.WriteLine("Si es divisible entre 2 o 3, No es un numero ESPECIAL");
    }

}
else
{
    Console.WriteLine("No es disible entre 5, No es un numero ESPECIAL");
}
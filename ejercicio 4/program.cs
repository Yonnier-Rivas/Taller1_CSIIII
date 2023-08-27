// Objetivo: Desarrollar un programa que presente al usuario una frase con palabras ocultas y permita al usuario adivinar las palabras faltantes. El programa debe proporcionar retroalimentación sobre si la palabra ingresada corresponde a alguna de las palabras ocultas.
// La frase original es: "El gato juega en el jardín".
// La frase que se muestra al usuario con palabras ocultas es: "El _____ juega _____ el _____".
// ●	El usuario tiene 10 intentos en total para adivinar las 3 palabras ocultas.
// ●	Por cada intento, el usuario ingresa una palabra.
// ●	Si la palabra ingresada corresponde a alguna de las palabras ocultas y esa palabra no ha sido adivinada anteriormente, informar al usuario que ha acertado.
// ●	Si la palabra ingresada es incorrecta o ya fue adivinada previamente, informar al usuario que está incorrecto y restar un intento.
// ●	Si el usuario adivina las 3 palabras antes de agotar sus intentos, mostrar un mensaje de felicitación y revelará la frase completa.
// ●	Si el usuario agota todos sus intentos sin adivinar todas las palabras, informarle que ha perdido y finalizar el juego.
// ●	Consejo: Para simplificar el desarrollo, no es necesario considerar variaciones en mayúsculas/minúsculas. Es decir, puedes asumir que "gato" y "Gato" serían respuestas diferentes.

// Definicion las palabras ocultas y la frase que se va a revelar
string palabraOculta1 = "gato";
string palabraOculta2 = "en";
string palabraOculta3 = "jardin";
string revelarFrase = "El gato juega en el jardin.";

// Se inicializa el número de intentos restantes y el estado de adivinanza.
int intentosRestantes = 9;
bool adivinado = false;

Console.WriteLine("Adivinanza de Frase Oculta \nEl _____ juega _____ el _____");

// Ciclo mientras para llevar control sobre los intentos restantes y que la adivinanza no se haya completado.
while (intentosRestantes > 0 && !adivinado)
{
    Console.WriteLine("Introduce una palabra: ");
    string palabra = Console.ReadLine().ToLower(); //Para convertir lo que ingreso al usuario a minuscula. 

// Comprobamos si la palabra ingresada coincide con alguna de las palabras ocultas. 

    if (palabraOculta1 == palabra && palabraOculta1 != null)
    {
        Console.WriteLine("Acertaste!");
        palabraOculta1 = null;// Se usa el null para marcar la palabra como adivinada.
    }
    else if (palabraOculta2 == palabra && palabraOculta2 != null)
    {
        Console.WriteLine("Acertaste!");
        palabraOculta2 = null;// Se usa el null para marcar la palabra como adivinada.
    }
    else if (palabraOculta3 == palabra && palabraOculta3 != null)
    {
        Console.WriteLine("Acertaste!");
        palabraOculta3 = null;// Se usa el null para marcar la palabra como adivinada.
    }
    else
    {
        Console.WriteLine("Incorrecto, te quedan " + intentosRestantes + " intentos.");
        intentosRestantes--; // Reduccion de los intentos.
    }

// Comprobar si todas las palabras ocultas han sido adivinadas.
    if (palabraOculta1 == null && palabraOculta2 == null && palabraOculta3 == null)
    {
        adivinado = true;
    }
}

if (adivinado)
{
    Console.WriteLine("¡Felicidades, has adivinado la frase! \nLa frase completa es: " + revelarFrase);
}
else
{
    Console.WriteLine("Qué falla, has perdido.");
}

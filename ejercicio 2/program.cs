// Objetivo: El usuario proporcionará un rango (por ejemplo, del 3 al 7). El programa generará tablas de 
// multiplicar para cada número en ese rango. Por ejemplo, si el rango es del 3 al 5, el programa generará 
// la tabla del 3, la tabla del 4 y la tabla del 5. Sin embargo, existe un giro: para cada tabla, el programa 
// ocultará aleatoriamente uno de los resultados y desafió al usuario a completarlo. Por ejemplo, "3 x ? = 21" 
// y el usuario debe adivinar que el número faltante es 7.

Console.Write("Generador de Tablas de Multiplicar \n");

Random aleatorio = new Random();

// Pedimos al usuario el rango de números
Console.Write("Ingrese el número inicial: ");
int inicial = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el número final: ");  
int final = Convert.ToInt32(Console.ReadLine());


// Recorremos desde el inicio hasta el final
for (int i = inicial; i <= final; i++) {

  // Mostramos el título de la tabla
  Console.WriteLine("Tabla del " + i);

  // Generamos un número aleatorio
    int randomNum = aleatorio.Next(1, 11);

  // Recorremos del 1 al 10 para mostrar la tabla
  for (int j = 1; j <= 10; j++) {

    // Si coincide con la posición actual, mostramos "?"
    if (randomNum == j) {
      
      Console.Write(i + " x ? = " + (i * j));
    // Desafío al usuario a adivinar
      Console.Write("\nAdivina el número oculto: ");
      int usuario = Convert.ToInt32(Console.ReadLine());
      
      if (usuario == j) {
        Console.WriteLine("Muy bien, ese es el número");  
      } else {
        Console.WriteLine("Incorrecto, el número era " + j); 
      }
      Thread.Sleep(1500);
    } 
    // Sino, mostramos el resultado
    else {
      Console.WriteLine(i + " x " + j + " = " + (i * j));
    }

  }
  // Línea en blanco entre tablas 
  Console.WriteLine(); 
}

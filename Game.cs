using System; // Acceder a las funciones relacionadas con la generación de números aleatorios

public class Game
{
    private Random random = new Random(); // Crea una instancia de la clase Random
    private int numeroAdivinar;

    // Método para generar un número aleatorio entre 1 y 100
    private void GenerarNumeroAleatorio()
    {
        numeroAdivinar = random.Next(1, 101);
    }

    // Método para solicitar a la jugadora que adivine el número
    private void AdivinarNumero() // tipo de valor devuelto de un método
    {
        int intentos = 0; // se inicializa en 0 y se utiliza para llevar un registro del número de intentos que ha realizado el jugador para adivinar el número
        int intentoJugador = 0; // se inicializa en 0 y se utilizará para almacenar el número que el jugador introduce

        do // bucle do-while que solicita al jugador que adivine el número repetidamente hasta que lo adivine correctamente
        {
            Console.Write("Adivina el número (entre 1 y 100): ");
            if (!int.TryParse(Console.ReadLine(), out intentoJugador)) // Validación de entrada del jugador
            {
                Console.WriteLine("Por favor, introduce un número válido.");
                continue;
            }

            intentos++; //  incrementa el contador de intentos cada vez que el jugador introduce un número

            if (intentoJugador < numeroAdivinar) // comparación
            {
                Console.WriteLine("El número es mayor.");
            }
            else if (intentoJugador > numeroAdivinar)
            {
                Console.WriteLine("El número es menor.");
            }
            else
            {
                Console.WriteLine($"¡Felicitaciones! Adivinaste el número en {intentos} intentos."); // interpolación de cadenas, combinar variables y expresiones dentro de una cadena de texto sin tener que concatenar 
            }
        } while (intentoJugador != numeroAdivinar); // repetir bucle hasta que no se cumpla la condición

    }

    // Método principal para iniciar el juego
    public void IniciarJuego()
    {
        GenerarNumeroAleatorio();
        AdivinarNumero();
    }
}
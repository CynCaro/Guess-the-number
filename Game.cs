using System; // Acceder a las funciones relacionadas con la generación de números aleatorios
using MiNamespace;

public class Game
{
    private Random random = new Random(); // Crea una instancia de la clase Random
    private int numeroAdivinar;
    private Player jugador;


     // Método principal para iniciar el juego
    public void IniciarJuego()
    {
        Console.WriteLine("Por favor, introduce tu nombre:");
        string nombreJugador = Console.ReadLine();
        jugador = new Player(nombreJugador); // Crear una instancia de Player con el nombre proporcionado
        Console.WriteLine($"¡Hola, {nombreJugador}! ¡Bienvenida al juego de adivinanzas!");
        Console.WriteLine("Estoy pensando en un número entre 1 y 100.");

        GenerarNumeroAleatorio();
        AdivinarNumero();
    }


    // Método privado para generar un número aleatorio entre 1 y 100
    private void GenerarNumeroAleatorio()
    {
        numeroAdivinar = RandomNumberGenerator();
    }


    // Método privado que genera un número aleatorio entre 1 y 100
    private int RandomNumberGenerator()
    {
        return random.Next(1, 101);
    }


    // Método para solicitar a la jugadora que adivine el número
    private void AdivinarNumero() // tipo de valor devuelto de un método
    {
        int intentos = 0; // se inicializa en 0 y se utiliza para llevar un registro del número de intentos que ha realizado el jugador para adivinar el número

        do // bucle do-while que solicita al jugador que adivine el número repetidamente hasta que lo adivine correctamente
        {
            if (intentos >= 10)
            {
            Console.WriteLine("Has excedido el límite de intentos. ¡Vuelve a intentarlo!");
            return;
            }

            jugador.MakeGuess(); // Llama al método MAkeGuess() del jugador para hacer una predicción
            intentos++; //  incrementa el contador de intentos cada vez que el jugador introduce un número

            if (jugador.GetLastGuess() < numeroAdivinar) // comparación
            {
                Console.WriteLine("El número es mayor.");
            }
            else if (jugador.GetLastGuess() > numeroAdivinar)
            {
                Console.WriteLine("El número es menor.");
            }
            else
            {
                Console.WriteLine($"¡Felicitaciones! Adivinaste el número en {intentos} intentos."); // interpolación de cadenas, combinar variables y expresiones dentro de una cadena de texto sin tener que concatenar 
            }
        } while (jugador.GetLastGuess() != numeroAdivinar); // repetir bucle hasta que no se cumpla la condición
    }

    // Método privado para validar la predicción
    private bool CheckGuess(int guess, int targetNumber) // dos argumentos: el número adivinado (guess) y el número objetivo (targetNumber)
    {
        return guess == targetNumber;
    }
}

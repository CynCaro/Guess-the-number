using System;

namespace MiNamespace
{
    class Player
    {
        // Propiedad para almacenar el nombre del jugador
        public string Name { get; }

        // Propiedad privada para almacenar el último intento del jugador
        private int lastGuess;

        // Constructor que inicializa el nombre y el último intento del jugador
        public Player(string name)
        {
            Name = name;
            lastGuess = 0; // Inicializamos a 0 por defecto
        }

         // Método público que permite consultar el último intento
        public int GetLastGuess()
        {
            return lastGuess;
        }

        // Método que se encarga de hacer la predicción solicitando por terminal un número y validando que sea correcto
        public void MakeGuess()
        {
            Console.Write("Adivina el número (entre 1 y 100): ");
            if (!int.TryParse(Console.ReadLine(), out int guess)) // Validación convertir la entrada del jugador en un número entero
            {
                Console.WriteLine("Por favor, introduce un número válido.");
                MakeGuess(); // Llama recursivamente al método si la entrada no es válida
                return;
            }

            lastGuess = guess; // Almacena el último intento del jugador
        }
    }
}
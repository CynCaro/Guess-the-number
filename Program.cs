// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("The current time is " + DateTime.Now);

using System;

namespace MiNamespace // contexto donde se puede acceder a los tipos (clases, métodos, etc.)
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenida al juego de adivinanzas!"); // Mensaje de bienvebida
            Console.WriteLine("Estoy pensando en un número entre 1 y 100.");

            Game miJuego = new Game(); // Crea instancia de la clase Game
        
            miJuego.IniciarJuego(); // Iniciar el juego
        }
    }
    
}


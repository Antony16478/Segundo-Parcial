using System;
using MinecraftManager.Models;
using MinecraftManager.Services;
using MinecraftManager.Utils;
using MinecraftManager.UI;

namespace MinecraftManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sistema de Gestión de Minecraft";
            Console.ForegroundColor = ConsoleColor.Green;

            // Inicializar servicios
            var dbManager = new DatabaseManager();
            var jugadorService = new JugadorService(dbManager);
            var bloqueService = new BloqueService(dbManager);
            var inventarioService = new InventarioService(dbManager, jugadorService, bloqueService);

            // Verificar conexión a la base de datos
            if (!dbManager.TestConnection())
            {
                Console.WriteLine("No se pudo conectar a la base de datos. Verifique la conexión e intente nuevamente.");
                Console.WriteLine("Presione cualquier tecla para salir...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Conexión a la base de datos establecida correctamente.");

            // Iniciar el menú principal
            var menuManager = new MenuManager(jugadorService, bloqueService, inventarioService);
            menuManager.MostrarMenuPrincipal();
        }
    }
}

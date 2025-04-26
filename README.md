# **Preguntas**


1. ### **¿Por qué se utiliza SCOPE_IDENTITY() en el método Crear de JugadorService?**
SCOPE_IDENTITY() se usa para obtener el ID del último registro insertado en la misma sesión y ámbito. Esto es útil porque asegura que obtengas el ID correcto, incluso si hay múltiples inserciones concurrentes en la base de datos. Básicamente, te ahorra problemas si alguien más está insertando datos al mismo tiempo.

2. ### **¿Por qué se verifica la existencia de elementos en el inventario antes de eliminar un jugador?**
Esto se hace para evitar inconsistencias en los datos. Si eliminas un jugador que todavía tiene ítems en el inventario, esos ítems quedarían "huérfanos" en la base de datos, lo que podría causar errores o datos basura. Es como asegurarte de que alguien no deje su mochila tirada antes de irse.

3. ### **¿Qué ventaja ofrece using var connection = _dbManager.GetConnection();?**
La ventaja es que el using se encarga de cerrar y liberar la conexión automáticamente, incluso si ocurre un error. Si no usas using, podrías olvidarte de cerrar la conexión, lo que eventualmente saturaría el servidor de base de datos.

4. ### **¿Por qué _connectionString está marcada como readonly en DatabaseManager?**
Esto asegura que el valor de _connectionString no pueda cambiar después de ser inicializado. Si no fuera readonly, alguien podría modificarlo accidentalmente, lo que podría comprometer la seguridad o causar errores.

5. ### **¿Cómo agregarías un sistema de logros para los jugadores?**
Primero, añadiría una tabla Logros en la base de datos con columnas como Id, Nombre, Descripcion y JugadorId. Luego, en el modelo Jugador, incluiría una lista de logros. Finalmente, implementaría métodos en JugadorService para asignar, eliminar y consultar logros.

6. ### **¿Qué sucede con la conexión en un bloque using si ocurre una excepción?**
La conexión se cierra automáticamente, sin importar si hubo un error. Esto es genial porque evita fugas de recursos.

7. ### **¿Qué ocurre si ObtenerTodos() no devuelve jugadores?**
Devuelve una lista vacía, no null. Esto es más seguro porque evita que tengas que verificar si la lista es null antes de usarla.

8. ### **¿Cómo registrarías el tiempo jugado por cada jugador?**
Añadiría una columna TiempoJugado en la tabla Jugadores y actualizaría este valor cada vez que el jugador inicie o termine una sesión. También implementaría un método en JugadorService para registrar este tiempo.

9. ### **¿Por qué el bloque try-catch en TestConnection() devuelve un booleano?**
Porque es más práctico para el código cliente saber si la conexión fue exitosa o no, en lugar de lidiar con excepciones.

10. ### **¿Por qué se separaron las clases en carpetas como Models, Services y Utils?**
Esto organiza el código y lo hace más fácil de mantener. Por ejemplo, sabes que los modelos representan datos, los servicios manejan la lógica, y los utilitarios son herramientas generales.

11. ### **¿Por qué usar una transacción en AgregarItem de InventarioService?**
Para asegurarte de que todas las operaciones relacionadas se completen juntas. Si algo falla, puedes revertir todo y evitar datos inconsistentes.

12. ### **¿Por qué JugadorService recibe un DatabaseManager como parámetro?**
Esto sigue el patrón de inyección de dependencias, que facilita las pruebas y hace que el código sea más flexible.

13. ### **¿Qué ocurre si ObtenerPorId busca un ID inexistente?**
Devuelve null. Una alternativa sería lanzar una excepción o devolver un objeto especial indicando que no se encontró.

14. ### **¿Cómo implementarías un sistema de "amigos"?**
Añadiría una tabla Amigos con columnas JugadorId y AmigoId. Luego, implementaría métodos en JugadorService para agregar, eliminar y listar amigos.

15. ### **¿Cómo se maneja la fecha de creación de un jugador?**
Lo ideal sería que la base de datos la establezca automáticamente con un valor predeterminado como GETDATE(). Esto asegura que siempre sea precisa.

16. ### **¿Por qué GetConnection() crea una nueva conexión cada vez?**
Porque las conexiones no son seguras para múltiples hilos. Reutilizar una conexión podría causar problemas de concurrencia.

17. ### **¿Qué pasa si dos usuarios modifican el mismo recurso simultáneamente?**
Podría haber conflictos o datos sobrescritos. Para evitarlo, podrías usar bloqueos o implementar un sistema de control de versiones.

18. ### **¿Por qué verificar rowsAffected en Actualizar?**
Para saber si realmente se actualizó algo. Si rowsAffected es 0, significa que el ID no existía o no hubo cambios.

19. ### **¿Cómo implementarías un sistema de logging?**
Añadiría un servicio de logging que registre las operaciones en un archivo o base de datos. Lo integraría en los métodos clave de los servicios.

20. ### **¿Cómo agregarías la entidad "Mundo"?**
Crearía una tabla Mundos y una tabla intermedia JugadorMundos para manejar la relación muchos a muchos entre jugadores y mundos.

21. ### **¿Qué es un SqlConnection y cómo se usa?**
Es una clase que representa una conexión a una base de datos SQL Server. Se usa para ejecutar comandos y consultas.

22. ### **¿Para qué sirven los SqlParameter?**
Se usan para evitar inyecciones SQL al pasar parámetros de manera segura a las consultas.



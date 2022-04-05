## CRUDPersonas
1. Crear una base de datos Oracle (Oracle version 21c).
2. Modificar el archivo "appsettings.json" (del proyecto CRUDPersonas) y cambiar el valor de la variable "OracleConnection". 
3. En la ventana de comandos, ejecutar "Add-Migration nombreMigracion" y posteriormente "Update-Database". 
4. Ejecutar el proyecto CRUDPersonas. 

Obs: Para hacer una petición GET mediante Postman, ejecutar el proyecto APIWeb. (Manejar el mismo connectionString que el proyecto de CRUDPersonas, punto 2)

# TravelMainSoft

sistema de Libreria con nombre Travel

Se desarrollo en: 

•	 C# en .NET Core version 7

•	 Usando Entity Framework 7

•	Versionamiento de código (Git) https://github.com/gregdorian/TravelMainSoft

•	Manejo de Base de Datos sql Server

Se Realizaron los siguientes entidades/Tablas

![Travel](https://github.com/gregdorian/TravelMainSoft/blob/master/MediaArchives/Diagrama%20Entidad%20Relacion.png)

Autor

Libro

LibroAutor

Editorial

# Estructurado el proyecto en DDD 

•	Acceso a datos = Travel.Infraestructure.Data

•	Negocio = Travel.Domain.Core

•	Entidades = Travel.Domain.Entities

•	Presentación = Travel.UIWebApi

•	Abstraction = Travel.Abstraction

•	Application = Travel.Application

•	Application = Travel.Testing

# Cambiar la Cadena de conexion

Para Instalar la base de datos debe realizar los cambios de instancia/Nombre servidor:
**Se encuentra en appSettings.json**

"ConnectionStrings": {
   "dbConnection" : "Server=<<Instancia/NombreServidor>> ; Database= <<NombreBaseDatos>>; Integrated Security=true; TrustServerCertificate=true"
   }
Realizar el *Add-Migration* en el Package-Manager-Console 
![Travel](https://github.com/gregdorian/TravelMainSoft/blob/master/MediaArchives/instalar%20en%20base%20de%20datos%20con%20codefirst.png)
   
Luego en la misma consola Realizar el *Update-Database*
![Travel](https://github.com/gregdorian/TravelMainSoft/blob/master/MediaArchives/instalar%20en%20base%20de%20datos%20con%20codefirst2.png)
   
   
# Seguridad

Se realizo La auteticación y la autorización con JWT junto con Identity de .Net 7.
   
# Pruebas Unitarias
   
Se realizo pruebas unitarias con **X-Unit**
   
# Ejecucion de WebApi
   
Se utilizao webapi para los verbos Get y post de Autor, Libros, Editorial; Para las pruebas de estas se utilizo -
   *Insomia(https://insomnia.rest/download)* 
   
![Travel](https://github.com/gregdorian/TravelMainSoft/blob/master/MediaArchives/SwaggerWebApi.png)

Registrando Usuario:

![Travel](https://github.com/gregdorian/TravelMainSoft/blob/master/MediaArchives/InsomiaRegister.png)

Login Usuario:

![Travel](https://github.com/gregdorian/TravelMainSoft/blob/master/MediaArchives/InsomiaLogin.png)
   
 Guardando Autores:
   
 ![Travel](https://github.com/gregdorian/TravelMainSoft/blob/master/MediaArchives/InsomiaGuardarAutores.jpg)
 
 Obteniendo Autores:
   
 ![Travel](https://github.com/gregdorian/TravelMainSoft/blob/master/MediaArchives/InsomiaAutores.png)
 
 Grabando Libros:
   
 ![Travel](https://github.com/gregdorian/TravelMainSoft/blob/master/MediaArchives/guardarLibro.png)
   
 Obteniendo Libros:
 
 ![Travel](https://github.com/gregdorian/TravelMainSoft/blob/master/MediaArchives/InsomiaGetLibros.png)
   
 Guardar Editorial:
   
  ![Travel](https://github.com/gregdorian/TravelMainSoft/blob/master/MediaArchives/InsomiaGetLibros.png)
   
 Mostrar Editorial:
   
  ![Travel](https://github.com/gregdorian/TravelMainSoft/blob/master/MediaArchives/InsomiaMostrarEditorial.png)


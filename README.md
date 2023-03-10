# TravelMainSoft

sistema de Libreria con nombre Travel

Se desarrollo en: 

•	 C# en .NET Core version 7

•	 Usando Entity Framework 7

•	Versionamiento de código (Git) https://github.com/gregdorian/TravelMainSoft

•	Manejo de Base de Datos sql Server

Se Realizaron los siguientes entidades/Tablas

![Rigo](https://github.com/gregdorian/RigoBikeShop/blob/master/RigoRigo.jpg)

Autor

Libro

LibroAutor

Editorial

Estructurado el proyecto en DDD 

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

Luego en la misma consola Realizar el *Update-Database*

# Seguridad

Se realizo La auteticación y la autorización con JWT junto con Identity de .Net 7.
   
# Pruebas Unitarias
   
Se realizo pruebas unitarias con **X-Unit**
   
# Ejecucion de WebApi
   
Se utilizao webapi para los verbos Get y post de Autor, Libros, Editorial; Para las pruebas de estas se utilizo -
   *Insomia(https://insomnia.rest/download)* 

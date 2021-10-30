Hogwarts API

API hecha en .net Core 3.1 y SQL server

Para crear la BD se debe ejecutar el siguiente comando en el package manager console:
update-database 

Ya con esto se tendria creada la BD.

Una vez creada la BD se debe inicializar el servicio para poder consumirlo, en la carpeta Doc se encuentra un archivo de collections de postman donde se indica cada endpoint.
De igual manera se agrego Swagger de manera que se puedan identificar los endpoints presentes y la descripcion del modelo "Solicitud".

La ruta para entrar a swagger es: https://localhost:44379/swagger/index.html
En el archivo appsettings se encuentra la configuracion de la base de datos en el caso que se posean unas credenciales de SQL Server distintas a las por defecto.
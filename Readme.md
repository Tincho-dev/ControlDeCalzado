# Trabajo Final Integrador

### Integrantes Grupo 7:
- Figueroa, Felix Ignacio – 46276
-  López Rubio, Martin – 50011
-  Maza, Sebastian Agustin - 50240
-  Paz, Augusto Cesar - 50582

## Detalles del sistema desarrollado

El sistema es una aplicación web distribuida, diseñado con una arquitectura en capas. Está desarrollado en Visual Studio 2019, con tecnología ASP.NET MVC (Modelo – Vista - Controlador) y la base de datos SQL Server 2019. 

Utilizamos Entity Framework para realizar la conexión a base de datos y poder mapear las tablas de la base de datos a objetos y clases del sistema. 

También utilizamos Ajax que se refiere a un grupo de tecnologías que se utilizan para desarrollar aplicaciones web. Ajax permite que un usuario de la aplicación web interactúe con una página web sin la interrupción que implica volver a cargar la página web. La interacción del sitio web ocurre rápidamente sólo con partes de la página de recarga y renovación. 

La arquitectura en capas nos permite aplicar restricciones sobre que capas se pueden comunicar con que otras capas. Nuestro sistema cuenta con 5 capas: 

- Capa Common: Esta capa contiene archivos que son utilizados en todo el sistema, es decir, archivos en común que se utilizan en todas las partes del sistema. 

- Capa Models: Es la capa que contiene todas las clases que representan el dominio del problema. 

- Capa Services: También llamada capa lógica de negocios se encarga de la logística del sistema. Es la encargada de conectar todas las capas del sistema, desde la capa presentación hasta la base de datos. Es el orquestador del flujo del programa.


- Capa Persistance: Aquí es donde se realiza la conexión a la base de datos, donde podemos definir datos precargados, etc. 

- Capa Presentación: Es la capa donde se encuentra todo el front end del sistema. Aquí se encuentras los controladores y vistas correspondientes del sistema, con sus respectivas restricciones de acceso. 

- Test: En esta parte, se encuentran las distintas pruebas unitarias realizadas al código, para verificar que el sistema cumple con las funcionalidades requeridas. 

Contamos con un sistema de autenticación proporcionado por ASP.NET llamado Identity el cuál hace uso de las cookies para guardar la sesión actual, logrando realizar el registro e inicio de sesión de los usuarios, como así también el otorgamiento de los distintos roles con los que cuenta el software. 

Se cuenta con 3 roles: Supervisor de Línea, Supervisor de Calidad y Administrador. Cada uno tiene acceso a distintas secciones del sistema.  

- Supervisor de Calidad: Al ingresar un usuario con rol “SuperCalidad” el sistema lo redirige directamente a una vista en donde se muestran las diferentes Ordenes de Producción (Op) disponibles y las asociadas a dicho usuario. Permitiendo, en caso de no tener una Op asociada sin finalizar, poder asociarse a una Op e iniciar la inspección. En caso contrario, el sistema mostrará una excepción de que el Supervisor ya se encuentra asociado a una Op Activa. 

- Administrador: El usuario con rol “Admin”, tiene acceso a prácticamente todo el sistema. Las restricciones con las que cuenta son, que no puede crear ordenes de producción, ni tampoco iniciar una inspección. 

- Supervisor de Linea: Si el usuario tiene rol “SuperLinea”, tiene acceso a la gestión de Líneas, Modelos, Colores y Ordenes de Producción. El supervisor de Linea tiene la funcionalidad de Asignar Op a Supervisores de Calidad y, pausar o finalizar las ordenes de producción activas. 

 

## Ejecución del sistema 

Para la ejecución del sistema una vez descargado, probablemente primero se deban actualizar los paquetes utilizados para poder realizar la ejecución de sistema. 

Una vez actualizados los paquetes, en el archivo config de la capa de presentacion, cambiaremos el connection string por el de nuestra base de datos. 

Luego procedemos a abrir la consola del administrador de paquetes, por defecto nuestro sistema tiene habilitadas las migraciones, por lo que pasaremos directamente a agregar una nueva migración para poder crear la base de datos. 

Ejecutaremos el siguiente comando en la consola: 

`Add-migration <NombreMigracion> `

Luego de realizado esto, se creará un archivo en la carpeta migrations ubicada en la capa persistance, que contendrá toda la información de las tablas que se crearan en la base de datos, dichas tablas estan relacionadas a las clases del dominio. 

Una vez ejecutado el comando anterior, ejecutaremos el siguiente comando: 

`Update-database` 

Este comando nos creara la base de datos y en el caso de haber datos precargados, también los incorporará a la base de datos. 

Una vez realizado esto, ya podemos compilar y ejecutar el sistema. Por defecto el sistema carga en base de datos un usuario Administrador. 

Para ingresar al sistema por primera vez, se deberá dirigir a “Iniciar Sesión” y ahí ingresar el siguiente usuario y contraseña. 

> **Usuario**: admin@admin.com 

> **Contraseña**: Admin_1234 


------------

**[English]**
#### ## *HOW TO RUN IT FOR THE FIRST TIME*

1. Change database connection string in Web.config

2.  Enable migrations in Persistance  
`enable-migration`

3. Delete existing migrations and run again  
`Add-migration Initialize`

4.  Update database   
`update-database`

5. Select default execution project  
`SistemaGestionDeClientes` 



**[Español]**
#### ## *COMO EJECUTARLO POR PRIMERA VEZ*

1. Cambiar cadena de conexion de base de datos en Web.config

2.  Habilitar migraciones en Persistance 
`enable-migration`

3. Borrar las migraciones existentes y ejecutar de nuevo
`Add-migration Initialize`

4.  Actualizar base de datos. 
`update-database`

5. Seleccionar proyecto de ejecución por defecto 
`SistemaGestionDeClientes` 


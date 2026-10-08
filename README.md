# TP\_GestiondeAcopiodeGranos\_LautaroNavarro-EliasKorell


TP Final – Gestión de Acopio de Granos
---



#### Integrantes: Lautaro Navarro y Elias Korell - Materia: Programación I

#### 

#### Descripción del sistema



El presente trabajo consiste en el desarrollo de una aplicación de escritorio destinada a una planta de acopio de granos. El sistema permite registrar los camiones que descargan cereal en la planta, conocer cuánto entregó cada productor y llevar un control de la calidad de lo que se recibe.



El control de calidad se basa en la humedad: cada cereal tiene definida una humedad máxima aceptada y, al registrar una descarga, el sistema compara la humedad medida con ese valor para determinar si la descarga es aceptada o rechazada.



La aplicación se desarrollará en Windows Forms, utilizando Entity Framework Core para el acceso a datos y SQLite como motor de base de datos.



#### Entidades principales



1. Productor: nombre, CUIT, teléfono y localidad.
2. Cereal: nombre (soja, maíz, trigo, etc.) y humedad máxima aceptada.
3. Descarga: fecha, productor, cereal, patente del camión, kilos brutos, tara, humedad y estado (aceptada o rechazada).



**Los kilos netos de cada descarga no se almacenan, sino que se calculan como la diferencia entre los kilos brutos y la tara.**



#### Objetivos



* Registrar de forma ordenada a los productores y los cereales que recibe la planta.
* Registrar cada descarga de cereal con sus datos de peso y humedad.
* Controlar la calidad de lo recibido, rechazando las descargas que superen la humedad máxima permitida.
* Obtener reportes sobre lo entregado por cada productor y lo recibido por la planta.

#### 

#### Funcionalidades previstas



###### Gestión de Productores



Alta, baja, modificación y consulta de los productores. La baja es lógica: el productor queda marcado como inactivo para conservar el historial de sus descargas.



###### Gestión de Cereales



Alta, baja, modificación y consulta de los cereales, indicando para cada uno la humedad máxima aceptada. Al igual que en el caso anterior, la baja es lógica.



###### Gestión de Descargas



Alta, baja, modificación y consulta de las descargas. Al registrar o modificar una descarga, el sistema determina automáticamente su estado comparando la humedad medida con la humedad máxima del cereal. El estado queda guardado, de modo que un cambio posterior en la humedad máxima de un cereal no modifica las descargas ya registradas.



**Las descargas rechazadas no se consideran en los totales de kilos recibidos.**



#### Reportes



1. Ranking de productores según los kilos netos entregados, de mayor a menor.
2. Total de kilos recibidos por cereal.
3. Cantidad de descargas realizadas por mes.
4. Descargas rechazadas por exceso de humedad.
5. Historial de descargas de un productor seleccionado, con el detalle de cada una (fecha, cereal, patente, kilos netos, humedad y estado).



#### Integración de las capas



La solución está organizada en dos proyectos:



* Biblioteca de clases: contiene las entidades del dominio, el contexto de datos (AcopioContext, que hereda de DbContext) y los repositorios encargados del acceso a la base de datos.
* Aplicación WinForms: contiene los formularios que conforman la interfaz gráfica y que hacen uso de la biblioteca de clases.



Para ilustrar cómo interactúan ambas capas, tomamos como ejemplo el registro de una nueva descarga:



1. El usuario completa los datos de la descarga en el formulario correspondiente.
2. El formulario valida que los campos obligatorios estén completos y que los valores numéricos sean correctos, y construye un objeto Descarga.
3. Luego invoca al método Agregar(descarga) de DescargaRepositorio.
4. El repositorio agrega el objeto al contexto y ejecuta SaveChanges().
5. Entity Framework Core traduce la operación y el registro queda guardado en la base de datos SQLite.



**De esta forma, la interfaz no accede directamente a la base de datos, sino que lo hace siempre a través de los repositorios definidos en la biblioteca de clases.**

#### 

#### Tecnologías utilizadas



* C# / .NET
* Windows Forms
* Entity Framework Core
* SQLite


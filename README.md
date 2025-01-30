# WCF People Service - Simple 3-Layer Architecture

Este proyecto contiene una implementación de un servicio WCF para manejar operaciones relacionadas con personas en un sistema. La arquitectura está basada en un enfoque simple de **3 capas**, utilizando una capa de presentación (el servicio WCF), una capa de lógica de negocio (la lógica de las reglas de negocio), y una capa de acceso a datos (broker) que interactúa con los datos.

## Descripción del Servicio

El servicio WCF implementa la interfaz **IPeopleService** y proporciona un método **GetPeopleByPhoneNumber** para recuperar información de personas basada en un número de teléfono celular proporcionado en la solicitud. El servicio es simple y está diseñado para servir como ejemplo de una implementación WCF utilizando una arquitectura de tres capas. 

El servicio está configurado utilizando un **basicHttpsBinding** por conveniencia y facilidad de despliegue, lo que significa que no se están utilizando configuraciones de seguridad avanzadas, sino que se enfoca más en la estructura del servicio.

## Arquitectura

### 1. Capa de Servicio (WCF):
El servicio **PeopleService** es responsable de recibir las solicitudes de los clientes, interactuar con la lógica de negocio para obtener los datos necesarios y devolver la información al cliente en un formato adecuado. Este servicio implementa la interfaz **IPeopleService** y expone el método **GetPeopleByPhoneNumber** que acepta un objeto **PersonRequest** y devuelve una lista de objetos **PersonResponse**.

### 2. Capa de Lógica de Negocio (Reglas de Personas):
La lógica de negocio está encapsulada en la clase **PeopleController** dentro del espacio de nombres **bcp.yape.bo.services.rules.People**. Esta capa maneja la lógica de obtener las personas basadas en el número de teléfono y hace la transformación entre las entidades de la base de datos y los objetos de respuesta que se envían al cliente.

### 3. Capa de Acceso a Datos (Broker):
La capa de acceso a datos es representada por la clase **PeopleBroker**. Esta clase se encarga de simular el acceso a datos para obtener la información de las personas basadas en un número de teléfono celular. En esta implementación, los datos de personas están "quemados" (hardcoded) para fines de demostración, con dos personas ficticias en la lista.

### Simplificación de la Solución
Esta solución fue diseñada con simplicidad en mente, con el objetivo de darle mayor importancia a la implementación de la solución de **arquitectura hexagonal** en otro proyecto. Por esta razón, no se añadieron validaciones complejas ni configuraciones de seguridad avanzadas, como autenticación o autorización, en el servicio WCF.

En la capa de **PeopleBroker**, se utilizaron datos de ejemplo para simular la interacción con una base de datos, lo que hace que el sistema sea fácil de desplegar y probar en un entorno de desarrollo local o de prueba. La elección de **basicHttpsBinding** se hizo para asegurar que el servicio sea accesible de manera sencilla sin preocuparse por configuraciones de seguridad complejas.

## Características Principales

- **Servicio WCF Simple**: Implementa operaciones básicas para obtener personas por número de teléfono.
- **Arquitectura de 3 Capas**: Se implementan las capas de presentación, lógica de negocio y acceso a datos.
- **Uso de Datos Ficticios**: Los datos de personas están predefinidos en la clase **PeopleBroker** como un conjunto fijo de registros, simulando una base de datos.
- **Uso de `basicHttpsBinding`**: Para facilitar el despliegue y la conexión segura, se configuró el servicio con un binding básico HTTPS, sin configuraciones de seguridad avanzadas.

## Implementación de Métodos

- **GetPeopleByPhoneNumber**: Este método recibe un **PersonRequest** con un número de teléfono celular y devuelve una lista de **PersonResponse**, que contiene la información de las personas asociadas con ese número. La lógica para obtener las personas se maneja en la clase **PeopleController**, que consulta la capa de **PeopleBroker**.

## Limitaciones y Áreas No Cubiertas

1. **Falta de Validaciones**: La solución no incluye validaciones avanzadas, como verificar si el número de teléfono ya está registrado o si la persona existe en el sistema.
2. **Autenticación y Autorización**: No se implementaron mecanismos de autenticación o autorización en este servicio, lo que significa que cualquier cliente puede consumir el servicio sin restricciones.
3. **Configuraciones de Seguridad Avanzadas**: El servicio se configuró utilizando un **basicHttpsBinding** de manera simple para facilitar el despliegue. No se implementaron protocolos más avanzados de seguridad.
4. **Persistencia de Datos Real**: La capa de **PeopleBroker** utiliza datos "quemados" y no está conectada a una base de datos real. Esto significa que la solución no refleja un entorno de producción con persistencia de datos real.

## Consideraciones Futuras

En una versión más avanzada de este servicio, se podrían implementar las siguientes características:
- Conexión con una base de datos real para almacenar y recuperar personas.
- Implementación de validaciones para asegurar que los datos recibidos sean correctos.
- Mecanismos de autenticación y autorización para garantizar que solo usuarios autorizados puedan acceder a ciertos métodos del servicio.
- Uso de configuraciones más avanzadas de seguridad, como el uso de certificados SSL/TLS para proteger la comunicación.

## Conclusión

Esta solución WCF de 3 capas fue creada para demostrar una implementación simple y comprensible de un servicio de personas, con un enfoque minimalista que favorece la simplicidad y la facilidad de despliegue. Aunque no incluye validaciones y otras configuraciones de seguridad, se diseñó de esta forma para enfocarse en la comprensión de la arquitectura y en proveer una base para una solución más compleja en el futuro.

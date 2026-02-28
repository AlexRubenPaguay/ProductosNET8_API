# 📦 API Admin Productos - .NET 8 Web API

API RESTful desarrollada con .NET 8 y Entity Framework Core para la gestión de productos. Esta API está diseñada para ser consumida por aplicaciones frontend como Angular, React o Vue.js.

# Frond-end de esta API.
-  https://github.com/AlexRubenPaguay/ProductosAngular17    Consumida en Angular 17
-  https://github.com/AlexRubenPaguay/Consumo_ProductoAPI   Consumida en Asp.Net core

## ✨ Características

    ✅ CRUD completo para productos

    ✅ Entity Framework Core para acceso a datos

    ✅ SQL Server como base de datos

    ✅ Configuración CORS para múltiples orígenes

    ✅ Documentación automática con Swagger

    ✅ Inyección de dependencias

    ✅ Manejo de errores consistente

## 🛠 Tecnologías Utilizadas

    .NET 8 - Framework principal

    Entity Framework Core 8 - ORM para acceso a datos

    SQL Server - Base de datos relacional

    Swagger/OpenAPI - Documentación de API

    CORS - Configuración de seguridad para múltiples orígenes

## 📦 Requisitos Previos

    .NET 8 SDK

    SQL Server (2019 o superior)

    Visual Studio 2022 o VS Code

    Postman (opcional, para probar la API)

## 🔌 Endpoints de la API

<img width="1737" height="872" alt="imagen" src="https://github.com/user-attachments/assets/5299c468-0e0f-4aac-949a-1d1a0e0f80ce" />

## Productos
## Método	Endpoint	Descripción
- GET	   /v1/api/producto/getAll	                   ----> Obtiene todos los productos
- GET	   /v1/api/producto/getById/{idProducto}	     ----> Obtiene un producto por ID
- GET	   /v1/api/producto/buscar/{atributoProducto}  ----> Busca un producto por: nombre,precio,stock o fecha
- POST	 /v1/api/producto/crear	                     ----> Crea un nuevo producto
- PUT	   /v1/api/producto/actualizar/{idProducto}	   ----> Actualiza un producto existente
- DELETE /v1/api/producto/eliminar/{idProducto}	     ----> Elimina un producto

## 📝 Ejemplos de Uso
## Obtener todos los productos
<img width="1381" height="918" alt="imagen" src="https://github.com/user-attachments/assets/90c8ae5e-a794-423a-840d-8b375bd67e42" />

## Obtener producto por ID
<img width="1392" height="691" alt="imagen" src="https://github.com/user-attachments/assets/0c1e0492-61f6-4bcf-92c5-2e6252eb8ca8" />

## Buscar productos por: nombre, precio, stock o fecha.
- Por fecha:
<img width="1391" height="892" alt="imagen" src="https://github.com/user-attachments/assets/98fbba61-a826-4f65-8831-78dfdcc61e9e" />

- Por nombre:
  <img width="1386" height="662" alt="imagen" src="https://github.com/user-attachments/assets/d6be167e-aa5f-41f1-a03c-d577f26d5e44" />

## Crear un nuevo producto
<img width="1373" height="631" alt="imagen" src="https://github.com/user-attachments/assets/35e7d5ca-7444-4c5a-a8fa-126fc770c620" />

## Actualizar un producto

<img width="1377" height="571" alt="imagen" src="https://github.com/user-attachments/assets/18c9f817-30ce-4da3-a784-9895143f01a0" />

## Eliminar un producto

<img width="1372" height="411" alt="imagen" src="https://github.com/user-attachments/assets/6cd8e19f-1c13-43ec-9255-e5e8e66e88f4" />

## 📚 Swagger Documentation

La API incluye documentación automática con Swagger UI:

    URL de desarrollo: http://localhost:5153/swagger/index.html

    Interfaz interactiva para probar los endpoints

    Documentación detallada de modelos y respuestas

## 🙏 Agradecimientos

    Microsoft .NET Team

    Entity Framework Core Team

    Swagger

⭐️ ¡No olvides darle una estrella al proyecto si te fue útil! ⭐️



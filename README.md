# 🧠 PreguntadOrt - Trivia Challenge 🚀

**PreguntadOrt** es una aplicación web de trivia dinámica desarrollada en **ASP.NET Core MVC**. El proyecto fue originalmente concebido como un desafío académico para la **ORT**, pero ha sido optimizado y migrado a tecnologías de última generación para demostrar capacidades de desarrollo **Fullstack**.

---
## 🚀 Live Demo
[http://francozaina-001-site1.mtempurl.com/]
---
## 🛠️ Stack Tecnológico

* **Backend:** .NET 10.0 (C#)
* **Frontend:** ASP.NET Core MVC, HTML5, CSS3 (Bootstrap 5)
* **Base de Datos:** Microsoft SQL Server 2025
* **ORM:** Dapper (Micro-ORM de alto rendimiento)

---

## 🌟 Características Destacadas

* **Lógica Dinámica:** Sistema de filtrado inteligente que permite jugar por categorías específicas o con todo el mazo de preguntas simultáneamente.
* **UI Optimizada:** Interfaz limpia con fondos personalizados y flujo de usuario simplificado para una mejor experiencia de juego.
* **Arquitectura MVC:** Separación clara de responsabilidades para un código mantenible y escalable.

---

## 🔧 Instalación y Configuración Local

Para correr este proyecto en tu entorno de desarrollo local seguí estos pasos:

### 1. Base de Datos
1.  Abrí **SQL Server Management Studio (SSMS)** y conectate a tu instancia local (`.\SQLEXPRESS`).
2.  Ejecutá el script contenido en `scriptmejora.sql` para crear la base de datos **`PreguntadOrtDB`** y cargar las preguntas.

### 2. Configuración del Proyecto
Actualizá tu `appsettings.json` o el archivo `BD.cs` con tu cadena de conexión local:

```json
"DefaultConnection": "Server=.\\SQLEXPRESS;Database=PreguntadOrtDB;Trusted_Connection=True;TrustServerCertificate=True;"
```

### 3. Ejecución
En la terminal de tu IDE preferido (VS Code / Visual Studio), ejecutá:
```bash
dotnet run
```

---

## 👤 Autor
**Franco Zaina**
* 🎓 Computer Science Student at **UBA (Exactas)**
* 💻 Systems Graduate from **ORT Argentina**
* 🔗 [LinkedIn Profile](https://www.linkedin.com/in/franco-rom%C3%A1n-zaina-a2bb9a238/) | 📧 [fran.roman.zeta@gmail.com]

# ❓​ Trivia Challenge MVC

Aplicación web de trivia desarrollada con **ASP.NET Core MVC**, donde los usuarios pueden responder preguntas por categorías y avanzar a través de distintas rondas de juego.

El proyecto fue realizado originalmente como trabajo académico y luego adaptado/mejorado para dejarlo más prolijo, presentable y fácil de mostrar como parte de mi portfolio.

---

## 🚀 Demo

**Live Demo:** http://francozaina-001-site1.mtempurl.com/

---

## 🛠️ Tecnologías utilizadas

- **ASP.NET Core MVC**
- **C#**
- **SQL Server**
- **Dapper**
- **HTML5**
- **CSS3**
- **Bootstrap**
- **JavaScript**

---

## 📌 Características principales

- Sistema de trivia por preguntas
- Interfaz web con navegación entre vistas
- Lógica de juego del lado del servidor
- Persistencia de datos con SQL Server
- Arquitectura MVC para separar responsabilidades
- Integración entre frontend, backend y base de datos

---

## 🧠 Objetivo del proyecto

El objetivo principal fue practicar conceptos de desarrollo **full stack**, trabajando sobre:

- Construcción de interfaces web
- Organización de vistas y controladores
- Manejo de lógica de negocio
- Conexión a base de datos
- Estructuración de una aplicación MVC

---

## 📂 Estructura general

El proyecto está organizado siguiendo el patrón **MVC**:

- **Models** → manejo de datos y entidades
- **Views** → interfaz visual
- **Controllers** → lógica de navegación y comportamiento
- **Data / acceso a base de datos** → consultas y persistencia

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
* 🎓 Ciencias de la Computación **UBA (Exactas)**
* 💻 Egresado en informática **ORT Argentina**
* 🔗 [LinkedIn Profile](https://www.linkedin.com/in/franco-rom%C3%A1n-zaina-a2bb9a238/) | 📧 [fran.roman.zeta@gmail.com]

---

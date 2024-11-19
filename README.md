[![BD-Biblioteca.png](https://i.postimg.cc/fL1cNJxb/BD-Biblioteca.png)](https://postimg.cc/0MdMG5Xg)


# Tp_integrador_01-master

## Sistema de Gestión de Préstamos de Libros - Biblioteca

Este proyecto es una **aplicación de escritorio** desarrollada en **C#** utilizando la arquitectura **Modelo-Vista-Controlador (MVC)** y **MySQL** como sistema de gestión de base de datos. Su objetivo es gestionar el préstamo de libros en una biblioteca, permitiendo a **bibliotecarios** y **alumnos** interactuar con el sistema de manera eficiente y organizada.

---

### Funcionalidades Principales:

#### :book: **Módulo de Alumnos:**
- **Registrar** y gestionar información de los alumnos.
- Los alumnos pueden estar **activos** o **suspendidos**.
    - **Alumnos suspendidos** no podrán realizar nuevos préstamos hasta que finalice su período de suspensión.

#### :books: **Módulo de Bibliotecarios:**
- Permite gestionar la **información de los bibliotecarios** que administran los préstamos de libros.
- Los bibliotecarios deben estar **registrados** en el sistema para poder operar y gestionar los préstamos.

#### :blue_book: **Módulo de Libros y Ejemplares:**
- Permite registrar libros con **información detallada** como:
    - Título
    - ISBN
    - Autor
    - Editorial
    - Género
- Cada libro puede tener varios **ejemplares** (originales, fotocopias, audiolibros, e-books, etc.).
- Se gestiona la **disponibilidad** de cada ejemplar para préstamo, asegurando que solo los ejemplares **disponibles** puedan ser prestados.

#### :bookmark_tabs: **Módulo de Préstamos:**
- Los alumnos pueden realizar **préstamos** de varios ejemplares de diferentes libros, pero **no pueden** tomar más de un ejemplar del mismo libro en un solo préstamo.
- El sistema verifica la **disponibilidad** de los ejemplares antes de registrar el préstamo.
- Se registran las **fechas de inicio** y **devolución** de los préstamos.
- El sistema permite parametrizar los **días de préstamo a domicilio** y los **días de suspensión** por incumplimiento en la devolución de libros a través de una tabla en la base de datos.

---

### Tecnologías Utilizadas:
- **Lenguaje de programación**: C#
- **Base de datos**: MySQL
- **Arquitectura**: Modelo-Vista-Controlador (MVC)

---

Este proyecto proporciona una forma sencilla, pero eficaz, de gestionar los préstamos de libros en una biblioteca, asegurando una correcta administración de los ejemplares y el control sobre los plazos de devolución.

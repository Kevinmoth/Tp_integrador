![Bawse de datos usadas]([URL de la imagen](https://raw.githubusercontent.com/Kevinmoth/Tp_integrador/aa9fc43a5813aa81ff5ba244294ea90d50d34573/BD_Biblioteca.png?token=GHSAT0AAAAAACY6TU7TC4IIZYHOHGO7H6LQZZ36OJQ))


# Tp_integrador_01-master

Sistema de Gestión de Préstamos de Libros - Biblioteca
Este proyecto es una aplicación de escritorio desarrollada en C# utilizando la arquitectura Modelo-Vista-Controlador (MVC) y MySQL como sistema de gestión de base de datos. Su objetivo es gestionar el préstamo de libros en una biblioteca, permitiendo a los bibliotecarios y alumnos interactuar con el sistema de manera eficiente y organizada.

Funcionalidades Principales:
Módulo de Alumnos:

Permite registrar y gestionar información de los alumnos.
Los alumnos pueden estar activos o suspendidos. Los alumnos suspendidos no podrán realizar nuevos préstamos hasta que finalice su período de suspensión.
Módulo de Bibliotecarios:

Permite gestionar la información de los bibliotecarios que administran los préstamos de libros.
Los bibliotecarios deben estar registrados en el sistema para operar y gestionar los préstamos.
Módulo de Libros y Ejemplares:

Permite registrar libros con información detallada como: título, ISBN, autor, editorial y género.
Cada libro puede tener varios ejemplares (originales, fotocopias, audiolibros, e-books, etc.).
Se gestiona la disponibilidad de cada ejemplar para préstamo, asegurando que solo los ejemplares disponibles puedan ser prestados.
Módulo de Préstamos:

Los alumnos pueden realizar préstamos de varios ejemplares de diferentes libros, pero no pueden tomar más de un ejemplar del mismo libro en un solo préstamo.
El sistema verifica la disponibilidad de los ejemplares antes de registrar el préstamo.
Se registran las fechas de inicio y devolución de los préstamos.
El sistema permite parametrizar los días de préstamo a domicilio y los días de suspensión por incumplimiento en la devolución de libros a través de una tabla en la base de datos.

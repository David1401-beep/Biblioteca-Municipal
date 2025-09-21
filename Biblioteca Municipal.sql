CREATE DATABASE BibliotecaMunicipal;
GO
USE BibliotecaMunicipal;
GO


CREATE TABLE Roles (
    IdRol INT PRIMARY KEY IDENTITY(1,1),
    NombreRol VARCHAR(50) NOT NULL
);

CREATE TABLE Usuarios (
    IdUsuario INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    Telefono VARCHAR(20),
    Contraseña VARCHAR(100) NOT NULL,
    IdRol INT NOT NULL FOREIGN KEY REFERENCES Roles(IdRol)
);

CREATE TABLE Categorias (
    IdCategoria INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL
);

CREATE TABLE Editoriales (
    IdEditorial INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Pais VARCHAR(50)
);

CREATE TABLE Libros (
    IdLibro INT PRIMARY KEY IDENTITY(1,1),
    Titulo VARCHAR(200) NOT NULL,
    Autor VARCHAR(100) NOT NULL,
    AñoPublicacion INT,
    Disponible BIT DEFAULT 1,
    IdCategoria INT NOT NULL FOREIGN KEY REFERENCES Categorias(IdCategoria),
    IdEditorial INT NOT NULL FOREIGN KEY REFERENCES Editoriales(IdEditorial)
);

CREATE TABLE Prestamos (
    IdPrestamo INT PRIMARY KEY IDENTITY(1,1),
    IdUsuario INT NOT NULL FOREIGN KEY REFERENCES Usuarios(IdUsuario),
    IdLibro INT NOT NULL FOREIGN KEY REFERENCES Libros(IdLibro),
    FechaPrestamo DATE NOT NULL,
    FechaDevolucion DATE NULL,
    Multa DECIMAL(10,2) DEFAULT 0
);

CREATE TABLE Devoluciones (
    IdDevolucion INT PRIMARY KEY IDENTITY(1,1),
    IdPrestamo INT NOT NULL UNIQUE FOREIGN KEY REFERENCES Prestamos(IdPrestamo),
    FechaDevolucion DATE NOT NULL,
    Observaciones VARCHAR(200)
);




INSERT INTO Roles (NombreRol) VALUES ('Administrador'), ('Bibliotecario');


INSERT INTO Usuarios (Nombre, Apellido, Email, Telefono, Contraseña, IdRol)
VALUES 
('Admin', 'Principal', 'admin@gmail.com', '7996-2933', 'admin123', 1),
('Mario', 'López', 'MarioLopez@gmail.com', '6110-7145', 'mario123', 2),
('Lucía', 'García', 'LuciaGacrcia@gmail.com', '7887-7862', 'lucia123', 2);


INSERT INTO Categorias (Nombre) VALUES ('Novela'), ('Ciencia'), ('Historia');


INSERT INTO Editoriales (Nombre, Pais) VALUES ('Planeta', 'España'), ('Pearson', 'USA');


INSERT INTO Libros (Titulo, Autor, AñoPublicacion, Disponible, IdCategoria, IdEditorial)
VALUES 
('Don Quijote', 'Cervantes', 1605, 1, 1, 1),
('Breves Respuestas a las Grandes Preguntas', 'Stephen Hawking', 2018, 1, 2, 2),
('El Libro Troll', 'Rubius', 2014, 1, 3, 1);


INSERT INTO Prestamos (IdUsuario, IdLibro, FechaPrestamo) 
VALUES (2, 1, GETDATE());


INSERT INTO Devoluciones (IdPrestamo, FechaDevolucion, Observaciones)
VALUES (1, GETDATE(), 'Buen estado');

select *from Devoluciones
select *from Libros
select *from Roles
select *from Editoriales
select *from Categorias
select *from Usuarios
select *from Prestamos
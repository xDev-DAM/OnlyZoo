CREATE DATABASE OnlyZoo;

USE OnlyZoo;

CREATE TABLE usuario (
	id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
	nombre VARCHAR(255),
	contrasena VARCHAR(255),
	ALIAS VARCHAR(255),
	email VARCHAR(255),
	imagen VARCHAR(255));
	 
CREATE TABLE merchandising(
	id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
	nombre VARCHAR(255),
	ALIAS VARCHAR(255),
	descripcion VARCHAR(255),
	stock INT, 
	precio DECIMAL(10, 2),
	imagen VARCHAR(255));
	 
CREATE TABLE especie(
	id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
	nombre VARCHAR(255));
	 
CREATE TABLE producto(
	id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
	nombre VARCHAR(255),
	descripcion VARCHAR(255),
	id_especie INT, stock INT, 
	precio DECIMAL(10, 2),
   imagen VARCHAR(255), 
	FOREIGN KEY (id_especie) REFERENCES especie(ID));
	
CREATE TABLE mascota(
	id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
	nombre VARCHAR(255),
	raza VARCHAR(255),
	descripcion VARCHAR(255),
	id_especie INT, stock INT,
	precio DECIMAL(10, 2),
	imagen VARCHAR(255), 
	FOREIGN KEY (id_especie) REFERENCES especie(ID));
	
CREATE TABLE plan(
	id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
	nombre VARCHAR(255),
	descripcion VARCHAR(255),
	precio DECIMAL(10, 2));
	
CREATE TABLE usuario_plan(
	id_usuario INT NOT NULL,
	id_plan INT NOT NULL, 
	PRIMARY KEY (id_plan,id_usuario), 
	FOREIGN KEY (id_usuario) REFERENCES usuario(id), 
	FOREIGN KEY (id_plan) REFERENCES plan(id));
	
CREATE TABLE producto_plan(
	id_producto INT NOT NULL,
	id_plan INT NOT NULL, 
	PRIMARY KEY (id_plan,	 id_producto), 
	FOREIGN KEY (id_producto) REFERENCES producto(id), 
	FOREIGN KEY (id_plan) REFERENCES plan(id));
	 
CREATE TABLE usuario_mascota( 
   id_usuario INT NOT NULL,
	id_mascota INT NOT NULL, 
	PRIMARY KEY (id_mascota,id_usuario),
	FOREIGN KEY (id_usuario) REFERENCES usuario(id), 
	FOREIGN KEY (id_mascota) REFERENCES mascota(id));
	 
CREATE TABLE usuario_producto(
   id_usuario INT NOT NULL,
	id_producto INT NOT NULL, 
	PRIMARY KEY (id_producto,id_usuario), 
	FOREIGN KEY (id_usuario) REFERENCES usuario(id), 
	FOREIGN KEY (id_producto) REFERENCES producto(id));
	 
CREATE TABLE usuario_merch(
   id_usuario INT NOT NULL,
	id_merch INT NOT NULL, PRIMARY KEY (id_merch,
	id_usuario), FOREIGN KEY (id_usuario) REFERENCES usuario(id), 
	FOREIGN KEY (id_merch) REFERENCES merchandising(id));

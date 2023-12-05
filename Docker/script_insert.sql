-- select this database;

USE OnlyZoo;

-- inserts into especie

INSERT INTO especie(nombre) VALUES('ave'),('pez'),('perro'),('gato');

-- insert into mascota

INSERT INTO mascota(nombre,raza,descripcion,id_especie,stock,precio,imagen) 
VALUES('Loro','Loro de frente naranja','Esta raza de loros son muy simpáticos y sociables',1,10,325.36,'image/pet/loro.jpg'),
('Camada gatos calvos','sphynx','Camada de simpáticos gatos sin un solo pelo. Despreocúpate de los pelos en el sofá',4,4,499.99,'image/pet/gatocalvo.jpg'),
('Cachorro Setter','Setter inglés','Bonitos cachorros de setter inglés disponibles para cazar o animal de compañía',3,8,450.43,'image/pet/setter.jpg'),
('Pez guppy','Poecilia reticulata','Este pez de agua dulce, proveniente del Caribe, es sin duda uno de los peces de acuario más conocidos. El guppy es considerado fácil de mantener y por lo tanto perfecto para principiantes',2,20,29.43,'image/pet/guppy.jpeg'),
('Pez molly negro','Poecilia sphenops','Este popular pez ornamental es la versión negra del pez molly común que habita en América del Sur y América Central',2,58,20.43,'image/pet/molly.jpeg'),
('Gato británico','British Shorthair','Es una raza relativamente grande que podría describirse como gruesa o fornida. Tiene muchos contornos redondeados: la cara y las mejillas, las orejas, los ojos y la cabeza',4,30,120.43,'image/pet/british.jpeg');

-- insert into merchespecie

ALTER TABLE merchandising DROP COLUMN ALIAS;

INSERT INTO merchandising(nombre, descripcion, stock, precio, imagen) 
VALUES('Camiseta gato feliz','Una camiseta que te alegrará el día a ti y a todo el que te cruces',20,15.25,'image/merch/gatofeliz.jpg'),
('Gorra pajaro','Esta gorra más que parar el sol te dará alas',20,8.00,'image/merch/gorrapajaro.jpg'),
('Camiseta OnlyZoo','Camiseta blanca con nuestro logo en colaboración con Versace',100, 211.30,'image/merch/camionlyzoo.png'),
('Figura agallas','Muñeco del icónico personaje de cartoon network',5,10.32,'image/merch/agallas.jpg'),
('Taza perro','Una graciosa taza con forma de perrete',10,5.10,'image/merch/tazaperro.jpg'),
('Gorra OnlyZoo','Nuestra  gorra oficial de cuero de toro negro, nos importan los animales',20,95.98,'image/merch/gorraonlyzoo.png'),
('Funda movil OnlyZoo','Funda con nuestro maravilloso logo',200,5.32,'image/merch/fundaonlyzoo.png');

-- insert into plan

INSERT INTO plan(nombre, descripcion, precio) 
VALUES('Bronce','Nuestro plan más humilde para bolsillos rotos, recibirás ofertas y nuestra revista mensual',3.99),
('Plata','Podrás acceder a ofertas exclusivas, nuestra revista y recibirás una camiseta de OnlyZoo en la puerta de tu casa',9.99),
('Oro','Con esta suscripción recibirás un outfit completo de OnlyZoo, suscripción a ofertas y nuestra revista. Los 2 primeros recibirán un canario.',15.99);

-- insert into producto

ALTER TABLE producto DROP COLUMN ALIAS;

INSERT INTO producto(nombre,descripcion,id_especie,stock,precio,imagen) 
VALUES('Saco de comida para pájaros','20 kilos de sabrosura para tus aves',1,5,35.99,'image/product/sacoave.jpg'),
('Pienso para perros famélicos','30 kilos de sabrosura para tus perros flacos',3,55,58.99,'image/product/sacoperro.jpg'),
('Croquetas para felinos esterilizados','20 kilos de sabrosura para gatitos capados',4,100,12.99,'image/product/sacogato.jpg'),
('Correa estranguladora','ahorca a tu mascota con estilo',3,20,23.43,'image/product/correa.jpg'),
('Juguete para gatos','juega con tu gato con este plumero super fantastico',4,78,5.99,'image/product/juguete.jpg'),
('Planta para acuario','Amenízale la existencia a tu infeliz pescado con esta platita',2,45,13.23,'image/product/planta.jpg'),
('Saquito comida pez','Rico alimento para peces y pececitos',2,45,22.23,'image/product/sacopez.jpg');

-- insert into usuario

ALTER TABLE usuario RENAME COLUMN ALIAS TO username;

INSERT INTO usuario(nombre, contrasena, username, email, imagen) 
VALUES('Martin Ramonda','1234martin','slimm1','tini.ramonda@gmail.com','image/user/martin.png'),
('Jose García','1234jose','hachecl','jose@gmail.com','image/user/jose.png'),
('Guillermo De Carlos','1234guille','guilledcm','guille@gmail.com','image/user/guille.png');

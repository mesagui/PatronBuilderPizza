CREATE DATABASE Pizza
go

USE Pizza
go 

CREATE TABLE Pizza(
    idPizza int PRIMARY KEY IDENTITY,
    masa VARCHAR(50),
    salsa VARCHAR(50),
    relleno VARCHAR(50),
    tamanio VARCHAR(50)
)

SELECT * FROM Pizza
DELETE FROM Pizza
DROP TABLE Pizza
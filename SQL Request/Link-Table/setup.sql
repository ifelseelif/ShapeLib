use tempdb

CREATE TABLE Products
(
    Id INT PRIMARY KEY,
    Name NVARCHAR(20) NOT NULL
)

CREATE TABLE Category
(
    Id INT PRIMARY KEY,
    Name NVARCHAR(20) NOT NULL
)

CREATE TABLE Product_Category
(
    Id INT PRIMARY KEY,
    Product_Id int NOT NULL FOREIGN KEY REFERENCES Products(Id),
    Category_Id int         FOREIGN KEY REFERENCES Category(Id)
)

INSERT INTO Products VALUES (1, N'Помидор')
INSERT INTO Products VALUES (2, N'Огурец')
INSERT INTO Products VALUES (3, N'Масло')
INSERT INTO Products VALUES (4, N'Орех')
INSERT INTO Products VALUES (5, N'Груша Морская')
INSERT INTO Products VALUES (6, N'Икра')
INSERT INTO Products VALUES (7, N'Творог')
INSERT INTO Products VALUES (8, N'Ежевика')

INSERT INTO Category Values (1, N'Овощи')
INSERT INTO Category Values (2, N'Молочные продукты')
INSERT INTO Category Values (3, N'Фрукт')
INSERT INTO Category Values (4, N'Морепродукты')
INSERT INTO Category Values (5, N'Ягоды')

INSERT INTO Product_Category VALUES (1, 1, 1)
INSERT INTO Product_Category VALUES (2, 2, 1)
INSERT INTO Product_Category VALUES (3, 3, 2)
INSERT INTO Product_Category VALUES (4, 4, NULL)
INSERT INTO Product_Category VALUES (5, 5, 3)
INSERT INTO Product_Category VALUES (6, 6, 4)
INSERT INTO Product_Category VALUES (7, 7, 2)
INSERT INTO Product_Category VALUES (8, 8, 5)
INSERT INTO Product_Category VALUES (9, 5, 4)

SELECT P.Name as "Имя продукта", C.Name as "Категория"
FROM Product_Category 
    JOIN Products P on P.Id = Product_Category.Product_Id 
    LEFT JOIN Category C on C.Id = Product_Category.Category_Id
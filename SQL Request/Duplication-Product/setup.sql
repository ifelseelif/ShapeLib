use tempdb

CREATE TABLE Category
(
    Id INT PRIMARY KEY,
    Name NVARCHAR(20) NOT NULL
)

CREATE TABLE Products
(
    Id INT PRIMARY KEY,
    Name NVARCHAR(20) NOT NULL,
    Category_Id int FOREIGN KEY REFERENCES Category(Id)
)

INSERT INTO Category Values (1, N'Овощи')
INSERT INTO Category Values (2, N'Молочные продукты')
INSERT INTO Category Values (3, N'Фрукт')
INSERT INTO Category Values (4, N'Морепродукты')
INSERT INTO Category Values (5, N'Ягоды')    
    
INSERT INTO Products VALUES (1, N'Помидор', 1)
INSERT INTO Products VALUES (2, N'Огурец', 1)
INSERT INTO Products VALUES (3, N'Масло', 2)
INSERT INTO Products VALUES (4, N'Орех', NULL)
INSERT INTO Products VALUES (5, N'Груша Морская', 3)
INSERT INTO Products VALUES (6, N'Икра', 4)
INSERT INTO Products VALUES (7, N'Творог', 2)
INSERT INTO Products VALUES (8, N'Ежевика', 5)
INSERT INTO Products VALUES (9, N'Груша Морская', 4)

SELECT Products.Name as "Имя продукта", C.Name as "Категория" 
FROM Products 
    LEFT JOIN Category C on C.Id = Products.Category_Id
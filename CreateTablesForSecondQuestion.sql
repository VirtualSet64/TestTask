CREATE TABLE Product
(
    Id INT PRIMARY KEY,
    Name NVARCHAR(max)
)

CREATE TABLE Category
(
    Id INT PRIMARY KEY,
    Name NVARCHAR(max)
)

CREATE TABLE ProductsCategories
(
    Id INT PRIMARY KEY,
    ProductId INT REFERENCES Product (Id),
	CategoryId INT REFERENCES Category (Id),
)
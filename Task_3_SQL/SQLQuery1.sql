CREATE TABLE [dbo].[Products] (
		[ProductID]		INT		IDENTITY(1,1)	NOT NULL,
		[ProductName]	NVARCHAR (50)			NOT NULL,
		[SupplierID]	INT						NOT NULL,
		[CategoryID]	INT						NOT NULL,
		[Price]			FLOAT					NOT NULL,
		PRIMARY KEY CLUSTERED ([ProductID] ASC)


);

CREATE TABLE [dbo].[Suppliers]  (
		[SupplierID]	INT		IDENTITY(1,1)	NOT NULL,
		[SupplierName]	NVARCHAR (50)			NOT NULL,
		[City]			NVARCHAR (50)			NOT NULL,
		[Country]		NVARCHAR (50)			NOT NULL,

		PRIMARY KEY CLUSTERED ([SupplierID] ASC)

);

CREATE TABLE [dbo].[Categories]  (
		[CategoryID]	INT		IDENTITY(1,1)	NOT NULL,
		[CategoryName]	NVARCHAR (50)			NOT NULL,
		[Description]	NVARCHAR (90)			NOT NULL,

		PRIMARY KEY CLUSTERED ([CategoryID] ASC)

);

ALTER TABLE Products
ADD CONSTRAINT FK_Suppliers_SuplierID FOREIGN KEY (SuppllerID)
      REFERENCES Suppliers (SupplierID)
	  ON UPDATE CASCADE
	  ON DELETE CASCADE

ALTER TABLE Products
ADD CONSTRAINT FK_Categories_CategoryID FOREIGN KEY (CategoryID)
      REFERENCES Categories (CategoryID)
	  ON UPDATE CASCADE
	  ON DELETE CASCADE



INSERT INTO Categories (CategoryName, [Description]) VALUES (N'Beverages', N'Soft drinks, coffees, teas, beers, and ales')
INSERT INTO Categories (CategoryName, [Description]) VALUES (N'Condiments', N'Sweet and savory sauces, relishes, spreads, and seasonings')
INSERT INTO Categories (CategoryName, [Description]) VALUES (N'Confections', N'Desserts, candies, and sweet breads')
INSERT INTO Categories (CategoryName, [Description]) VALUES (N'Dairy Products', N'Cheeses')
INSERT INTO Categories (CategoryName, [Description]) VALUES (N'Grains/Cereals', N'Breads, crackers, pasta, and cereal')


INSERT INTO Suppliers (SupplierName, City, Country) VALUES (N'Exotic Liquid', N'London', N'UK')
INSERT INTO Suppliers (SupplierName, City, Country) VALUES (N'New Orleans Cajun Delights', N'New Orleans', N'USA')
INSERT INTO Suppliers (SupplierName, City, Country) VALUES (N'Grandma Kelly’s Homestead', N'Ann Arbor', N'USA')
INSERT INTO Suppliers (SupplierName, City, Country) VALUES (N'Tokyo Traders', N'Tokyo', N'Japan')
INSERT INTO Suppliers (SupplierName, City, Country) VALUES (N'Cooperativa de Quesos ‘Las Cabras’', N'Oviedo', N'Spain')

INSERT INTO Products (ProductName, SuppllerID, CategoryID, Price) VALUES (N'Chais',1,1,18.00)
INSERT INTO Products (ProductName, SuppllerID, CategoryID, Price) VALUES (N'Chang',1,1,19.00)
INSERT INTO Products (ProductName, SuppllerID, CategoryID, Price) VALUES (N'Aniseed Syrup',1,2,10.00)
INSERT INTO Products (ProductName, SuppllerID, CategoryID, Price) VALUES (N'Chef Anton’s Cajun Seasoning',2,2,22.00)
INSERT INTO Products (ProductName, SuppllerID, CategoryID, Price) VALUES (N'Chef Anton’s Gumbo Mix',2,2,21.35)



/* 	Select product with product name that begins with ‘C’.    */
SELECT * FROM Products WHERE ProductName LIKE '%C%' 

/* 	Select product with the smallest price*/
SELECT MIN(Price) AS MinPrice FROM Products  

/* 	Select cost of all products from the USA.*/
SELECT SUM(Price) AS Price
FROM Products JOIN Suppliers ON  Products.SuppllerID = Suppliers.SupplierID WHERE Suppliers.Country LIKE 'USA'

/* 	Select suppliers that supply Condiments*/
SELECT SupplierName As SupplierName 
FROM Products 
JOIN Suppliers ON Products.SuppllerID = Suppliers.SupplierID 
JOIN Categories ON Products.SuppllerID = Categories.CategoryID 
WHERE Categories.[Description] LIKE 'Condiments'

/* 	Add to database new supplier with name*/
INSERT INTO Suppliers (SupplierName, City, Country) VALUES (N'Norske Meierier', N'Lviv', N'Ukraine')
INSERT INTO Products (ProductName, SuppllerID, CategoryID, Price) VALUES (N'Green tea',6,1,10.00)
CREATE DATABASE	OnlineBookStore

USE OnlineBookStore

-- CREATE TABLES --

CREATE TABLE Authors
(
	ID int PRIMARY KEY,
	FirstName varchar(25),
	LastName varchar(25),
	Email nvarchar(25),
	Gender varchar(10)
)

CREATE TABLE Publishers
(
	ID int PRIMARY KEY,
	Name varchar(25),
	Email nvarchar(25),
	Contact nvarchar(20),
	Address nvarchar(100)
)

CREATE TABLE Books
(
	ID int PRIMARY KEY,
	Name varchar(25),
	Email nvarchar(25),
	Contact nvarchar(20),
	Address nvarchar(100),
	AuthorID int FOREIGN KEY REFERENCES Authors(ID),
	PublisherID int FOREIGN KEY REFERENCES Publishers(ID)
)
ALTER TABLE	Books
DROP COLUMN
	Name, Email, Contact, Address

ALTER TABLE	Books
ADD
	Title varchar(100),
	ISBN int,
	Price int,
	Year int

CREATE TABLE Customers
(
	ID int PRIMARY KEY,
	FirstName varchar(25),
	LastName varchar(25),
	Email nvarchar(25),
	Gender varchar(10),
	Contact nvarchar(20),
	Address nvarchar(100)
)

CREATE TABLE Orders
(
	ID int PRIMARY KEY,
	OrderDate Date,
	ShippingMethod varchar(25),
	DeliveryDate Date,
	DeliveryCharges int,
	DeliveryStatus varchar(10),
	CustomerID int FOREIGN KEY REFERENCES Customers(ID)
)

CREATE TABLE OrderItem
(
	ID int PRIMARY KEY,
	Quantity int,
	Price int,
	OrderID int FOREIGN KEY REFERENCES Orders(ID),
	BookID int FOREIGN KEY REFERENCES Books(ID)
)
ALTER TABLE OrderItem
DROP COLUMN Price

-- STORED PROCEDURES - CRUD --

-- Authors Create/Update --
GO
CREATE PROCEDURE AuthorCU
	@ID int,
	@FirstName varchar(25),
	@LastName varchar(25),
	@Email nvarchar(25),
	@Gender varchar(10),
	@Action varchar(10)
	AS BEGIN
		SET NOCOUNT ON;
		if @Action = 'C'
		BEGIN
			INSERT INTO Authors(ID,FirstName, LastName, Email, Gender)
			VALUES (@ID, @FirstName, @LastName, @Email, @Gender)
		END
		if @Action = 'U'
		BEGIN
			UPDATE Authors
			SET 		
				FirstName = @FirstName,
				LastName = @LastName,
				Email = @Email,
				Gender = @Gender
			WHERE ID = @ID
		END
	END
GO

EXEC AuthorCU
	@ID=1,
	@FirstName='Saba',
	@LastName='Mukhtar',
	@Email='saba@gmail.com',
	@Gender='Female',
	@Action='C'

EXEC AuthorCU
	@ID=1,
	@FirstName='1',
	@LastName='1',
	@Email='1',
	@Gender='1',
	@Action='U'


-- Publisher Create/Update --
GO
CREATE PROCEDURE PublisherCU
	@ID int,
	@Name varchar(25),
	@Email nvarchar(25),
	@Contact nvarchar(20),
	@Address nvarchar(100),
	@Action varchar(10)
	AS BEGIN
		SET NOCOUNT ON;
		if @Action = 'C'
		BEGIN
			INSERT INTO Publishers(ID, Name, Email, Contact, Address)
			VALUES (@ID, @Name, @Email, @Contact, @Address)
		END
		if @Action = 'U'
		BEGIN
			UPDATE Publishers
			SET 		
				Name = @Name,
				Email = @Email,
				Contact = @Contact,
				Address = @Address
			WHERE ID = @ID
		END
	END
GO

EXEC PublisherCU
	@ID=1,
	@Name='Saba',
	@Email='saba@gmail.com',
	@Contact = '03130000000',
	@Address = 'RWP, PK',
	@Action='C'

EXEC PublisherCU
	@ID=1,
	@Name='Saba',
	@Email='saba@gmail.com',
	@Contact = '03360000000',
	@Address = 'RWP, PK',
	@Action='U'


-- Books Create/Update --
GO
CREATE PROCEDURE BookCU
	@ID int,
	@Title varchar(100),
	@ISBN int,
	@Price int,
	@Year int,
	@AuthorID int,
	@PublisherID int,
	@Action varchar(10)
	AS BEGIN
		SET NOCOUNT ON;
		if @Action = 'C'
		BEGIN
			INSERT INTO Books(ID, Title, ISBN, Price, Year, AuthorID, PublisherID)
			VALUES (@ID, @Title, @ISBN, @Price, @Year, @AuthorID, @PublisherID)
		END
		if @Action = 'U'
		BEGIN
			UPDATE Books
			SET 		
				Title = @Title,
				ISBN = @ISBN,
				Price = @Price,
				Year = @Year,
				AuthorID = @AuthorID,
				PublisherID = @PublisherID
			WHERE ID = @ID
		END
	END
GO

EXEC BookCU
	@ID=1,
	@Title='ABC',
	@ISBN=1011,
	@Price = 2500,
	@Year = 2023,
	@AuthorID = 1,
	@PublisherID  = 1,
	@Action='C'

EXEC BookCU
	@ID=1,
	@Title='ABCDE',
	@ISBN=1011,
	@Price = 3000,
	@Year = 2023,
	@AuthorID = 1,
	@PublisherID  = 1,
	@Action='U'


-- Customers Create/Update --
GO
CREATE PROCEDURE CustomerCU
	@ID int,
	@FirstName varchar(25),
	@LastName varchar(25),
	@Email nvarchar(25),
	@Gender varchar(10),
	@Contact nvarchar(20),
	@Address nvarchar(100),
	@Action varchar(10)
	AS BEGIN
		SET NOCOUNT ON;
		if @Action = 'C'
		BEGIN
			INSERT INTO Customers(ID,FirstName, LastName, Email, Gender, Contact, Address)
			VALUES (@ID, @FirstName, @LastName, @Email, @Gender, @Contact, @Address)
		END
		if @Action = 'U'
		BEGIN
			UPDATE Customers
			SET 		
				FirstName = @FirstName,
				LastName = @LastName,
				Email = @Email,
				Gender = @Gender,
				Contact = @Contact,
				Address = @Address
			WHERE ID = @ID
		END
	END
GO

EXEC CustomerCU
	@ID=1,
	@FirstName='Saba',
	@LastName='Yashfeen',
	@Email='saba@gmail.com',
	@Gender='Female',
	@Contact = '03130000000',
	@Address = 'RWP, PK',
	@Action='C'

EXEC CustomerCU
	@ID=1,
	@FirstName='Saba',
	@LastName='Mukhtar',
	@Email='saba@gmail.com',
	@Gender='Female',
	@Contact = '03360000000',
	@Address = 'RWP, PK',
	@Action='U'


-- Orders Create/Update --
GO
CREATE PROCEDURE OrderCU
	@ID int,
	@OrderDate date,
	@ShippingMethod varchar(25),
	@DeliveryDate date,
	@DeliveryCharges int,
	@DeliveryStatus varchar(10),
	@CustomerID int,
	@Action varchar(10)
	AS BEGIN
		SET NOCOUNT ON;
		if @Action = 'C'
		BEGIN
			INSERT INTO Orders(ID, OrderDate, ShippingMethod, DeliveryDate, DeliveryCharges, DeliveryStatus, CustomerID)
			VALUES (@ID, @OrderDate, @ShippingMethod, @DeliveryDate, @DeliveryCharges, @DeliveryStatus, @CustomerID)
		END
		if @Action = 'U'
		BEGIN
			UPDATE Orders
			SET 		
				OrderDate = @OrderDate,
				ShippingMethod = @ShippingMethod,
				DeliveryDate = @DeliveryDate,
				DeliveryCharges = @DeliveryCharges,
				DeliveryStatus = @DeliveryStatus,
				CustomerID = @CustomerID
			WHERE ID = @ID
		END
	END
GO

EXEC OrderCU
	@ID=1,
	@OrderDate='2023-03-09',
	@ShippingMethod='COD',
	@DeliveryDate='2023-03-22',
	@DeliveryCharges='0',
	@DeliveryStatus = 'In Progress',
	@CustomerID = 1,
	@Action='C'

EXEC OrderCU
	@ID=1,
	@OrderDate='2023-03-09',
	@ShippingMethod='COD',
	@DeliveryDate='2023-03-22',
	@DeliveryCharges='0',
	@DeliveryStatus = 'Completed',
	@CustomerID = 1,
	@Action='U'


-- OrderItem Create/Update --
GO
CREATE PROCEDURE OrderItemCU
	@ID int,
	@Quantity int,
	@OrderID int,
	@BookID int,
	@Action varchar(10)
	AS BEGIN
		SET NOCOUNT ON;
		if @Action = 'C'
		BEGIN
			INSERT INTO OrderItem(ID, Quantity, OrderID, BookID)
			VALUES (@ID, @Quantity, @OrderID, @BookID)
		END
		if @Action = 'U'
		BEGIN
			UPDATE OrderItem
			SET 		
				Quantity = @Quantity,
				OrderID = @OrderID,
				BookID = @BookID
			WHERE ID = @ID
		END
	END
GO

EXEC OrderItemCU
	@ID=1,
	@Quantity=5,
	@OrderID=1,
	@BookID=1,
	@Action='C'

EXEC OrderItemCU
	@ID=1,
	@Quantity=3,
	@OrderID=1,
	@BookID=1,
	@Action='U'


--DROP PROCEDURE AuthorCU

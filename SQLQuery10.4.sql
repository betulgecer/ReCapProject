CREATE TABLE Users(
Id int PRIMARY KEY IDENTITY(1,1),
FirstName nvarchar(25),
LastName nvarchar(25),
Email nvarchar(100),
Password binary(500),
)

CREATE TABLE Customers(
UserId int PRIMARY KEY IDENTITY(1,1),
CompanyName nvarchar(200),
FOREIGN KEY (UserId) REFERENCES Users(Id),
)

CREATE TABLE Rentals(
Id int PRIMARY KEY IDENTITY(1,1),
CarId int,
CustomerId int,
RentDate datetime,
ReturnDate datetime Null,
FOREIGN KEY (CarId) REFERENCES Cars(CarId),
FOREIGN KEY (CustomerId) REFERENCES Customers(UserId),
)
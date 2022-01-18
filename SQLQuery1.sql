CREATE TABLE Cars(
CarId int PRIMARY KEY IDENTITY(1,1),
BrandId int,
ColorId int,
ModelYear nvarchar(25),
DailyPrice decimal,
Descriptions nvarchar(250),
FOREIGN KEY (BrandId) REFERENCES Brands(BrandId),
FOREIGN KEY (ColorId) REFERENCES Colors(ColorId),
)

CREATE TABLE Brands(
BrandId int PRIMARY KEY IDENTITY(1,1),
BrandName nvarchar(50),
)

CREATE TABLE Colors(
ColorId int PRIMARY KEY IDENTITY(1,1),
ColorName nvarchar(50),
)
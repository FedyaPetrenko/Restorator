create database Restorator;
use Restorator;

drop table Products;
drop table Dishes;
drop table Guests;
drop table Visits;
drop table Employees;

create table Products
(
IDProduct int IDENTITY NOT NULL primary key,
IDDish int NOT NULL foreign key references Dishes(IDDish),
BarCode nchar(10) NOT NULL CHECK (BarCode LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
Name nvarchar(50) NOT NULL,
Descript nvarchar(max) NOT NULL,
Price int NOT NULL
);

create table Dishes
(
IDDish int IDENTITY NOT NULL primary key,
IDGuest int NOT NULL foreign key references Guests(IDGuest),
Name nvarchar(50) NOT NULL,
TypeOfMeals nvarchar(50) NOT NULL,
Composition nvarchar(max) NOT NULL,
WeightDish int NOT NULL,
Price int NOT NULL,
);

create table Guests
(
IDGuest int IDENTITY(1,1) NOT NULL primary key,
IDEmployee int NOT NULL,
FirstName nvarchar(50) NOT NULL,
SecondName nvarchar(50) NOT NULL,
ThirdName nvarchar(50) NOT NULL,
PhoneNumber nvarchar(10) NOT NULL CHECK (PhoneNumber LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
Email nvarchar(50) NULL,
CardNumber nchar(10) NOT NULL CHECK (CardNumber LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
foreign key references Employees(IDEmployee)
);

create table Visits
(
IDVisiting int IDENTITY NOT NULL primary key,
IDGuest int NOT NULL foreign key references Guests(IDGuest),
DateAndTime smalldatetime NOT NULL,
NumberOfVisits int NOT NULL,
AllMoney money NOT NULL,
PercentageDiscounts int NOT NULL,
FavoriteDishes nvarchar(max) NOT NULL,
Complaint nvarchar(max) NOT NULL,
);

create table Employees
(
IDEmployee int IDENTITY(1,1) NOT NULL primary key,
FirstName nvarchar(50) NOT NULL,
SecondName nvarchar(50) NOT NULL,
ThirdName nvarchar(50) NOT NULL,
PhoneNumber nvarchar(12) NOT NULL CHECK (PhoneNumber LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
Email nvarchar(50) NULL,
HomeAddress nvarchar(max) NOT NULL,
IdentificationCode nchar(10) NOT NULL CHECK (IdentificationCode LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
Salary money NOT NULL,
CardNumber nvarchar(16) NOT NULL CHECK (CardNumber LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
EnterLogin nvarchar(50) NOT NULL,
EnterPassword nvarchar(50) NOT NULL
);

 
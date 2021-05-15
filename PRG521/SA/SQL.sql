CREATE DATABASE DBCtuLogistics;
USE DBCtuLogistics;


CREATE TABLE Address( 
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	CNumber INT NOT NULL,
	CName VARCHAR(25) NOT NULL,
	Street VARCHAR(50) NOT NULL,
	Suburb VARCHAR(50) NOT NULL,
	City VARCHAR(25) NOT NULL,
	Province VARCHAR(25) NOT NULL,
	Country VARCHAR(25) NOT NULL,
	PostalCode INT NOT NULL
);


CREATE TABLE Customer( 
	Customerid INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FullName VARCHAR(100) NOT NULL,
	ContactNumber VARCHAR(11) NULL,
	Email VARCHAR(60) NULL,
	Addressid INT NULL
);


CREATE TABLE Freight( 
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Customerid INT NULL,
	Height DECIMAL(13, 2) NULL,
	Weight DECIMAL(13, 2) NULL,
	Lenght DECIMAL(13, 2) NULL,
	DestinationAddressid INT NULL,
	OriginAddressid INT NULL,
	Statusid int NULL,
	Date DATE NULL,
	FOREIGN KEY (Customerid) REFERENCES Customer(Customerid)
);


CREATE TABLE Status( 
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Status VARCHAR(50) NULL,
	DatePickedUp VARCHAR(15) NULL,
	DateDelivered VARCHAR(15) NULL,
	DriverID VARCHAR(10) NULL
);


CREATE TABLE Driver( 
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FullName VARCHAR(100) NOT NULL,
	LicenseType VARCHAR(15) NOT NULL,
	Owner VARCHAR(50) NOT NULL
);


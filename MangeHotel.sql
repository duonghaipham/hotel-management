CREATE DATABASE ManageHotel
GO

USE ManageHotel
GO

CREATE TABLE RoomCagetories
(
	id INT IDENTITY(1, 1) PRIMARY KEY,
	name NVARCHAR NOT NULL,
	kind CHAR(1) NOT NULL CHECK (kind = 'A' OR kind = 'B' OR kind = 'C'),
	note NVARCHAR NOT NULL
)
GO

CREATE TABLE RentedTicket
(
	id INT IDENTITY(1, 1) PRIMARY KEY,
	customerName NVARCHAR NOT NULL,
	customerKind NVARCHAR NOT NULL CHECK (customerKind = N'Inner' OR customerKind = N'Foreign'),
	idCard VARCHAR NOT NULL,
	address NVARCHAR NOT NULL,
	idRoom INT NOT NULL,
	rentedDay DATETIME NOT NULL,
	CONSTRAINT fk_idRoom FOREIGN KEY (idRoom) REFERENCES RoomCagetories (id)
)
GO

DROP TABLE RentedTicket
GO

ALTER TABLE RoomCagetories ALTER COLUMN name NVARCHAR(255)
GO

ALTER TABLE RoomCagetories ALTER COLUMN note NVARCHAR(255)
GO

INSERT INTO RoomCagetories (name, kind, note) VALUES (N'D??ng', 'B', N'Không có gì')
GO

ALTER TABLE RoomCagetories ADD price FLOAT
GO

EXEC sp_rename 'RoomCagetories', 'RoomCategories'
GO

ALTER TABLE RoomCategories ADD roomStatus NVARCHAR(255)
GO

ALTER TABLE RoomCategories ADD rentedDay DATETIME
GO

CREATE TABLE Customer
(
	id INT IDENTITY(1, 1) PRIMARY KEY,
	name NVARCHAR(255),
	kind NVARCHAR(255),
	identityNumber VARCHAR(50),
	address NVARCHAR(255),
	rentedDay DATETIME,
	roomName NVARCHAR(255),
	CONSTRAINT fk_room FOREIGN KEY (roomName) REFERENCES RoomCategories(name)
)
GO

DELETE FROM RoomCategories WHERE name = 'BAC'
GO

ALTER TABLE RoomCategories ADD CONSTRAINT pk_name PRIMARY KEY (id, name)
GO

ALTER TABLE RoomCategories DROP CONSTRAINT PK__RoomCage__3213E83F2BA33F61
ALTER TABLE RoomCategories ALTER COLUMN name NVARCHAR(255) NOT NULL
ALTER TABLE RoomCategories ADD CONSTRAINT pk_roomName PRIMARY KEY (name)
GO

SELECT * 
  FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS 
 WHERE TABLE_NAME = 'RoomCategories'
GO

SELECT* FROM RoomCategories
GO

SELECT* FROM Customer
GO

ALTER TABLE RoomCategories ADD countRented INT
GO

ALTER TABLE RoomCategories ADD total INT
GO

ALTER TABLE RoomCategories ADD total INT
GO

ALTER TABLE RoomCategories ALTER COLUMN rentedDay DATETIME NOT NULL
GO

ALTER TABLE RoomCategories ADD rentedDay DATETIME
GO

ALTER TABLE RoomCategories ALTER COLUMN total FLOAT
GO

SELECT * FROM Rules
GO

EXEC sp_RENAME 'Rules.rooKindPrice' , 'roomKindPrice', 'COLUMN'
GO

CREATE TABLE RoomHistory
(
	id INT IDENTITY(1, 1) PRIMARY KEY,
	name NVARCHAR(255),
	kind NVARCHAR(255),
	countRented INT,
	rentedDay DATETIME,
	total FLOAT
)
GO

CREATE TABLE CustomerHistory
(
	id INT IDENTITY(1, 1) PRIMARY KEY,
	name NVARCHAR(255),
	kind NVARCHAR(255),
	identityNumber VARCHAR(50),
	address NVARCHAR(255),
	rentedDay DATETIME,
	roomName NVARCHAR(255),
	CONSTRAINT fk_roomHistoty FOREIGN KEY (roomName) REFERENCES RoomHistory(name)
)
GO

DROP TABLE CustomerHistory
Go

ALTER TABLE RoomCategories DROP CONSTRAINT CK__RoomCageto__kind__108B795B
GO

ALTER TABLE RoomCategories ALTER COLUMN kind NVARCHAR(255)
GO

SELECT * FROM RoomHistory
GO

INSERT INTO Rules (nRoomKind, roomKindPrice, nCustomerKind, customerKindCoefficient, maximumCustomer, surchargeRatio, surchargeBeginning)
VALUES (3, N'A,150000
B,170000
C,200000', 3, N'N?i ??a,1
N??c ngoài,1
Hai qu?c t?ch,2', 2, 1.25, 2)

DBCC CHECKIDENT ('dbo.Rules', RESEED, 0)
GO

SELECT * 
  FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS 
 WHERE TABLE_NAME = 'RoomCategories'
GO

ALTER TABLE RoomCategories DROP CONSTRAINT pk_roomName
ALTER TABLE RoomCategories ADD CONSTRAINT pk_RoomCategory PRIMARY KEY (id)
GO

ALTER TABLE Customer DROP CONSTRAINT fk_room
GO

ALTER TABLE RoomCategories ADD UNIQUE (name)
GO

ALTER TABLE Customer ADD FOREIGN KEY (roomName) REFERENCES RoomCategories (name)
GO

ALTER TABLE RoomCategories DROP CONSTRAINT pk_RoomCategory
ALTER TABLE RoomCategories ADD CONSTRAINT pk_RoomCategory PRIMARY KEY (name)
CREATE TABLE Users
	(
		Id BIGINT PRIMARY KEY IDENTITY,
		[Name] VARCHAR(30) NOT NULl,
		[Password] VARCHAR(26) NOT NULL,
		ProfilePicture VARBINARY(MAX),		
		LastLoginTime DATETIME2,
		IsDeleted BIT
	)
	INSERT INTO Users
	([Name], [Password], ProfilePicture, LastLoginTime, IsDeleted)
	VALUES
	('Ivan', '1234568', NULL, '1-8-1988', 0),
	('Kiro', 'jajsd55', NULL, '6-19-1998', 1),
	('Spas', '558fasd', NULL, '10-12-1982', 0),
	('Ina', '1234995a', NULL, '12-1-1995', 1),
	('Ana', 'sfgg98d5', NULL, '1-8-1990', 0)

	ALTER TABLE Users
	DROP CONSTRAINT PK__Users__3214EC07F50E21B8


	ALTER TABLE Users
	ADD CONSTRAINT PK_IdName PRIMARY KEY(Id, [Name])

	ALTER TABLE Users
	ADD CONSTRAINT CHK_PasswordMinLength CHECK (LEN(Password) >= 5)

	ALTER TABLE Users
	ADD CONSTRAINT DF_LastLoginTime DEFAULT GETDATE() FOR LastLoginTime

	ALTER TABLE Users
	DROP CONSTRAINT PK_IdName

	ALTER TABLE Users
	ADD CONSTRAINT PK_Id PRIMARY KEY (Id)

	ALTER TABLE Users
	ADD CONSTRAINT UC_Name UNIQUE([Name])

	ALTER TABLE Users
	ADD CONSTRAINT CHK_NameMinLength CHECK (LEN(Password) >= 3)
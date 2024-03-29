CREATE DATABASE Hospital;
USE Hospital;

CREATE TABLE Doctor(
	id int identity(1,1) PRIMARY KEY CLUSTERED,
	name varchar(30),
	surname varchar(30),
	section varchar(50),
	mail varchar(50),
	phone_number varchar(10),
	address nvarchar(max)
);

CREATE TABLE Secretary(
	id int identity(1,1) PRIMARY KEY CLUSTERED,
	name varchar(30),
	surname varchar(30),
	mail varchar(50),
	phone_number varchar(10),
	address nvarchar(max)
);

CREATE TABLE User_Login_Info(
	id int identity(1,1) PRIMARY KEY CLUSTERED,
	user_name varchar(30),
	password varchar(30),
	auth_type varchar(20),
);

CREATE TRIGGER Create_User_Login_Info
ON Doctor
AFTER INSERT
AS
BEGIN

DECLARE @char CHAR = ''
DECLARE @charI INT = 0
DECLARE @password VARCHAR(100) = ''
DECLARE @len INT = 12 -- Length of Password
WHILE @len > 0
BEGIN
SET @charI = ROUND(RAND()*100,0)
SET @char = CHAR(@charI)
IF @charI > 48 AND @charI < 122
BEGIN
SET @password += @char
SET @len = @len - 1
END
END

DECLARE @name varchar(30)
DECLARE @surname varchar(30)
DECLARE @user_name varchar(30)
DECLARE @auth_type varchar(20)

SELECT @name=name FROM INSERTED
SELECT @surname=surname FROM INSERTED
SELECT @user_name = LOWER(@name + @surname)
SELECT @user_name = REPLACE(@user_name,' ', '')
SELECT @auth_type = 'Doctor'

INSERT User_Login_Info VALUES (@user_name,@password,@auth_type)

END

DROP TRIGGER Create_User_Login_Info

CREATE PROCEDURE fetch_user_data
@user_name varchar(30),
@password varchar(30),
@auth_type varchar(20)
AS
BEGIN
SELECT user_name,password,auth_type FROM User_Login_Info WHERE user_name = @user_name AND password=@password AND auth_type=@auth_type
END

EXEC fetch_user_data 'Selim CanASLAN','>JaBSAP\46J8','Doctor'


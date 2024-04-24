CREATE DATABASE Hospital;
USE Hospital;

CREATE TABLE Doctor(
	id int identity(1,1) PRIMARY KEY CLUSTERED,
	tc_no varchar(11) UNIQUE,
	name varchar(30),
	surname varchar(30),
	section varchar(50),
	mail varchar(50),
	phone_number varchar(10) UNIQUE,
	address nvarchar(max)
);

CREATE TABLE Secretary(
	id int identity(1,1) PRIMARY KEY CLUSTERED,
	tc_no varchar(11) UNIQUE,
	name varchar(30),
	surname varchar(30),
	mail varchar(50) UNIQUE,
	phone_number varchar(10) UNIQUE,
	address nvarchar(max)
);

CREATE TABLE User_Login_Info(
	id int identity(1,1) PRIMARY KEY CLUSTERED,
	user_name varchar(30),
	password varchar(30),
	auth_type varchar(20),
);

/* Triggering to create user login info after inserting on Secretary table  */
CREATE TRIGGER Create_User_Login_Info_For_Secretary
ON Secretary
AFTER INSERT
AS
BEGIN

DECLARE @name varchar(30)
DECLARE @surname varchar(30)
DECLARE @user_name varchar(30)
DECLARE @auth_type varchar(20)
DECLARE @password varchar(30)

SELECT @name=name FROM INSERTED
SELECT @surname=surname FROM INSERTED
SELECT @user_name = LOWER(@name + @surname)
SELECT @user_name = REPLACE(@user_name,' ', '')
SELECT @auth_type = 'Secretary'
SELECT @password = @user_name

INSERT User_Login_Info VALUES (@user_name,@password,@auth_type)
SELECT @user_name
END

/* Triggering to create user login info after inserting on Doctor table  */
CREATE TRIGGER Create_User_Login_Info_For_Doctor
ON Doctor
AFTER INSERT
AS
BEGIN

DECLARE @name varchar(30)
DECLARE @surname varchar(30)
DECLARE @user_name varchar(30)
DECLARE @auth_type varchar(20)
DECLARE @password varchar(30)

SELECT @name=name FROM INSERTED
SELECT @surname=surname FROM INSERTED
SELECT @user_name = LOWER(@name + @surname)
SELECT @user_name = REPLACE(@user_name,' ', '')
SELECT @auth_type = 'Doctor'
SELECT @password = @user_name

INSERT User_Login_Info VALUES (@user_name,@password,@auth_type)
SELECT @user_name
END

CREATE PROCEDURE [dbo].[fetch_user_data]
@user_name varchar(30),
@password varchar(30),
@auth_type varchar(20)
AS
BEGIN
SELECT user_name,password,auth_type FROM User_Login_Info WHERE user_name = @user_name AND password=@password AND auth_type=@auth_type
END
GO

INSERT Secretary VALUES ('21824004326','Selim Can', 'ASLAN', 'sekreterselim@gmail.com', '5442628133', 'Mersin Toroslar')
INSERT Secretary VALUES ('21824324326','Muhammet Yusuf', 'ASLAN', 'doktoryusuf@gmail.com', '5555345555', 'Mersin Toroslar')

SELECT * FROM Secretary
SELECT * FROM User_Login_Info
TRUNCATE TABLE User_Login_Info
TRUNCATE TABLE Secretary
drop table Secretary

SELECT TRIM(LOWER(name + surname)) as user_name FROM Secretary Where tc_no = '21824004326';

SELECT tc_no,name,surname,mail,phone_number,address FROM Secretary WHERE tc_no = '21824004326'


UPDATE Secretary SET name= {name}, surname={surname}, mail={mail}",phone_number = {phoneNumber}, address = {address}"
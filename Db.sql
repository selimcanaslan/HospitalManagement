CREATE DATABASE Hospital;
USE Hospital;

CREATE TABLE Doctor(
	id int identity(1,1),
	tc_no varchar(11) PRIMARY KEY CLUSTERED,
	name varchar(30),
	surname varchar(30),
	section varchar(50),
	mail varchar(50) UNIQUE,
	phone_number varchar(10) UNIQUE,
	address nvarchar(max)
);

CREATE TABLE Doctor_Login_Info(
	id int identity(1,1) PRIMARY KEY CLUSTERED,
	tc_no varchar(11) FOREIGN KEY (tc_no) REFERENCES Doctor(tc_no),
	user_name varchar(30),
	password varchar(30)
);

GO
CREATE TRIGGER Create_Doctor_Login_Info 
ON Doctor
AFTER INSERT
AS 
BEGIN

DECLARE @tc_no varchar(11)
DECLARE @name varchar(30)
DECLARE @surname varchar(30)
DECLARE @user_name varchar(30)
DECLARE @password varchar(30)

SELECT @tc_no=tc_no FROM INSERTED
SELECT @name=name FROM INSERTED
SELECT @surname=surname FROM INSERTED
SELECT @user_name = LOWER(@name + @surname)
SELECT @user_name = REPLACE(@user_name,' ', '')
SELECT @password = @user_name

INSERT Doctor_Login_Info VALUES (@tc_no,@user_name,@password)
END

CREATE TABLE Secretary(
	id int identity(1,1),
	tc_no varchar(11) PRIMARY KEY CLUSTERED,
	name varchar(30),
	surname varchar(30),
	mail varchar(50) UNIQUE,
	phone_number varchar(10) UNIQUE,
	address nvarchar(max)
);

CREATE TABLE Secretary_Login_Info(
	id int identity(1,1) PRIMARY KEY CLUSTERED,
	tc_no varchar(11) FOREIGN KEY (tc_no) REFERENCES Secretary(tc_no) ON DELETE CASCADE ON UPDATE CASCADE,
	user_name varchar(30),
	password varchar(30)
);

GO
CREATE TRIGGER Create_Secretary_Login_Info
ON Secretary
AFTER INSERT
AS
BEGIN

DECLARE @name varchar(30)
DECLARE @surname varchar(30)
DECLARE @user_name varchar(30)
DECLARE @auth_type varchar(20)
DECLARE @password varchar(30)
DECLARE @tc_no varchar(11)

SELECT @tc_no=tc_no FROM INSERTED
SELECT @name=name FROM INSERTED
SELECT @surname=surname FROM INSERTED
SELECT @user_name = LOWER(@name + @surname)
SELECT @user_name = REPLACE(@user_name,' ', '')
SELECT @auth_type = 'Secretary'
SELECT @password = @user_name

INSERT Secretary_Login_Info VALUES (@tc_no,@user_name,@password)
END

/* Triggering to create user login info after inserting on Doctor table  */

GO
CREATE PROCEDURE [dbo].[fetch_secretary_login_data]
@user_name varchar(30),
@password varchar(30)
AS
BEGIN
SELECT user_name,password FROM Secretary_Login_Info WHERE user_name = @user_name AND password=@password
END
GO

GO
CREATE PROCEDURE [dbo].[fetch_doctor_login_data]
@user_name varchar(30),
@password varchar(30)

AS
BEGIN
SELECT user_name,password FROM Doctor_Login_Info WHERE user_name = @user_name AND password=@password
END
GO

INSERT Secretary VALUES ('21824004326','Selim Can', 'ASLAN', 'sekreterselim@gmail.com', '5442628133', 'Mersin Toroslar')
INSERT Secretary VALUES ('21824324326','Muhammet Yusuf', 'ASLAN', 'doktoryusuf@gmail.com', '5555345555', 'Mersin Toroslar')

SELECT * FROM Secretary
SELECT * FROM Secretary_Login_Info

TRUNCATE TABLE User_Login_Info
TRUNCATE TABLE Secretary
drop table Secretary

SELECT TRIM(LOWER(name + surname)) as user_name FROM Secretary Where tc_no = '21824004326';

SELECT tc_no,name,surname,mail,phone_number,address FROM Secretary WHERE tc_no = '21824004326'

EXEC fetch_secretary_login_data 'selimcanaslan','selimcanaslan'

DELETE FROM Secretary_Login_Info WHERE tc_no='21824324326'
DELETE FROM Secretary WHERE tc_no='21824324326'

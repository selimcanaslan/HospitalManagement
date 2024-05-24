CREATE DATABASE Hospital;
USE Hospital;


-- COLLATE TO TURKISH
ALTER DATABASE gp_hospital SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

ALTER DATABASE gp_hospital COLLATE Turkish_CI_AS;

ALTER DATABASE gp_hospital SET MULTI_USER;



CREATE TABLE Sections(
	id int identity(1,1) PRIMARY KEY CLUSTERED,
	name varchar(50) COLLATE Latin1_General_100_CI_AI_SC_UTF8,
);

CREATE TABLE Appointment_Hours(
	id int identity(1,1) PRIMARY KEY CLUSTERED,
	appointment_hour time
);

CREATE TABLE Doctor(
	id int identity(1,1),
	tc_no varchar(11) PRIMARY KEY CLUSTERED,
	doctor_name varchar(30),
	doctor_surname varchar(30),
	section_id int FOREIGN KEY (section_id) REFERENCES Sections(id) ON DELETE CASCADE ON UPDATE CASCADE ,
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
SELECT @name=doctor_name FROM INSERTED
SELECT @surname=doctor_surname FROM INSERTED
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

CREATE TABLE Patient(
	id int identity(1,1),
	tc_no varchar(11) PRIMARY KEY CLUSTERED,
	name varchar(30),
	surname varchar(30),
	mail varchar(255),
	phone_number varchar(10),
	address nvarchar(max),
	registiration_date datetime DEFAULT getdate()
);

CREATE TABLE Appointment(
	id int identity(1,1) PRIMARY KEY CLUSTERED,
	patient_tc_no varchar(11) FOREIGN KEY (patient_tc_no) REFERENCES Patient(tc_no) ON DELETE CASCADE ON UPDATE CASCADE,
	section varchar(50),
	doctor_tc_no varchar(11) FOREIGN KEY (doctor_tc_no) REFERENCES Doctor(tc_no) ON DELETE CASCADE ON UPDATE CASCADE,
	examination_time datetime,
	examination_hour varchar(50),
	is_examination_done bit DEFAULT 0,
	appointment_created datetime DEFAULT getdate()
);

CREATE TABLE Examination(
	id int identity(1,1) PRIMARY KEY,
	appointment_id int FOREIGN KEY (appointment_id) REFERENCES Appointment (id),
	patient_tc_no varchar(11) FOREIGN KEY (patient_tc_no) REFERENCES Patient(tc_no) ON DELETE CASCADE ON UPDATE CASCADE,
	section varchar(50),
	doctor_tc_no varchar(11) FOREIGN KEY (doctor_tc_no) REFERENCES Doctor(tc_no) ON DELETE CASCADE ON UPDATE CASCADE,
	analysis nvarchar(max),
	result nvarchar(max)
);


GO
CREATE TRIGGER CreateExaminationRecord 
ON Appointment
AFTER INSERT
AS 
BEGIN

DECLARE @appointment_id int
DECLARE @patient_tc_no varchar(11)
DECLARE @section varchar(50)
DECLARE @doctor_tc_no varchar(11)

SELECT @appointment_id=id FROM INSERTED
SELECT @patient_tc_no=patient_tc_no FROM INSERTED
SELECT @section=section FROM INSERTED
SELECT @doctor_tc_no=doctor_tc_no FROM INSERTED

INSERT Examination VALUES (@appointment_id,@patient_tc_no,@section,@doctor_tc_no, 'Yapılan Tahlil Bulunamadı.', 'Henüz Sonuç Eklemediniz.')
END


GO
CREATE PROCEDURE FetchAllAwaitingAppointments
AS
BEGIN
SELECT Appointment.id,Patient.name + ' ' + Patient.surname as patient_name,patient_tc_no,section,Doctor.doctor_name + ' ' + Doctor.doctor_surname as doctor_name,
FORMAT(examination_time,'yyyy-MM-dd') as examination_time,examination_hour
FROM Appointment
INNER JOIN Doctor ON Appointment.doctor_tc_no = Doctor.tc_no
INNER JOIN Patient ON Appointment.patient_tc_no = Patient.tc_no
WHERE is_examination_done = 0 AND FORMAT(examination_time,'yyyy-MM-dd') >= FORMAT(GETDATE(),'yyyy-MM-dd')
END
GO
EXEC FetchAllAwaitingAppointments
DROP PROCEDURE FetchAllAwaitingAppointments
GO
CREATE PROCEDURE FetchAwaitingAppointmentsFilteredByDateAndTcNo
@tcNo varchar(11),
@date DateTime
AS
BEGIN
SELECT Patient.name + ' ' + Patient.surname as patient_name,patient_tc_no,section,Doctor.doctor_name + ' ' + Doctor.doctor_surname as doctor_name,
FORMAT(examination_time,'yyyy-MM-dd') as examination_time,examination_hour
FROM Appointment
INNER JOIN Doctor ON Appointment.doctor_tc_no = Doctor.tc_no
INNER JOIN Patient ON Appointment.patient_tc_no = Patient.tc_no
WHERE is_examination_done = 0 AND patient_tc_no = @tcNo AND FORMAT(examination_time,'yyyy-MM-dd') = @date
END
GO

GO
CREATE PROCEDURE FetchAwaitingAppointmentsFilteredByTcNo
@tcNo varchar(11)
AS
BEGIN
SELECT Patient.name + ' ' + Patient.surname as patient_name,patient_tc_no,section,Doctor.doctor_name + ' ' + Doctor.doctor_surname as doctor_name,
FORMAT(examination_time,'yyyy-MM-dd') as examination_time,examination_hour
FROM Appointment
INNER JOIN Doctor ON Appointment.doctor_tc_no = Doctor.tc_no
INNER JOIN Patient ON Appointment.patient_tc_no = Patient.tc_no
WHERE is_examination_done = 0 AND patient_tc_no = @tcNo AND FORMAT(examination_time,'yyyy-MM-dd') >= FORMAT(GETDATE(),'yyyy-MM-dd')
END
GO

GO
CREATE PROCEDURE FetchAwaitingAppointmentsFilteredByDate
@date DateTime
AS
BEGIN
SELECT Patient.name + ' ' + Patient.surname as patient_name,patient_tc_no,section,Doctor.doctor_name + ' ' + Doctor.doctor_surname as doctor_name,
FORMAT(examination_time,'yyyy-MM-dd') as examination_time,examination_hour
FROM Appointment
INNER JOIN Doctor ON Appointment.doctor_tc_no = Doctor.tc_no
INNER JOIN Patient ON Appointment.patient_tc_no = Patient.tc_no
WHERE is_examination_done = 0 AND FORMAT(examination_time,'yyyy-MM-dd') = @date
END
GO

GO
CREATE PROCEDURE fetchAllAwaitingAppointmentsFilteredByDoctorTcNo
@tcNo varchar(11)
AS
BEGIN
SELECT Appointment.id,Patient.name + ' ' + Patient.surname as patient_name,patient_tc_no,section,
FORMAT(examination_time,'yyyy-MM-dd') as examination_time,examination_hour
FROM Appointment
INNER JOIN Patient ON Appointment.patient_tc_no = Patient.tc_no
WHERE is_examination_done = 0 AND doctor_tc_no = @tcNo AND FORMAT(examination_time,'yyyy-MM-dd') >= FORMAT(GETDATE(),'yyyy-MM-dd')
END
GO

GO
CREATE PROCEDURE UpdateAppointmentState
@id int
AS
BEGIN
UPDATE Appointment SET is_examination_done = 1
WHERE id = @id
END
GO


GO
CREATE PROCEDURE UpdatePatient
@tc_no varchar(11),
@name varchar(50),
@surname varchar(50),
@mail varchar(50),
@phone varchar(10),
@address varchar(max)
AS
BEGIN
UPDATE Patient SET name = @name, surname= @surname, mail = @mail, phone_number = @phone, address = @address
WHERE tc_no = @tc_no
END
GO

GO
CREATE PROCEDURE [dbo].[fetch_secretary_login_data]
@user_name varchar(30),
@password varchar(30)
AS
BEGIN
SELECT user_name,password,tc_no FROM Secretary_Login_Info WHERE user_name = @user_name AND password=@password
END
GO


GO
CREATE PROCEDURE [dbo].[fetch_doctor_login_data]
@user_name varchar(30),
@password varchar(30)
AS
BEGIN
SELECT tc_no,user_name,password FROM Doctor_Login_Info WHERE user_name = @user_name AND password=@password
END
GO

GO
CREATE PROCEDURE FetchAllDoctor
AS
BEGIN
SELECT tc_no,doctor_name,doctor_surname,Sections.name as "section_name",mail,phone_number,address
FROM Doctor
INNER JOIN Sections ON Doctor.section_id = Sections.id; 
END
GO


SELECT COUNT(patient_tc_no) as hasta_sayisi,doctor_tc_no FROM Appointment GROUP BY doctor_tc_no



INSERT Secretary VALUES ('21824004326','Selim Can', 'ASLAN', 'sekreterselim@gmail.com', '5442628133', 'Mersin Toroslar')
INSERT Doctor VALUES ('21824004326','Selim Can', 'ASLAN',1, 'sekreterselim@gmail.com', '5442628133', 'Mersin Toroslar')
INSERT Secretary VALUES ('21824324326','Muhammet Yusuf', 'ASLAN', 'doktoryusuf@gmail.com', '5555345555', 'Mersin Toroslar')
ALTER TABLE Sections
    ALTER COLUMN name VARCHAR(50) COLLATE Latin1_General_100_CI_AI_SC_UTF8;

	
INSERT Sections VALUES ('Kardiyoloji')
INSERT Sections VALUES ('Genel Cerrahi')
INSERT Sections VALUES ('Psikiyatri')
INSERT Sections VALUES ('Kulak-Burun-Boğaz')
INSERT Sections VALUES ('Kadın Hastalıkları')
INSERT Sections VALUES ('Kadın Doğum')
INSERT Sections VALUES ('Üroloji')
INSERT Sections VALUES ('Dahiliye')
INSERT Sections VALUES ('Çocuk Hastalıkları')
INSERT Sections VALUES ('Aile Hekimi')

INSERT Appointment_Hours VALUES ('09:00:00')
INSERT Appointment_Hours VALUES ('10:00:00')
INSERT Appointment_Hours VALUES ('11:00:00')
INSERT Appointment_Hours VALUES ('13:00:00')
INSERT Appointment_Hours VALUES ('14:00:00')
INSERT Appointment_Hours VALUES ('15:00:00')
INSERT Appointment_Hours VALUES ('16:00:00')

SELECT * FROM Appointment
SELECT * FROM Patient
SELECT * FROM Doctor
SELECT * FROM Sections
SELECT * FROM Doctor_Login_Info

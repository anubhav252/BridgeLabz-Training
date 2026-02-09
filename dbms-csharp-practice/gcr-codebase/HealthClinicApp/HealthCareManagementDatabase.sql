CREATE DATABASE HealthCareDatabase
USE HealthCareDatabase

GO

CREATE TABLE Patient
	(PatientId INT IDENTITY(1,1) PRIMARY KEY,
	PatientName VARCHAR(100) NOT NULL,
	DOB DATETIME NOT NULL,
	Contact VARCHAR(20) UNIQUE NOT NULL,
	PatientAddress VARCHAR(250) NOT NULL,
	BloodGroup VARCHAR(5) NOT NULL
	)

GO

CREATE TABLE Speciality
	(SpecialityId INT IDENTITY(1,1) PRIMARY KEY,
	Speciality VARCHAR(100) NOT NULL)

GO

CREATE TABLE Doctor
	(DoctorId INT IDENTITY(1,1) PRIMARY KEY,
	DoctorName VARCHAR(100) NOT NULL,
	SpecialityId INT NOT NULL,
	Contact VARCHAR(20) NOT NULL ,
	ConsultationFee DECIMAL(10,2) NOT NULL,
	IsActive BIT DEFAULT 1,
	FOREIGN KEY(SpecialityId)REFERENCES Speciality(SpecialityId)
	)

GO

CREATE TABLE Appointments
	(
    AppointmentId INT IDENTITY(1,1) PRIMARY KEY,
    PatientId INT NOT NULL,
    DoctorId INT NOT NULL,
    AppointmentDate DATETIME NOT NULL,
    AppointmentStatus VARCHAR(20) DEFAULT 'SCHEDULED',
    FOREIGN KEY (PatientId) REFERENCES Patient(PatientId),
    FOREIGN KEY (DoctorId) REFERENCES Doctor(DoctorId)
	)
GO


CREATE TABLE Visits (
	VisitId INT IDENTITY(1,1) PRIMARY KEY,
	AppointmentId INT NOT NULL,
	Diagnosis VARCHAR(255),
	Notes VARCHAR(500),
	VisitDate DATETIME DEFAULT GETDATE(),
	FOREIGN KEY (AppointmentId) REFERENCES Appointments(AppointmentId)
	)
	
GO

CREATE TABLE Prescriptions
	(PrescriptionId INT IDENTITY(1,1) PRIMARY KEY,
	VisitId INT NOT NULL,
	Medicine VARCHAR(100) ,
	Dosage VARCHAR(100),
	Duration VARCHAR(100),
	FOREIGN KEY (VisitId) REFERENCES Visits(VisitId)
	)

GO

CREATE TABLE Bills (
    BillId INT IDENTITY(1,1) PRIMARY KEY,
    VisitId INT NOT NULL,
    TotalAmount DECIMAL(10,2),
    PaymentStatus VARCHAR(20) DEFAULT 'UNPAID',
    CreatedDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (VisitId) REFERENCES Visits(VisitId)
	)

GO

CREATE TABLE PaymentTransactions (
    TransactionId INT IDENTITY(1,1) PRIMARY KEY,
    BillId INT NOT NULL,
    PaymentMode VARCHAR(50),
    PaymentDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (BillId) REFERENCES Bills(BillId)
	)

GO

--- STORE PROCEDURES

CREATE PROCEDURE AddPatient
	@PatientName VARCHAR(100),
	@DOB DATETIME,
	@Contact INT,
	@PatientAddress VARCHAR(200),
	@BloodGroup VARCHAR(3)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Patient(PatientName,DOB,Contact,PatientAddress,BloodGroup) 
	VALUES (@PatientName,@DOB,@Contact,@PatientAddress,@BloodGroup)
END;

GO

CREATE PROCEDURE UpdatePatient
	@PatientId INT,
	@PatientName VARCHAR(100),
	@DOB DATETIME ,
	@Contact VARCHAR(20),
	@PatientAddress VARCHAR(250) ,
	@BloodGroup VARCHAR(5) 
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Patient 
	SET PatientName=@PatientName,
		DOB=@DOB,
		Contact=@Contact,
		PatientAddress=@PatientAddress,
		BloodGroup=@BloodGroup
	WHERE PatientId=@PatientId
END

GO

CREATE PROCEDURE SearchPatient
    @search VARCHAR(100)
AS
BEGIN
	SET NOCOUNT ON;
    SELECT *
    FROM Patient
    WHERE PatientName LIKE '%' + @search + '%'
       OR Contact = @search;
END;

GO

CREATE PROCEDURE AddDoctor
    @DoctorName VARCHAR(100),
    @SpecialityId INT,
    @Contact VARCHAR(20),
    @ConsultationFee DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Doctor
    (DoctorName, SpecialityId, Contact, ConsultationFee)
    VALUES
    (@DoctorName, @SpecialityId, @Contact, @ConsultationFee);
END;
GO

CREATE PROCEDURE DeactivateDoctor
    @DoctorId INT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1 FROM Appointments
        WHERE DoctorId = @DoctorId
          AND AppointmentStatus = 'SCHEDULED'
    )
        THROW 50002, 'Doctor has scheduled appointments', 1;

    UPDATE Doctor
    SET IsActive = 0
    WHERE DoctorId = @DoctorId;
END;
GO


CREATE PROCEDURE BookAppointment
    @PatientId INT,
    @DoctorId INT,
    @AppointmentDate DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Appointments
    (PatientId, DoctorId, AppointmentDate)
    VALUES
    (@PatientId, @DoctorId, @AppointmentDate);
END;
GO

CREATE PROCEDURE CancelAppointment
    @AppointmentId INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRAN;

    UPDATE Appointments
    SET AppointmentStatus = 'CANCELLED'
    WHERE AppointmentId = @AppointmentId;

    COMMIT;
END;
GO

CREATE PROCEDURE DailyAppointments
    @Date DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT a.AppointmentDate,
           p.PatientName,
           d.DoctorName
    FROM Appointments a
    JOIN Patient p ON a.PatientId = p.PatientId
    JOIN Doctor d ON a.DoctorId = d.DoctorId
    WHERE CAST(a.AppointmentDate AS DATE) = @Date
    ORDER BY a.AppointmentDate;
END;
GO

CREATE PROCEDURE RecordVisit
    @AppointmentId INT,
    @Diagnosis VARCHAR(255),
    @Notes VARCHAR(500)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRAN;

    INSERT INTO Visits (AppointmentId, Diagnosis, Notes)
    VALUES (@AppointmentId, @Diagnosis, @Notes);

    UPDATE Appointments
    SET AppointmentStatus = 'COMPLETED'
    WHERE AppointmentId = @AppointmentId;

    COMMIT;
END;
GO

CREATE PROCEDURE GenerateBill
    @VisitId INT,
    @TotalAmount DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Bills (VisitId, TotalAmount)
    VALUES (@VisitId, @TotalAmount);
END;
GO

CREATE PROCEDURE RecordPayment
    @BillId INT,
    @PaymentMode VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRAN;

    UPDATE Bills
    SET PaymentStatus = 'PAID'
    WHERE BillId = @BillId;

    INSERT INTO PaymentTransactions (BillId, PaymentMode)
    VALUES (@BillId, @PaymentMode);

    COMMIT;
END;
GO

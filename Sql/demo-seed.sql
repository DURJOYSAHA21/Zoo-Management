-- Demo data for screenshots (added 2026-11-25). Remove it with Sql/demo-cleanup.sql.
-- All demo users have an email ending in @demo.zoo; demo events are created by the demo doctor.
USE [Project];
SET NOCOUNT ON;
SET XACT_ABORT ON;
BEGIN TRAN;

DECLARE @today date = CAST(GETDATE() AS date);

INSERT INTO [User] (FullName, Password, Email, PhoneNumber, Address, Gender, JoinDate, RoleID, Dob)
VALUES ('Ayesha Rahman', 'Demo@2026', 'ayesha.vet@demo.zoo', '01700000001', 'Dhaka', 'Female', '2025-02-01', 2, '1992-05-14');
DECLARE @doc int = SCOPE_IDENTITY();
INSERT INTO EmployeeDetails (EmployeeID, EmployeeType, Salary) VALUES (@doc, 'Doctor', 85000);

INSERT INTO [User] (FullName, Password, Email, PhoneNumber, Address, Gender, JoinDate, RoleID, Dob)
VALUES ('Rafi Ahmed', 'Demo@2026', 'rafi.keeper@demo.zoo', '01700000002', 'Dhaka', 'Male', '2025-03-10', 2, '1998-09-02');
DECLARE @staff int = SCOPE_IDENTITY();
INSERT INTO EmployeeDetails (EmployeeID, EmployeeType, Salary) VALUES (@staff, 'Staff', 32000);

INSERT INTO [User] (FullName, Password, Email, PhoneNumber, Address, Gender, JoinDate, RoleID, Dob)
VALUES ('Sara Khan', 'Demo@2026', 'sara.visitor@demo.zoo', '01700000003', 'Dhaka', 'Female', '2025-06-01', 3, '2000-01-20');
DECLARE @vis int = SCOPE_IDENTITY();
INSERT INTO VisitorDetails (VisitorID, IsMember) VALUES (@vis, 1);
INSERT INTO BankAccount (BankID, AccountNumber, AccountHolderName, Balance, AccountType, IsActive, AccountHolderEmail)
VALUES (3, '20019990001', 'Sara Khan', 25000.00, 'Savings', 1, 'sara.visitor@demo.zoo');
INSERT INTO Cart (VisitorID, CreatedDate) VALUES (@vis, GETDATE());
DECLARE @cart int = SCOPE_IDENTITY();
INSERT INTO CartItems (CartID, ProductID, Quantity) VALUES (@cart, 1, 2), (@cart, 3, 1);

-- Checkups: 9 Luna (Tiger), 11 Ruby (Red Panda), 12 Nina (Chimpanzee), 18 Max (Penguin), 8 Oscar (Zebra), 15 Lily (Flamingo)
INSERT INTO Checkup (AnimalID, DoctorID, CheckupDate, Weight, Temperature, HeartRate, HealthCondition, Notes) VALUES
 (9,  @doc, DATEADD(day, 0,  @today), 182.5, 38.4, 64,  'Healthy',        'Routine checkup, good appetite'),
 (11, @doc, DATEADD(day, -1, @today), 5.6,   38.1, 110, 'Healthy',        'Coat and teeth in good condition'),
 (12, @doc, DATEADD(day, -2, @today), 46.0,  37.2, 88,  'Mild cough',     'Watch for 3 days'),
 (18, @doc, DATEADD(day, -3, @today), 4.1,   38.9, 140, 'Healthy',        'Feathers fine after moult'),
 (8,  @doc, DATEADD(day, -5, @today), 352.0, 37.8, 42,  'Limping',        'Left hind hoof sore'),
 (15, @doc, DATEADD(day, -6, @today), 2.9,   40.1, 160, 'Healthy',        'Colour normal');

INSERT INTO MedicalRecord (AnimalID, DoctorID, TreatmentDate, Treatment, MedicineGiven, NextVisitDate, Notes, Status) VALUES
 (12, @doc, DATEADD(day, -2, @today), 'Respiratory check', 'Amoxicillin 250 mg',  DATEADD(day, 3,  @today), 'Mild cough, isolate at night', 'Ongoing'),
 (8,  @doc, DATEADD(day, -5, @today), 'Hoof trimming',     'Meloxicam 15 mg',     DATEADD(day, 7,  @today), 'Rest in small paddock',        'Ongoing'),
 (9,  @doc, DATEADD(day, -20, @today), 'Vaccination',      'Feline FVRCP booster', DATEADD(day, 345, @today), 'No reaction',                'Completed'),
 (18, @doc, DATEADD(day, -30, @today), 'Deworming',        'Praziquantel',        DATEADD(day, 60, @today), 'Repeat with the colony',       'Completed');

INSERT INTO WorkSchedule (EmployeeID, Task, WorkDate, UpdatedBy, AnimalID, Status) VALUES
 (@doc,   'Follow-up cough check',     @today, 1, 12, 'Pending'),
 (@doc,   'Check hoof healing',        @today, 1, 8,  'Pending'),
 (@staff, 'Morning feeding',           @today, 1, 9,  'Pending'),
 (@staff, 'Clean penguin pool',        @today, 1, 18, 'Pending'),
 (@staff, 'Give medicine with food',   @today, 1, 12, 'Pending'),
 (@staff, 'Enrichment: puzzle feeder', @today, 1, 11, 'Pending');

INSERT INTO Chat (SenderID, ReceiverID, Message, SentAt, IsRead) VALUES
 (@staff, @doc, 'Nina ate well this morning, the cough sounds lighter.', DATEADD(minute, -40, GETDATE()), 0),
 (@staff, @doc, 'Oscar is putting more weight on the left hoof today.',  DATEADD(minute, -15, GETDATE()), 0),
 (@doc, @staff, 'Thanks! Keep Nina inside tonight please.',             DATEADD(minute, -10, GETDATE()), 0);

INSERT INTO [Event] (EventName, EventDate, Location, Description, MaxCapacity, TicketPrice, IsActive, CreatedBy, CreatedDate) VALUES
 ('Penguin Feeding Talk', DATEADD(hour, 15, CAST(DATEADD(day, 3,  @today) AS datetime)), 'Penguin Beach',  'Meet the keepers and watch the colony at feeding time.', 60,  5.00,  1, @doc, GETDATE()),
 ('Night Safari Tour',    DATEADD(hour, 19, CAST(DATEADD(day, 10, @today) AS datetime)), 'Main Gate',      'A guided evening walk to see nocturnal animals.',        30,  15.00, 1, @doc, GETDATE());

COMMIT;
SELECT @doc AS DemoDoctorID, @staff AS DemoStaffID, @vis AS DemoVisitorID;

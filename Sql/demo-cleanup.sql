-- Removes everything Sql/demo-seed.sql added.
USE [Project];
SET NOCOUNT ON;
SET XACT_ABORT ON;
BEGIN TRAN;

DECLARE @ids TABLE (id int);
INSERT INTO @ids SELECT UserID FROM [User] WHERE Email LIKE '%@demo.zoo';

DELETE FROM CartItems     WHERE CartID IN (SELECT CartID FROM Cart WHERE VisitorID IN (SELECT id FROM @ids));
DELETE FROM Cart          WHERE VisitorID IN (SELECT id FROM @ids);
DELETE FROM BankAccount   WHERE AccountHolderEmail LIKE '%@demo.zoo';
DELETE FROM VisitorDetails WHERE VisitorID IN (SELECT id FROM @ids);
DELETE FROM [Event]       WHERE CreatedBy IN (SELECT id FROM @ids);
DELETE FROM Chat          WHERE SenderID IN (SELECT id FROM @ids) OR ReceiverID IN (SELECT id FROM @ids);
DELETE FROM WorkSchedule  WHERE EmployeeID IN (SELECT id FROM @ids);
DELETE FROM MedicalRecord WHERE DoctorID IN (SELECT id FROM @ids);
DELETE FROM Checkup       WHERE DoctorID IN (SELECT id FROM @ids);
DELETE FROM EmployeeDetails WHERE EmployeeID IN (SELECT id FROM @ids);
DELETE FROM [User]        WHERE UserID IN (SELECT id FROM @ids);

COMMIT;

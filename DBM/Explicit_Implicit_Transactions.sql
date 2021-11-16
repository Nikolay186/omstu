USE Insurance;
GO

BEGIN TRAN tr
INSERT Insurances VALUES('test1', 2);
INSERT Insurances VALUES('test2', 3);
SAVE TRAN fp;
INSERT Insurances VALUES('test3', 4);
ROLLBACK TRAN fp;
COMMIT TRAN tr;
SELECT * FROM Insurances;
GO

SET IMPLICIT_TRANSACTIONS ON;
GO

INSERT Insurances VALUES('test4', 5);
INSERT Insurances VALUES('test5', 6);
SAVE TRAN fp;
INSERT Insurances VALUES('test6', 7);
ROLLBACK TRAN fp;
COMMIT TRAN;
SELECT * FROM Insurances;
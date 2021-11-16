USE Insurance;
GO

CREATE TRIGGER trig on Contracts
AFTER INSERT
AS
UPDATE Contracts
SET sum = Contracts.sum + 100
FROM inserted
WHERE Contracts.id = inserted.id;
GO

CREATE TRIGGER trigr on Affilates
AFTER INSERT
AS
UPDATE Affilates
SET phone = LEFT(inserted.phone, 5)
FROM inserted
WHERE Affilates.id = inserted.id;
UPDATE Affilates
SET address = LEFT(inserted.address, 10)
FROM inserted
WHERE Affilates.id = inserted.id;
GO

INSERT INTO Contracts VALUES('2020-12-03', 300, 1, 1, 3, 2, 3);
INSERT INTO Affilates VALUES('test123431', 'test address', '93189895911');
GO
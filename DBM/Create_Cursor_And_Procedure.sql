USE Insurance;
GO

DECLARE @name VARCHAR(30);
PRINT 'Clients, who have life insurance:';

DECLARE c CURSOR LOCAL FOR
	SELECT name FROM Clients, Contracts
	WHERE Clients.id = Contracts.id AND Contracts.insurance_type = 3;
OPEN c;

FETCH NEXT FROM c INTO @name;
WHILE @@FETCH_STATUS = 0
BEGIN
	PRINT @name;
	FETCH NEXT FROM c INTO @name;
END;
CLOSE c;
DEALLOCATE c;
GO

CREATE TABLE Year(id INT IDENTITY(1,1), date_issued DATE, sum INT, sum_rate INT, insurance_type INT, client INT, affilate INT, agent INT, 
					   PRIMARY KEY(id));
GO

CREATE PROCEDURE Contracts_2020
AS
BEGIN
	DECLARE @date DATE, @sum INT, @sum_rate INT, @i_id INT, @cl_id INT, @af_id INT, @ag_id INT;
	DECLARE c CURSOR LOCAL FOR
		SELECT date_issued, sum, sum_rate, insurance_type, client, affilate, agent FROM Contracts
		WHERE date_issued BETWEEN '2020-01-01' AND '2020-12-31';
	OPEN c;
	FETCH NEXT FROM c
	INTO @date, @sum, @sum_rate, @i_id, @cl_id, @af_id, @ag_id;
	WHILE @@FETCH_STATUS = 0
		BEGIN
			INSERT INTO Year VALUES(@date, @sum, @sum_rate, @i_id, @cl_id, @af_id, @ag_id);
			FETCH NEXT FROM c INTO @date, @sum, @sum_rate, @i_id, @cl_id, @af_id, @ag_id;
		END;
	CLOSE c;
	DEALLOCATE c;
END;
GO

EXECUTE Contracts_2020
GO
USE Insurance;
GO

CREATE PROCEDURE Contracts_add(@date DATE, @sum INT, @rate INT, @type INT, @client INT, @affilate INT, @agent INT)
AS
BEGIN
	INSERT INTO 
	Contracts(date_issued, sum, sum_rate, insurance_type, client, affilate, agent) 
	VALUES
	(@date, @sum, @rate, @type, @client, @affilate, @agent);
END
GO

CREATE PROCEDURE Contracts_Delete(@id INT) 
AS
BEGIN
	DELETE FROM Contracts WHERE id = @id;
END
GO

EXECUTE Contracts_add '2021-05-24', 10000, 2, 1, 4, 2, 1
EXECUTE Contracts_Delete 1
GO
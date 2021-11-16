USE Insurance;
GO

CREATE VIEW Clients_view AS
SELECT CONCAT(name,' Phone: ', phone) AS [Data] FROM Clients;
GO

CREATE VIEW Contracts_view AS
SELECT id, SUM(sum * sum_rate) AS Price FROM Contracts
GROUP BY id;
GO

SELECT MIN(price) AS min, MAX(price) AS max, SUM(price) AS sum
FROM Contracts_view;
GO
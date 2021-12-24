USE Insurance;
GO

SELECT * FROM Contracts WHERE Contracts.sum >= 50000;
GO

SELECT Contracts.client FROM Contracts WHERE Contracts.agent = 1;
GO

SELECT Clients.id as ID, COUNT(Contracts.id) as Q FROM Clients
LEFT JOIN
Contracts on Clients.id = Contracts.client
GROUP BY Clients.id
HAVING COUNT(Contracts.id) = 2
ORDER BY Q ASC;
GO

SELECT name, rate FROM Insurances
WHERE EXISTS (SELECT * FROM Contracts WHERE Contracts.insurance_type = Insurances.id);
GO
USE Insurance;
GO

INSERT INTO Insurances(name, rate) VALUES 
('auto insurance', 2.5),
('real estate insurance', 5),
('life insurance', 7.6);
GO

INSERT INTO Clients(name, phone) VALUES
('first client', '89134131423'),
('second client', '89125731235'),
('third client', '89145431242'),
('fourth client', '89611235723'),
('fifth client', '89571238643');

UPDATE Clients SET phone = '89674125253' WHERE name = 'fifth client';
GO

INSERT INTO Affilates(name, address, phone) VALUES
('first affilate', 'first address', '89125736671'),
('second affilate', 'second address', '89125736171'),
('third affilate', 'third address', '89125726671'),
('fourth affilate', 'fourth address', '89135736671');
GO

INSERT INTO Agents(name, address, phone, affilate) VALUES
('first agent', 'first ag address', '89225736671', 4),
('second agent', 'second ag address', '89235736671', 3),
('third agent', 'third ag address', '89264736671', 3),
('fourth agent', 'fourth ag address', '89215436671', 2),
('fifth agent', 'fifth ag address', '89295836671', 1);
GO

INSERT INTO Contracts(date_issued, sum, sum_rate, insurance_type, client, affilate, agent) VALUES
('2021-12-10', 30000, 1, 1, 1, 1, 5),
('2021-12-10', 20000, 2, 3, 2, 3, 2),
('2021-09-11', 150000, 4, 2, 4, 3, 3),
('2020-12-11', 50000, 3, 3, 5, 2, 4),
('2020-12-11', 70000, 1, 1, 2, 1, 5),
('2021-10-16', 30000, 5, 1, 1, 1, 5),
('2021-11-18', 20000, 2, 1, 3, 4, 1),
('2021-05-11', 90000, 6, 2, 5, 4, 1);
GO
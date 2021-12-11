USE Insurance;
GO

IF EXISTS(SELECT * FROM sys.tables WHERE NAME = 'Contracts')
DROP TABLE Contracts;

IF EXISTS(SELECT * FROM sys.tables WHERE NAME = 'Agents')
DROP TABLE Agents;

IF EXISTS(SELECT * FROM sys.tables WHERE NAME = 'Affilates')
DROP TABLE Affilates;
GO

CREATE TABLE Affilates(id INT IDENTITY(1,1), name VARCHAR(50), address VARCHAR(100), phone VARCHAR(15), 
		       CONSTRAINT PK_Af PRIMARY KEY(id));
GO

IF EXISTS(SELECT * FROM sys.tables WHERE NAME = 'Insurances')
DROP TABLE Insurances;
GO

CREATE TABLE Insurances(id INT IDENTITY(1,1), name VARCHAR(200), rate INT, 
			CONSTRAINT PK_Ins PRIMARY KEY(id));
GO

IF EXISTS(SELECT * FROM sys.tables WHERE NAME = 'Clients')
DROP TABLE Clients;
GO

CREATE TABLE Clients(id INT IDENTITY(1,1), name VARCHAR(100), phone VARCHAR(15), 
		     CONSTRAINT PK_Cl PRIMARY KEY(id));
GO

CREATE TABLE Agents(id INT IDENTITY(1,1), name VARCHAR(100), address VARCHAR(100), phone VARCHAR(15), affilate INT, 
		    CONSTRAINT PK_Ag PRIMARY KEY(id), CONSTRAINT FK_Ag FOREIGN KEY(affilate) 
		    REFERENCES Affilates(id) ON UPDATE CASCADE ON DELETE CASCADE);
GO

CREATE TABLE Contracts(id INT IDENTITY(1,1), date_issued DATE, sum INT, sum_rate INT, insurance_type INT, client INT, affilate INT, agent INT, 
	CONSTRAINT PK_Con PRIMARY KEY(id), CONSTRAINT FK_ConIns FOREIGN KEY(insurance_type) REFERENCES Insurances(id) ON UPDATE CASCADE ON DELETE CASCADE, 
	CONSTRAINT FK_ConCl FOREIGN KEY(client) REFERENCES Clients(id) ON UPDATE CASCADE ON DELETE CASCADE,  
	CONSTRAINT FK_ConAg FOREIGN KEY(agent) REFERENCES Agents(id) ON UPDATE CASCADE ON DELETE CASCADE);
GO

USE master;

GO
IF DB_ID('Insurance') IS NOT NULL
	DROP DATABASE Insurance;

GO
CREATE DATABASE Insurance
ON PRIMARY (NAME = Insurance, FILENAME = 'G:\DBM\Insurance.mdf', SIZE = 5MB, 
			MAXSIZE = 1GB, FILEGROWTH = 1MB)
LOG ON (NAME = Insurance_log, FILENAME = 'G:\DBM\Insurance.ldf', SIZE = 2MB, 
		MAXSIZE = 100MB, FILEGROWTH = 1MB)
GO
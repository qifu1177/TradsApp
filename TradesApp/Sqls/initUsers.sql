USE TradsApp;

--Create user for Admin
CREATE LOGIN TradAdmin WITH PASSWORD = 'Test.1234.5';
CREATE USER TradAdmin FOR LOGIN TradAdmin;

ALTER ROLE db_datareader ADD MEMBER TradAdmin;
ALTER ROLE db_datawriter ADD MEMBER TradAdmin;

GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.EmployeeTrade TO TradAdmin;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.TradData TO TradAdmin;

--Create user for Compliance
CREATE LOGIN Tester1 WITH PASSWORD = 'Test.1234.5';
CREATE USER Tester1 FOR LOGIN Tester1;

ALTER ROLE db_datareader ADD MEMBER Tester1;
ALTER ROLE db_datawriter ADD MEMBER Tester1;

GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.EmployeeTrade TO Tester1;
DENY SELECT, INSERT, UPDATE, DELETE ON dbo.TradData TO Tester1;

--Create user for Handelsüberwachung 
CREATE LOGIN Tester2 WITH PASSWORD = 'Test.1234.5';
CREATE USER Tester2 FOR LOGIN Tester2;

ALTER ROLE db_datareader ADD MEMBER Tester2;
ALTER ROLE db_datawriter ADD MEMBER Tester2;

DENY SELECT, INSERT, UPDATE, DELETE ON dbo.EmployeeTrade TO Tester2;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.TradData TO Tester2;
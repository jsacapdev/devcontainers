IF NOT EXISTS(SELECT *
FROM sys.databases
WHERE name = 'IdentityDB')
  BEGIN
    CREATE DATABASE IdentityDB;
END

GO
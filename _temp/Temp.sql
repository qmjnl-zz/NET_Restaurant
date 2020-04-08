USE Restaurant;
GO

SELECT USER_NAME();  
GO

select * from Meal


EXECUTE AS USER = 'ivanov';  
GO  
SELECT USER_NAME();  
GO  

select * from Meal

REVERT;  
GO  
SELECT USER_NAME();  
GO


-- SELECT * FROM sys.sysusers;

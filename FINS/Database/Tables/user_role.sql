CREATE TABLE [dbo].[user_role]
(
	[role_id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [role_name] VARCHAR(20) NOT NULL, 
    [permission] VARCHAR(50) NULL
)

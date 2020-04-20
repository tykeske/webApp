CREATE TABLE [dbo].[user_role]
(
	[role_id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [role_name] VARCHAR(20) NOT NULL, 
    [can_send_notification] BIT NOT NULL DEFAULT 0, 
    [can_view_log] BIT NOT NULL DEFAULT 0, 
    [can_create_template] BIT NOT NULL DEFAULT 0
)

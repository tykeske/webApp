CREATE TABLE [dbo].[message_template]
(
	[template_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [template_name] VARCHAR(50) NOT NULL, 
    [message_content] NVARCHAR(1000) NOT NULL, 
    [created_date] SMALLDATETIME NOT NULL DEFAULT GETDATE(), 
    [updated_date] SMALLDATETIME NULL, 
    [created_by] INT NOT NULL, 
    [updated_by] INT NULL
)

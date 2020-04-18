CREATE TABLE [dbo].[user] (
    [user_id]       INT           IDENTITY (1, 1) NOT NULL,
    [user_name]     VARCHAR (30)  NOT NULL,
    [password_hash] VARCHAR (50)  NOT NULL,
    [full_name]     NVARCHAR (50) NOT NULL,
    [email_address] VARCHAR (50)  NOT NULL,
    [role_id]       INT           NOT NULL,
    [is_active]     BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([user_id] ASC),
    CONSTRAINT [FK_User_RoleID] FOREIGN KEY ([role_id]) REFERENCES [dbo].[role] ([role_id])
);


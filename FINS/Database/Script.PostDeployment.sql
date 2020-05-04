/*
Post-Deployment Script	
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

USE [234a_TeamApex];
GO

/* Reference Data */

-- Role
INSERT INTO [dbo].[user_role]
           ([role_name]
           ,[can_create_template]
           ,[can_send_notification]
           ,[can_view_log])
     VALUES
           ('Subscriber'
           ,0
           ,0
           ,0);
GO

INSERT INTO [dbo].[user_role]
           ([role_name]
           ,[can_create_template]
           ,[can_send_notification]
           ,[can_view_log])
     VALUES
           ('Manager'
           ,1
           ,1
           ,1);
GO

INSERT INTO [dbo].[user_role]
           ([role_name]
           ,[can_create_template]
           ,[can_send_notification]
           ,[can_view_log])
     VALUES
           ('Staff Member'
           ,0
           ,1
           ,1);
GO

-- Location
INSERT INTO [dbo].[pantry_location]
           ([location_name])
     VALUES
           ('Cascade')
GO

INSERT INTO [dbo].[pantry_location]
           ([location_name])
     VALUES
           ('Rock Creek')
GO

INSERT INTO [dbo].[pantry_location]
           ([location_name])
     VALUES
           ('Southeast')
GO

INSERT INTO [dbo].[pantry_location]
           ([location_name])
     VALUES
           ('Sylvania')
GO



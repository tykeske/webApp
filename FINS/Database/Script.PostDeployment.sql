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
INSERT INTO [dbo].[role]
           ([role_name]
           ,[permission])
     VALUES
           ('subscriber'
           ,NULL);
GO

INSERT INTO [dbo].[role]
           ([role_name]
           ,[permission])
     VALUES
           ('manager'
           ,NULL);
GO

INSERT INTO [dbo].[role]
           ([role_name]
           ,[permission])
     VALUES
           ('worker'
           ,NULL);
GO

-- Location
INSERT INTO [dbo].[location]
           ([location_name])
     VALUES
           ('Cascade')
GO

INSERT INTO [dbo].[location]
           ([location_name])
     VALUES
           ('Rock Creek')
GO

INSERT INTO [dbo].[location]
           ([location_name])
     VALUES
           ('Southeast')
GO

INSERT INTO [dbo].[location]
           ([location_name])
     VALUES
           ('Sylvania')
GO



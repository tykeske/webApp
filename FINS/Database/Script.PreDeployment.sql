/*
 Pre-Deployment Script							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

USE [234a_TeamApex]
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[message_tag]') AND type in (N'U'))
DROP TABLE [dbo].[message_tag]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[user_location]') AND type in (N'U'))
DROP TABLE [dbo].[user_location]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[template_tag]') AND type in (N'U'))
DROP TABLE [dbo].[template_tag]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[message_log]') AND type in (N'U'))
DROP TABLE [dbo].[message_log]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[message_template]') AND type in (N'U'))
DROP TABLE [dbo].[message_template]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pantry_location]') AND type in (N'U'))
DROP TABLE [dbo].[pantry_location]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[user_account]') AND type in (N'U'))
DROP TABLE [dbo].[user_account]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[user_role]') AND type in (N'U'))
DROP TABLE [dbo].[user_role]
GO


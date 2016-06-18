/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
			   SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO dbo.Ids VALUES ('Slot', 1)
INSERT INTO dbo.Ids VALUES ('Snack', 1)
INSERT INTO dbo.Ids VALUES ('SnackMachine', 1)
INSERT INTO dbo.Ids VALUES ('Atm', 1)

INSERT INTO dbo.Snack VALUES (1, 'Chocolate')
INSERT INTO dbo.Snack VALUES (2, 'Soda')
INSERT INTO dbo.Snack VALUES (3, 'Gum')

INSERT INTO dbo.SnackMachine VALUES (1,1,1,1,1,1,1)

INSERT INTO dbo.Slot (SlotID, Quantity, Price, SnackID, SnackMachineID, Position) VALUES 
	(1,10,3.00,1,1,1),
	(2,15,2.00,2,1,2),
	(3,20,1.00,3,1,3)

INSERT INTO dbo.Atm (AtmID, MoneyCharged, OneCentCount, TenCentCount, QuarterCount, OneDollarCount, FiveDollarCount, TwentyDollarCount) VALUES 
	(1,0.00, 100, 100, 100, 100, 100, 100)
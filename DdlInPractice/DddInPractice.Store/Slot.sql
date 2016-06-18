CREATE TABLE [dbo].[Slot]
(
	[SlotID] INT NOT NULL PRIMARY KEY, 
    [SnackMachineID] INT NOT NULL, 
    [SnackID] INT NOT NULL,
    [Quantity] INT NOT NULL, 
    [Price] FLOAT NOT NULL, 
    [Position] INT NOT NULL, 
    CONSTRAINT [FK_Slot_SnackMachine] FOREIGN KEY ([SnackMachineID]) REFERENCES [SnackMachine]([SnackMachineID]), 
    CONSTRAINT [FK_Slot_Snack] FOREIGN KEY ([SnackID]) REFERENCES [Snack]([SnackID]), 
)

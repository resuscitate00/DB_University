CREATE TABLE [dbo].[اخذ درس]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [کد درس] INT NULL, 
    [کد گروه ] INT NULL, 
    [تاریخ برگزاری] DATE NULL, 
    [ساعت برگزاری] TIME NULL, 
    [کد کلاس] INT NULL
)

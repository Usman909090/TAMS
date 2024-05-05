

create database TAMS;
use tams;

-- Create User Table
CREATE TABLE [dbo].[User] (
    [UserID] INT IDENTITY(1,1) PRIMARY KEY,
    [Username] VARCHAR(255) NOT NULL,
    [Email] VARCHAR(255) NOT NULL,
    [Password] VARCHAR(255) NOT NULL
);

CREATE TABLE [dbo].[Role] (
	[RoleID] INT PRIMARY KEY IDENTITy(1, 1),
	[RoleName] VARCHAR(30)
);

CREATE TABLE [dbo].[UserRoles] (
	[UserID] INT PRIMARY KEY,
	[RoleID] INT
);

-- Create BidHerald Table
CREATE TABLE [dbo].[BidHerald] (
    [UserID] INT PRIMARY KEY,
	[Username] VARCHAR(255) NOT NULL,
    [Email] VARCHAR(255) NOT NULL,
    [Password] VARCHAR(255) NOT NULL,
    [LicenseNumber] VARCHAR(255) NOT NULL,
    [ExperienceYears] INT NOT NULL,
    [Rating] DECIMAL(3,2) NULL
);

-- Create Captain Table
CREATE TABLE [dbo].[Captain] (
    [UserID] INT PRIMARY KEY,
	[Username] VARCHAR(255) NOT NULL,
    [Email] VARCHAR(255) NOT NULL,
    [Password] VARCHAR(255) NOT NULL,
    [TeamManagedID] INT NULL
);

-- Create Player Table
CREATE TABLE [dbo].[Player] (
    [UserID] INT PRIMARY KEY,
	[Username] VARCHAR(255) NOT NULL,
    [Email] VARCHAR(255) NOT NULL,
    [Password] VARCHAR(255) NOT NULL,
    [Status] VARCHAR(100) NOT NULL
);

-- Create TeamPlayer Table
CREATE TABLE [dbo].[TeamPlayer] (
    [TeamID] INT,
	[Username] VARCHAR(255) NOT NULL,
    [Email] VARCHAR(255) NOT NULL,
    [Password] VARCHAR(255) NOT NULL,
    [PlayerID] INT,
    [Position] VARCHAR(50) CHECK ([Position] IN ('Main', 'Substitute')),
    PRIMARY KEY ([TeamID], [PlayerID])
);

-- Create Auction Table
CREATE TABLE [dbo].[Auction] (
    [AuctionID] INT IDENTITY(1,1) PRIMARY KEY,
	[Name] VARCHAR(30),
	[Description] VARCHAR(255),
    [StartTime] DATETIME NOT NULL,
    [EndTime] DATETIME NOT NULL,
    [Duration] INT NOT NULL,
    [Status] VARCHAR(50) CHECK ([Status] IN ('Planned', 'Active', 'Completed')),
	[BidHeraldID] INT DEFAULT -1
);

-- Create Team Table
CREATE TABLE [dbo].[Team] (
    [TeamID] INT IDENTITY(1,1) PRIMARY KEY,
    [CaptainID] INT NOT NULL,
    [TeamName] VARCHAR(255) NOT NULL,
    [TeamStatus] VARCHAR(50) CHECK ([TeamStatus] IN ('Active', 'Inactive'))
);

-- Create Bid Table
CREATE TABLE [dbo].[Bid] (
    [BidID] INT IDENTITY(1,1) PRIMARY KEY,
    [AuctionID] INT NOT NULL,
    [PlayerID] INT NOT NULL,
    [CaptainID] INT NOT NULL,
    [Amount] DECIMAL(10,2) NOT NULL,
    [BidTime] DATETIME NOT NULL
);

-- Create Tournament Table
CREATE TABLE [dbo].[Tournament] (
    [TournamentID] INT IDENTITY(1,1) PRIMARY KEY,
    [Name] VARCHAR(255) NOT NULL,
    [StartDate] DATE NOT NULL,
    [EndDate] DATE NOT NULL,
    [Location] VARCHAR(255) NOT NULL
);

CREATE TABLE [AuctionHerald] (
	[AuctionID] INT NOT NULL,
	[BidHeraldID] INT NOT NULL DEFAULT -1,
);

CREATE TABLE [Participants] (
	[UserID] INT NOT NULL,
	[RoleID] INT NOT NULL,
	[AuctionID] INT NOT NULL,
	[Status] VARCHAR(50) CHECK ([Status] IN ('Approved', 'Pending'))
);

-- Defining constraints
-- Foreign Keys for User Roles 
ALTER TABLE [dbo].[UserRoles] ADD CONSTRAINT FK_UserRoles_User FOREIGN KEY ([UserID]) REFERENCES [dbo].[User]([UserID]) ON DELETE CASCADE;
ALTER TABLE [dbo].[UserRoles] ADD CONSTRAINT FK_UserRoles_Role FOREIGN KEY ([RoleID]) REFERENCES [dbo].[Role]([RoleID]) ON DELETE SET NULL;

-- Foreign Keys for BidHerald
ALTER TABLE [dbo].[BidHerald] ADD CONSTRAINT [FK_BidHerald_User] FOREIGN KEY ([UserID]) REFERENCES [dbo].[User]([UserID]);

-- Foreign Keys for Captain
ALTER TABLE [dbo].[Captain] ADD CONSTRAINT [FK_Captain_User] FOREIGN KEY ([UserID]) REFERENCES [dbo].[User]([UserID]);
ALTER TABLE [dbo].[Captain] ADD CONSTRAINT [FK_Captain_Team] FOREIGN KEY ([TeamManagedID]) REFERENCES [dbo].[Team]([TeamID]);

-- Foreign Keys for Player
ALTER TABLE [dbo].[Player] ADD CONSTRAINT [FK_Player_User] FOREIGN KEY ([UserID]) REFERENCES [dbo].[User]([UserID]);


-- Foreign Keys for Team
ALTER TABLE [dbo].[Team] ADD CONSTRAINT [FK_Team_Captain] FOREIGN KEY ([CaptainID]) REFERENCES [dbo].[User]([UserID]);

-- Foreign Keys for Bid
ALTER TABLE [dbo].[Bid] ADD CONSTRAINT [FK_Bid_Auction] FOREIGN KEY ([AuctionID]) REFERENCES [dbo].[Auction]([AuctionID]);
ALTER TABLE [dbo].[Bid] ADD CONSTRAINT [FK_Bid_Player] FOREIGN KEY ([PlayerID]) REFERENCES [dbo].[User]([UserID]);
ALTER TABLE [dbo].[Bid] ADD CONSTRAINT [FK_Bid_Captain] FOREIGN KEY ([CaptainID]) REFERENCES [dbo].[User]([UserID]);

-- Foreign Keys for TeamPlayer
ALTER TABLE [dbo].[TeamPlayer] ADD CONSTRAINT [FK_TeamPlayer_Team] FOREIGN KEY ([TeamID]) REFERENCES [dbo].[Team]([TeamID]);
ALTER TABLE [dbo].[TeamPlayer] ADD CONSTRAINT [FK_TeamPlayer_Player] FOREIGN KEY ([PlayerID]) REFERENCES [dbo].[User]([UserID]);

-- Triggers
CREATE TRIGGER DeleteAssignedRolesOnUserRemoval
ON [dbo].[User]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;

	DELETE ur FROM [dbo].[UserRoles] ur
	INNER JOIN deleted d ON ur.UserID = d.UserID
END

-- Create a trigger on the BidHerald table
CREATE TRIGGER SeparateDataForHeraldRegistration
ON [BidHerald]
INSTEAD OF INSERT
AS
BEGIN
    -- Begin transaction
    BEGIN TRANSACTION;
    
    -- Declare variables
    DECLARE @UserID INT;

    -- Insert data into User table
    INSERT INTO [User] (UserName, Email, [Password])
    SELECT i.username, i.email, i.password
	FROM inserted i;

    -- Retrieve the latest UserID
    SELECT @UserID = SCOPE_IDENTITY();

    -- Update BidHerald table with UserID
    INSERT INTO BidHerald
    SELECT UserID = @UserID, username, email, [password], LicenseNumber, ExperienceYears, Rating
    FROM inserted;

	INSERT INTO [UserRoles] (UserID, RoleID) VALUES (1, (SELECT RoleID FROM [Role] WHERE RoleName = 'Bid Herald'))
	
    -- Commit transaction
    COMMIT TRANSACTION;
END;

CREATE TRIGGER SeparateDataForCaptainRegistration
ON [Captain]
INSTEAD OF INSERT
AS
BEGIN
    -- Begin transaction
    BEGIN TRANSACTION;
    
    -- Declare variables
    DECLARE @UserID INT;

    -- Insert data into User table
    INSERT INTO [User] (UserName, Email, [Password])
    SELECT i.username, i.email, i.password
	FROM inserted i;

    -- Retrieve the latest UserID
    SELECT @UserID = SCOPE_IDENTITY();

    -- Update BidHerald table with UserID
    INSERT INTO Captain
    SELECT UserID = @UserID, username, email, [password], LicenseNumber, ExperienceYears, Rating
    FROM inserted;

	INSERT INTO [UserRoles] (UserID, RoleID) VALUES (1, (SELECT RoleID FROM [Role] WHERE RoleName = 'Captain'))
	
    -- Commit transaction
    COMMIT TRANSACTION;
END;



CREATE TRIGGER SeparateDataForCaptainRegistration
ON [Captain]
INSTEAD OF INSERT
AS
BEGIN
    -- Begin transaction
    BEGIN TRANSACTION;
    
    -- Declare variables
    DECLARE @UserID INT;

    -- Insert data into User table
    INSERT INTO [User] (UserName, Email, [Password])
    SELECT i.username, i.email, i.password
	FROM inserted i;

    -- Retrieve the latest UserID
    SELECT @UserID = SCOPE_IDENTITY();

    -- Update BidHerald table with UserID
    INSERT INTO Captain
    SELECT UserID = @UserID, username, email, [password], TeamManagedID
    FROM inserted;

	INSERT INTO [UserRoles] (UserID, RoleID) VALUES (1, (SELECT RoleID FROM [Role] WHERE RoleName = 'Captain'))
	
    -- Commit transaction
    COMMIT TRANSACTION;
END;

CREATE TRIGGER SeparateDataForCaptainRegistration
ON [Player]
INSTEAD OF INSERT
AS
BEGIN
    -- Begin transaction
    BEGIN TRANSACTION;
    
    -- Declare variables
    DECLARE @UserID INT;

    -- Insert data into User table
    INSERT INTO [User] (UserName, Email, [Password])
    SELECT i.username, i.email, i.password
	FROM inserted i;

    -- Retrieve the latest UserID
    SELECT @UserID = SCOPE_IDENTITY();

    -- Update BidHerald table with UserID
    INSERT INTO Player
    SELECT UserID = @UserID, username, email, [password], [status]
    FROM inserted;

	INSERT INTO [UserRoles] (UserID, RoleID) VALUES (1, (SELECT RoleID FROM [Role] WHERE RoleName = 'Player'))
	
    -- Commit transaction
    COMMIT TRANSACTION;
END;

CREATE TRIGGER SeparateDataForTeamPlayerRegistration
ON [TeamPlayer]
INSTEAD OF INSERT
AS
BEGIN
    -- Begin transaction
    BEGIN TRANSACTION;
    
    -- Declare variables
    DECLARE @UserID INT;

    -- Insert data into User table
    INSERT INTO [User] (UserName, Email, [Password])
    SELECT i.username, i.email, i.password
	FROM inserted i;

    -- Retrieve the latest UserID
    SELECT @UserID = SCOPE_IDENTITY();

    -- Update BidHerald table with UserID
    INSERT INTO TeamPlayer
    SELECT UserID = @UserID, username, email, [password], Position, TeamID
    FROM inserted;

	INSERT INTO [UserRoles] (UserID, RoleID) VALUES (1, (SELECT RoleID FROM [Role] WHERE RoleName = 'TeamPlayer'))
	
    -- Commit transaction
    COMMIT TRANSACTION;
END;

DELETE FROM [User] WHERE 1 = 1;
DELETE FROM [Role] WHERE 1 = 1;
DELETE FROM [UserRoles] WHERE 1 = 1;
DELETE FROM [Auction] WHERE 1 = 1;

DBCC CHECKIDENT ('User', RESEED, 0);
DBCC CHECKIDENT ('Role', RESEED, 0);
DBCC CHECKIDENT ('Auction', RESEED, 0);

INSERT INTO [Role](RoleName) VALUES ('Bid Herald');
INSERT INTO [Role](RoleName) VALUES ('Captain');
INSERT INTO [Role](RoleName) VALUES ('TeamPlayer');
INSERT INTO [Role](RoleName) VALUES ('Player');
INSERT INTO [Role](RoleName) VALUES ('User');

INSERT INTO [User](Username, Email, Password) VALUES('sad', 'hassanejaz400@gmail.com', 'Pass@1234');

INSERT INTO [UserRoles](UserID, RoleID) VALUES (1, 1);

INSERT INTO [dbo].[Auction] ([Name], [Description], [StartTime], [EndTime], [Duration], [Status])
VALUES
('ABC', 'asd', '2024-05-05 12:00:00', '2024-05-05 13:00:00', 3600, 'Planned'),
('DEF', 'asdasd', '2024-05-06 10:00:00', '2024-05-06 12:00:00', 7200, 'Active'),
('GHI', 'asdad', '2024-05-07 15:00:00', '2024-05-07 16:30:00', 5400, 'Completed');

INSERT INTO [dbo].[Auction] ([Name], [Description], [StartTime], [EndTime], [Duration], [Status])
VALUES
('Auction 1', 'Description 1', '2024-05-05 12:00:00', '2024-05-05 13:00:00', 3600, 'Planned'),
('Auction 2', 'Description 2', '2024-05-06 10:00:00', '2024-05-06 12:00:00', 7200, 'Active'),
('Auction 3', 'Description 3', '2024-05-07 15:00:00', '2024-05-07 16:30:00', 5400, 'Completed'),
('Auction 4', 'Description 4', '2024-05-08 12:00:00', '2024-05-08 13:00:00', 7200, 'Planned'),
('Auction 5', 'Description 5', '2024-05-09 10:00:00', '2024-05-09 12:00:00', 5400, 'Active'),
('Auction 6', 'Description 6', '2024-05-10 15:00:00', '2024-05-10 16:30:00', 3600, 'Completed'),
('Auction 7', 'Description 7', '2024-05-11 12:00:00', '2024-05-11 13:00:00', 7200, 'Planned'),
('Auction 8', 'Description 8', '2024-05-12 10:00:00', '2024-05-12 12:00:00', 5400, 'Active'),
('Auction 9', 'Description 9', '2024-05-13 15:00:00', '2024-05-13 16:30:00', 3600, 'Completed'),
('Auction 10', 'Description 10', '2024-05-14 12:00:00', '2024-05-14 13:00:00', 7200, 'Planned');

SELECT * FROM [User];
SELECT * FROM [Role];
SELECT * FROM [UserRoles];
SELECT * FROM [BidHerald];
SELECT * FROM [Player];
SELECT * FROM [Auction];
SELECT * FROM [Captain];
SELECT * FROM [AuctionHerald];
SELECT * FROM [Participants];

SELECT u.UserID, u.UserName, u.Email, r.RoleName FROM [User] u LEFT JOIN UserRoles ur ON u.UserID = ur.UserID INNER JOIN Role r ON ur.RoleID = r.RoleID WHERE


create database TAMS;
USE TAMS;

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
    [LicenseNumber] VARCHAR(255) NOT NULL,
    [ExperienceYears] INT NOT NULL,
    [Rating] DECIMAL(3,2) NULL
);

-- Create Captain Table
CREATE TABLE [dbo].[Captain] (
    [UserID] INT PRIMARY KEY,
    [TeamManagedID] INT NULL
);

-- Create Player Table
CREATE TABLE [dbo].[Player] (
    [UserID] INT PRIMARY KEY,
    [HealthStatus] VARCHAR(100) NOT NULL
);

-- Create Auction Table
CREATE TABLE [dbo].[Auction] (
    [AuctionID] INT IDENTITY(1,1) PRIMARY KEY,
    [CreatedBy] INT NOT NULL,
    [StartTime] DATETIME NOT NULL,
    [EndTime] DATETIME NOT NULL,
    [Duration] INT NOT NULL,
    [Status] VARCHAR(50) CHECK ([Status] IN ('Planned', 'Active', 'Completed'))
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

-- Create TeamPlayer Table
CREATE TABLE [dbo].[TeamPlayer] (
    [TeamID] INT,
    [PlayerID] INT,
    [Position] VARCHAR(50) CHECK ([Position] IN ('Main', 'Substitute')),
    PRIMARY KEY ([TeamID], [PlayerID])
);

-- Create Tournament Table
CREATE TABLE [dbo].[Tournament] (
    [TournamentID] INT IDENTITY(1,1) PRIMARY KEY,
    [Name] VARCHAR(255) NOT NULL,
    [StartDate] DATE NOT NULL,
    [EndDate] DATE NOT NULL,
    [Location] VARCHAR(255) NOT NULL
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

-- Foreign Keys for Auction
ALTER TABLE [dbo].[Auction] ADD CONSTRAINT [FK_Auction_User] FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[User]([UserID]);

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

-- Add a record into the UserRoles table upon insertion in User table
CREATE OR ALTER TRIGGER AssignRolesAfterInsertUser
ON [dbo].[User]
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO [dbo].[UserRoles] (UserID, RoleID)
    SELECT i.UserID, i.RoleID FROM inserted i;
END;

--
CREATE OR ALTER TRIGGER InsertUserRoleIfExists
ON [dbo].[User]
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO [dbo].[UserRoles] (UserID, RoleID)
    SELECT i.UserID, i.RoleID
    FROM inserted i
	WHERE EXISTS (SELECT r.RoleID FROM [Role] r WHERE r.roleID = i.RoleID);

	INSERT INTO [dbo].[User] (RoleID, Username, Email, Password)
	SELECT i.RoleID, i.Username, i.Email, i.Password
	FROM inserted i
END;
-- 

CREATE TRIGGER DeleteAssignedRolesOnUserRemoval
ON [dbo].[User]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;

	DELETE ur FROM [dbo].[UserRoles] ur
	INNER JOIN deleted d ON ur.UserID = d.UserID
END

DELETE FROM [User] WHERE [UserID] = 1;
DELETE FROM [Role] WHERE [RoleID] = 1;
DELETE FROM [UserRoles] WHERE [UserID] = 1;

DBCC CHECKIDENT ('User', RESEED, 0);
DBCC CHECKIDENT ('Role', RESEED, 5);

INSERT INTO [Role](RoleName) VALUES ('Bid Herald');
INSERT INTO [Role](RoleName) VALUES ('Captain');
INSERT INTO [Role](RoleName) VALUES ('TeamPlayer');
INSERT INTO [Role](RoleName) VALUES ('Player');
INSERT INTO [Role](RoleName) VALUES ('User');

INSERT INTO [User](Username, Email, Password) VALUES('sad', 'hassanejaz400@gmail.com', 'Pass@1234');

INSERT INTO [UserRoles](UserID, RoleID) VALUES (1, 1);

SELECT * FROM [User]
SELECT * FROM [Role]
SELECT * FROM [UserRoles]

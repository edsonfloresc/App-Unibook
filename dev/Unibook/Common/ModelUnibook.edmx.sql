
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/17/2017 21:32:27
-- Generated from EDMX file: C:\Users\andii\Documents\GitHub\App-Unibook\dev\Unibook\Common\ModelUnibook.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Unibook];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserUserCareer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserCareer] DROP CONSTRAINT [FK_UserUserCareer];
GO
IF OBJECT_ID(N'[dbo].[FK_CareerUserCareer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserCareer] DROP CONSTRAINT [FK_CareerUserCareer];
GO
IF OBJECT_ID(N'[dbo].[FK_RoleUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User] DROP CONSTRAINT [FK_RoleUser];
GO
IF OBJECT_ID(N'[dbo].[FK_FacultyCareer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Career] DROP CONSTRAINT [FK_FacultyCareer];
GO
IF OBJECT_ID(N'[dbo].[FK_GenderPerson]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Person] DROP CONSTRAINT [FK_GenderPerson];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonContact]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contact] DROP CONSTRAINT [FK_PersonContact];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User] DROP CONSTRAINT [FK_PersonUser];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO
IF OBJECT_ID(N'[dbo].[Career]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Career];
GO
IF OBJECT_ID(N'[dbo].[Faculty]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Faculty];
GO
IF OBJECT_ID(N'[dbo].[Role]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Role];
GO
IF OBJECT_ID(N'[dbo].[UserCareer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserCareer];
GO
IF OBJECT_ID(N'[dbo].[Gender]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Gender];
GO
IF OBJECT_ID(N'[dbo].[Person]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Person];
GO
IF OBJECT_ID(N'[dbo].[Contact]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contact];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [UserId] bigint IDENTITY(1,1) NOT NULL,
    [Email] nvarchar(50)  NOT NULL,
    [Password] nvarchar(50)  NOT NULL,
    [RoleId] smallint  NOT NULL,
    [Deleted] bit  NOT NULL
);
GO

-- Creating table 'Career'
CREATE TABLE [dbo].[Career] (
    [CareerId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(30)  NOT NULL,
    [FacultyId] smallint  NOT NULL,
    [Deleted] bit  NOT NULL
);
GO

-- Creating table 'Faculty'
CREATE TABLE [dbo].[Faculty] (
    [FacultyId] smallint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Deleted] bit  NOT NULL
);
GO

-- Creating table 'Role'
CREATE TABLE [dbo].[Role] (
    [RoleId] smallint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(25)  NOT NULL,
    [Deleted] bit  NOT NULL
);
GO

-- Creating table 'UserCareer'
CREATE TABLE [dbo].[UserCareer] (
    [UserId] bigint  NOT NULL,
    [CareerId] int  NOT NULL,
    [UserCareerId] bigint IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Gender'
CREATE TABLE [dbo].[Gender] (
    [GenderId] smallint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'Person'
CREATE TABLE [dbo].[Person] (
    [PersonId] bigint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(25)  NOT NULL,
    [LastName] nvarchar(25)  NOT NULL,
    [GenderId] smallint  NOT NULL,
    [Birthday] datetime  NOT NULL,
    [UserId] bigint  NOT NULL
);
GO

-- Creating table 'Contact'
CREATE TABLE [dbo].[Contact] (
    [ContactId] bigint IDENTITY(1,1) NOT NULL,
    [Data] nvarchar(max)  NOT NULL,
    [Description] nvarchar(50)  NOT NULL,
    [Deleted] bit  NOT NULL,
    [PersonId] bigint  NOT NULL
);
GO

-- Creating table 'CategoryEnter'
CREATE TABLE [dbo].[CategoryEnter] (
    [CategoryId] smallint IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Deleted] bit  NOT NULL
);
GO

-- Creating table 'Entertainment'
CREATE TABLE [dbo].[Entertainment] (
    [EntertainmentId] bigint IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [PlaceAddress] nvarchar(max)  NOT NULL,
    [DateHour] datetime  NOT NULL,
    [Details] nvarchar(max)  NOT NULL,
    [Deleted] bit  NOT NULL,
    [Discontinued] bit  NOT NULL,
    [CategoryId] smallint  NOT NULL,
    [UserId] bigint  NOT NULL
);
GO

-- Creating table 'CommentEnter'
CREATE TABLE [dbo].[CommentEnter] (
    [CommentId] bigint IDENTITY(1,1) NOT NULL,
    [CommentText] nvarchar(max)  NOT NULL,
    [DateHour] datetime  NOT NULL,
    [Deleted] bit  NOT NULL,
    [EntertainmentId] bigint  NOT NULL,
    [UserId] bigint  NOT NULL
);
GO

-- Creating table 'ImageEnter'
CREATE TABLE [dbo].[ImageEnter] (
    [ImageId] bigint IDENTITY(1,1) NOT NULL,
    [PathImage] nvarchar(max)  NOT NULL,
    [Deleted] bit  NOT NULL,
    [EntertainmentId] bigint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UserId] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [CareerId] in table 'Career'
ALTER TABLE [dbo].[Career]
ADD CONSTRAINT [PK_Career]
    PRIMARY KEY CLUSTERED ([CareerId] ASC);
GO

-- Creating primary key on [FacultyId] in table 'Faculty'
ALTER TABLE [dbo].[Faculty]
ADD CONSTRAINT [PK_Faculty]
    PRIMARY KEY CLUSTERED ([FacultyId] ASC);
GO

-- Creating primary key on [RoleId] in table 'Role'
ALTER TABLE [dbo].[Role]
ADD CONSTRAINT [PK_Role]
    PRIMARY KEY CLUSTERED ([RoleId] ASC);
GO

-- Creating primary key on [UserCareerId] in table 'UserCareer'
ALTER TABLE [dbo].[UserCareer]
ADD CONSTRAINT [PK_UserCareer]
    PRIMARY KEY CLUSTERED ([UserCareerId] ASC);
GO

-- Creating primary key on [GenderId] in table 'Gender'
ALTER TABLE [dbo].[Gender]
ADD CONSTRAINT [PK_Gender]
    PRIMARY KEY CLUSTERED ([GenderId] ASC);
GO

-- Creating primary key on [PersonId] in table 'Person'
ALTER TABLE [dbo].[Person]
ADD CONSTRAINT [PK_Person]
    PRIMARY KEY CLUSTERED ([PersonId] ASC);
GO

-- Creating primary key on [ContactId] in table 'Contact'
ALTER TABLE [dbo].[Contact]
ADD CONSTRAINT [PK_Contact]
    PRIMARY KEY CLUSTERED ([ContactId] ASC);
GO

-- Creating primary key on [CategoryId] in table 'CategoryEnter'
ALTER TABLE [dbo].[CategoryEnter]
ADD CONSTRAINT [PK_CategoryEnter]
    PRIMARY KEY CLUSTERED ([CategoryId] ASC);
GO

-- Creating primary key on [EntertainmentId] in table 'Entertainment'
ALTER TABLE [dbo].[Entertainment]
ADD CONSTRAINT [PK_Entertainment]
    PRIMARY KEY CLUSTERED ([EntertainmentId] ASC);
GO

-- Creating primary key on [CommentId] in table 'CommentEnter'
ALTER TABLE [dbo].[CommentEnter]
ADD CONSTRAINT [PK_CommentEnter]
    PRIMARY KEY CLUSTERED ([CommentId] ASC);
GO

-- Creating primary key on [ImageId] in table 'ImageEnter'
ALTER TABLE [dbo].[ImageEnter]
ADD CONSTRAINT [PK_ImageEnter]
    PRIMARY KEY CLUSTERED ([ImageId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId] in table 'UserCareer'
ALTER TABLE [dbo].[UserCareer]
ADD CONSTRAINT [FK_UserUserCareer]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[User]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserUserCareer'
CREATE INDEX [IX_FK_UserUserCareer]
ON [dbo].[UserCareer]
    ([UserId]);
GO

-- Creating foreign key on [CareerId] in table 'UserCareer'
ALTER TABLE [dbo].[UserCareer]
ADD CONSTRAINT [FK_CareerUserCareer]
    FOREIGN KEY ([CareerId])
    REFERENCES [dbo].[Career]
        ([CareerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CareerUserCareer'
CREATE INDEX [IX_FK_CareerUserCareer]
ON [dbo].[UserCareer]
    ([CareerId]);
GO

-- Creating foreign key on [RoleId] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [FK_RoleUser]
    FOREIGN KEY ([RoleId])
    REFERENCES [dbo].[Role]
        ([RoleId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RoleUser'
CREATE INDEX [IX_FK_RoleUser]
ON [dbo].[User]
    ([RoleId]);
GO

-- Creating foreign key on [FacultyId] in table 'Career'
ALTER TABLE [dbo].[Career]
ADD CONSTRAINT [FK_FacultyCareer]
    FOREIGN KEY ([FacultyId])
    REFERENCES [dbo].[Faculty]
        ([FacultyId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacultyCareer'
CREATE INDEX [IX_FK_FacultyCareer]
ON [dbo].[Career]
    ([FacultyId]);
GO

-- Creating foreign key on [GenderId] in table 'Person'
ALTER TABLE [dbo].[Person]
ADD CONSTRAINT [FK_GenderPerson]
    FOREIGN KEY ([GenderId])
    REFERENCES [dbo].[Gender]
        ([GenderId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GenderPerson'
CREATE INDEX [IX_FK_GenderPerson]
ON [dbo].[Person]
    ([GenderId]);
GO

-- Creating foreign key on [PersonId] in table 'Contact'
ALTER TABLE [dbo].[Contact]
ADD CONSTRAINT [FK_PersonContact]
    FOREIGN KEY ([PersonId])
    REFERENCES [dbo].[Person]
        ([PersonId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonContact'
CREATE INDEX [IX_FK_PersonContact]
ON [dbo].[Contact]
    ([PersonId]);
GO

-- Creating foreign key on [UserId] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [FK_PersonUser]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Person]
        ([PersonId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CategoryEnter_CategoryId] in table 'Entertainment'
ALTER TABLE [dbo].[Entertainment]
ADD CONSTRAINT [FK_CategoryEnterEntertainment]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[CategoryEnter]
        ([CategoryId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryEnterEntertainment'
CREATE INDEX [IX_FK_CategoryEnterEntertainment]
ON [dbo].[Entertainment]
    ([CategoryId]);
GO

-- Creating foreign key on [Entertainment_EntertainmentId] in table 'ImageEnter'
ALTER TABLE [dbo].[ImageEnter]
ADD CONSTRAINT [FK_EntertainmentImageEnter]
    FOREIGN KEY ([EntertainmentId])
    REFERENCES [dbo].[Entertainment]
        ([EntertainmentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EntertainmentImageEnter'
CREATE INDEX [IX_FK_EntertainmentImageEnter]
ON [dbo].[ImageEnter]
    ([EntertainmentId]);
GO

-- Creating foreign key on [Entertainment_EntertainmentId] in table 'CommentEnter'
ALTER TABLE [dbo].[CommentEnter]
ADD CONSTRAINT [FK_EntertainmentCommentEnter]
    FOREIGN KEY ([EntertainmentId])
    REFERENCES [dbo].[Entertainment]
        ([EntertainmentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EntertainmentCommentEnter'
CREATE INDEX [IX_FK_EntertainmentCommentEnter]
ON [dbo].[CommentEnter]
    ([EntertainmentId]);
GO

-- Creating foreign key on [User_UserId] in table 'Entertainment'
ALTER TABLE [dbo].[Entertainment]
ADD CONSTRAINT [FK_UserEntertainment]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[User]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserEntertainment'
CREATE INDEX [IX_FK_UserEntertainment]
ON [dbo].[Entertainment]
    ([UserId]);
GO

-- Creating foreign key on [User_UserId] in table 'CommentEnter'
ALTER TABLE [dbo].[CommentEnter]
ADD CONSTRAINT [FK_UserCommentEnter]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[User]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserCommentEnter'
CREATE INDEX [IX_FK_UserCommentEnter]
ON [dbo].[CommentEnter]
    ([UserId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
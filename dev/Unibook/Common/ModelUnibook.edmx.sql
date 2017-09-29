
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/28/2017 22:02:36
-- Generated from EDMX file: E:\Univalle\Programacion Avanzada II\App-Unibook\dev\Unibook\Common\ModelUnibook.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [UniBook];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserUserCareer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserCareerSet] DROP CONSTRAINT [FK_UserUserCareer];
GO
IF OBJECT_ID(N'[dbo].[FK_CareerUserCareer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserCareerSet] DROP CONSTRAINT [FK_CareerUserCareer];
GO
IF OBJECT_ID(N'[dbo].[FK_RoleUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSet] DROP CONSTRAINT [FK_RoleUser];
GO
IF OBJECT_ID(N'[dbo].[FK_FacultyCareer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CareerSet] DROP CONSTRAINT [FK_FacultyCareer];
GO
IF OBJECT_ID(N'[dbo].[FK_GenderUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSet] DROP CONSTRAINT [FK_GenderUser];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet];
GO
IF OBJECT_ID(N'[dbo].[CareerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CareerSet];
GO
IF OBJECT_ID(N'[dbo].[FacultySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FacultySet];
GO
IF OBJECT_ID(N'[dbo].[RoleSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RoleSet];
GO
IF OBJECT_ID(N'[dbo].[UserCareerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserCareerSet];
GO
IF OBJECT_ID(N'[dbo].[GenderSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GenderSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [UserId] bigint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [GenderId] smallint  NOT NULL,
    [Birthday] datetime  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [RoleId] smallint  NOT NULL,
    [Deleted] bit  NOT NULL,
    [Role_RoleId] smallint  NOT NULL,
    [Gender_GenderId] smallint  NOT NULL
);
GO

-- Creating table 'CareerSet'
CREATE TABLE [dbo].[CareerSet] (
    [CareerId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [FacultyId] smallint  NOT NULL,
    [Deleted] bit  NOT NULL,
    [Faculty_faculty_Id] smallint  NOT NULL
);
GO

-- Creating table 'FacultySet'
CREATE TABLE [dbo].[FacultySet] (
    [faculty_Id] smallint IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [delete] bit  NOT NULL
);
GO

-- Creating table 'RoleSet'
CREATE TABLE [dbo].[RoleSet] (
    [RoleId] smallint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Deleted] bit  NOT NULL
);
GO

-- Creating table 'UserCareerSet'
CREATE TABLE [dbo].[UserCareerSet] (
    [UserId] bigint  NOT NULL,
    [CareerId] int  NOT NULL,
    [UserCareerId] nvarchar(max)  NOT NULL,
    [User_UserId] bigint  NOT NULL,
    [Career_CareerId] int  NOT NULL
);
GO

-- Creating table 'GenderSet'
CREATE TABLE [dbo].[GenderSet] (
    [GenderId] smallint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UserId] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [CareerId] in table 'CareerSet'
ALTER TABLE [dbo].[CareerSet]
ADD CONSTRAINT [PK_CareerSet]
    PRIMARY KEY CLUSTERED ([CareerId] ASC);
GO

-- Creating primary key on [faculty_Id] in table 'FacultySet'
ALTER TABLE [dbo].[FacultySet]
ADD CONSTRAINT [PK_FacultySet]
    PRIMARY KEY CLUSTERED ([faculty_Id] ASC);
GO

-- Creating primary key on [RoleId] in table 'RoleSet'
ALTER TABLE [dbo].[RoleSet]
ADD CONSTRAINT [PK_RoleSet]
    PRIMARY KEY CLUSTERED ([RoleId] ASC);
GO

-- Creating primary key on [UserCareerId] in table 'UserCareerSet'
ALTER TABLE [dbo].[UserCareerSet]
ADD CONSTRAINT [PK_UserCareerSet]
    PRIMARY KEY CLUSTERED ([UserCareerId] ASC);
GO

-- Creating primary key on [GenderId] in table 'GenderSet'
ALTER TABLE [dbo].[GenderSet]
ADD CONSTRAINT [PK_GenderSet]
    PRIMARY KEY CLUSTERED ([GenderId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [User_UserId] in table 'UserCareerSet'
ALTER TABLE [dbo].[UserCareerSet]
ADD CONSTRAINT [FK_UserUserCareer]
    FOREIGN KEY ([User_UserId])
    REFERENCES [dbo].[UserSet]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserUserCareer'
CREATE INDEX [IX_FK_UserUserCareer]
ON [dbo].[UserCareerSet]
    ([User_UserId]);
GO

-- Creating foreign key on [Career_CareerId] in table 'UserCareerSet'
ALTER TABLE [dbo].[UserCareerSet]
ADD CONSTRAINT [FK_CareerUserCareer]
    FOREIGN KEY ([Career_CareerId])
    REFERENCES [dbo].[CareerSet]
        ([CareerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CareerUserCareer'
CREATE INDEX [IX_FK_CareerUserCareer]
ON [dbo].[UserCareerSet]
    ([Career_CareerId]);
GO

-- Creating foreign key on [Role_RoleId] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [FK_RoleUser]
    FOREIGN KEY ([Role_RoleId])
    REFERENCES [dbo].[RoleSet]
        ([RoleId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RoleUser'
CREATE INDEX [IX_FK_RoleUser]
ON [dbo].[UserSet]
    ([Role_RoleId]);
GO

-- Creating foreign key on [Faculty_faculty_Id] in table 'CareerSet'
ALTER TABLE [dbo].[CareerSet]
ADD CONSTRAINT [FK_FacultyCareer]
    FOREIGN KEY ([Faculty_faculty_Id])
    REFERENCES [dbo].[FacultySet]
        ([faculty_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FacultyCareer'
CREATE INDEX [IX_FK_FacultyCareer]
ON [dbo].[CareerSet]
    ([Faculty_faculty_Id]);
GO

-- Creating foreign key on [Gender_GenderId] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [FK_GenderUser]
    FOREIGN KEY ([Gender_GenderId])
    REFERENCES [dbo].[GenderSet]
        ([GenderId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_GenderUser'
CREATE INDEX [IX_FK_GenderUser]
ON [dbo].[UserSet]
    ([Gender_GenderId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
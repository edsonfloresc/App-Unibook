
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/02/2017 03:52:24
-- Generated from EDMX file: C:\Users\andii\Desktop\Programacion2\App-Unibook-master\dev\Unibook\Common\ModelUnibook.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BddUnibook];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


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
    [Faculty_FacultyId] smallint  NOT NULL
);
GO

-- Creating table 'FacultySet'
CREATE TABLE [dbo].[FacultySet] (
    [FacultyId] smallint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Deleted] bit  NOT NULL
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
    [UserCareerId] bigint IDENTITY(1,1) NOT NULL,
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

-- Creating table 'ImageSet'
CREATE TABLE [dbo].[ImageSet] (
    [ImageId] bigint IDENTITY(1,1) NOT NULL,
    [EntertainmentId] bigint  NOT NULL,
    [PathImage] nvarchar(max)  NOT NULL,
    [Deleted] bit  NOT NULL,
    [Entertainment_EntertainmentId] bigint  NOT NULL
);
GO

-- Creating table 'EntertainmentSet'
CREATE TABLE [dbo].[EntertainmentSet] (
    [EntertainmentId] bigint IDENTITY(1,1) NOT NULL,
    [CategoryId] smallint  NOT NULL,
    [UserId] bigint  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [PlaceAddress] nvarchar(max)  NOT NULL,
    [DateHour] datetime  NOT NULL,
    [Details] nvarchar(max)  NOT NULL,
    [Deleted] bit  NOT NULL,
    [Discontinued] bit  NOT NULL,
    [User_UserId] bigint  NOT NULL
);
GO

-- Creating table 'CategorySet'
CREATE TABLE [dbo].[CategorySet] (
    [CategoryId] smallint IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Deleted] bit  NOT NULL,
    [Entertainment_EntertainmentId] bigint  NOT NULL
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

-- Creating primary key on [FacultyId] in table 'FacultySet'
ALTER TABLE [dbo].[FacultySet]
ADD CONSTRAINT [PK_FacultySet]
    PRIMARY KEY CLUSTERED ([FacultyId] ASC);
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

-- Creating primary key on [ImageId] in table 'ImageSet'
ALTER TABLE [dbo].[ImageSet]
ADD CONSTRAINT [PK_ImageSet]
    PRIMARY KEY CLUSTERED ([ImageId] ASC);
GO

-- Creating primary key on [EntertainmentId] in table 'EntertainmentSet'
ALTER TABLE [dbo].[EntertainmentSet]
ADD CONSTRAINT [PK_EntertainmentSet]
    PRIMARY KEY CLUSTERED ([EntertainmentId] ASC);
GO

-- Creating primary key on [CategoryId] in table 'CategorySet'
ALTER TABLE [dbo].[CategorySet]
ADD CONSTRAINT [PK_CategorySet]
    PRIMARY KEY CLUSTERED ([CategoryId] ASC);
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

-- Creating foreign key on [Faculty_FacultyId] in table 'CareerSet'
ALTER TABLE [dbo].[CareerSet]
ADD CONSTRAINT [FK_FacultyCareer]
    FOREIGN KEY ([Faculty_FacultyId])
    REFERENCES [dbo].[FacultySet]
        ([FacultyId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FacultyCareer'
CREATE INDEX [IX_FK_FacultyCareer]
ON [dbo].[CareerSet]
    ([Faculty_FacultyId]);
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

-- Creating foreign key on [User_UserId] in table 'EntertainmentSet'
ALTER TABLE [dbo].[EntertainmentSet]
ADD CONSTRAINT [FK_UserEntertainment]
    FOREIGN KEY ([User_UserId])
    REFERENCES [dbo].[UserSet]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserEntertainment'
CREATE INDEX [IX_FK_UserEntertainment]
ON [dbo].[EntertainmentSet]
    ([User_UserId]);
GO

-- Creating foreign key on [Entertainment_EntertainmentId] in table 'CategorySet'
ALTER TABLE [dbo].[CategorySet]
ADD CONSTRAINT [FK_EntertainmentCategory]
    FOREIGN KEY ([Entertainment_EntertainmentId])
    REFERENCES [dbo].[EntertainmentSet]
        ([EntertainmentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EntertainmentCategory'
CREATE INDEX [IX_FK_EntertainmentCategory]
ON [dbo].[CategorySet]
    ([Entertainment_EntertainmentId]);
GO

-- Creating foreign key on [Entertainment_EntertainmentId] in table 'ImageSet'
ALTER TABLE [dbo].[ImageSet]
ADD CONSTRAINT [FK_EntertainmentImage]
    FOREIGN KEY ([Entertainment_EntertainmentId])
    REFERENCES [dbo].[EntertainmentSet]
        ([EntertainmentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EntertainmentImage'
CREATE INDEX [IX_FK_EntertainmentImage]
ON [dbo].[ImageSet]
    ([Entertainment_EntertainmentId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
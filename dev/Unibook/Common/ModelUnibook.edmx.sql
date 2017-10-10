
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/09/2017 13:27:14
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
IF OBJECT_ID(N'[dbo].[FK_EntertainmentImage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ImageSet] DROP CONSTRAINT [FK_EntertainmentImage];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoryEntertainment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EntertainmentSet] DROP CONSTRAINT [FK_CategoryEntertainment];
GO
IF OBJECT_ID(N'[dbo].[FK_UserEntertainment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EntertainmentSet] DROP CONSTRAINT [FK_UserEntertainment];
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
IF OBJECT_ID(N'[dbo].[ImageSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ImageSet];
GO
IF OBJECT_ID(N'[dbo].[EntertainmentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EntertainmentSet];
GO
IF OBJECT_ID(N'[dbo].[CategorySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CategorySet];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [UserId] bigint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [GenderId] smallint  NULL,
    [Birthday] datetime  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [RoleId] smallint  NULL,
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

-- Creating table 'ImageEnterSet'
CREATE TABLE [dbo].[ImageEnterSet] (
    [ImageId] bigint IDENTITY(1,1) NOT NULL,
    [PathImage] nvarchar(max)  NOT NULL,
    [Deleted] bit  NOT NULL,
    [EntertainmentId_EntertainmentId] bigint  NOT NULL
);
GO

-- Creating table 'EntertainmentSet'
CREATE TABLE [dbo].[EntertainmentSet] (
    [EntertainmentId] bigint IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [PlaceAddress] nvarchar(max)  NOT NULL,
    [DateHour] datetime  NOT NULL,
    [Details] nvarchar(max)  NOT NULL,
    [Deleted] bit  NOT NULL,
    [Discontinued] bit  NOT NULL,
    [CategoryId_CategoryId] smallint  NOT NULL,
    [UserId_UserId] bigint  NOT NULL
);
GO

-- Creating table 'CategoryEnterSet'
CREATE TABLE [dbo].[CategoryEnterSet] (
    [CategoryId] smallint IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Deleted] bit  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'CommentEnterSet'
CREATE TABLE [dbo].[CommentEnterSet] (
    [CommentId] bigint IDENTITY(1,1) NOT NULL,
    [CommentText] nvarchar(max)  NOT NULL,
    [DateHour] datetime  NOT NULL,
    [UserId_UserId] bigint  NOT NULL,
    [EntertainmentId_EntertainmentId] bigint  NOT NULL
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

-- Creating primary key on [ImageId] in table 'ImageEnterSet'
ALTER TABLE [dbo].[ImageEnterSet]
ADD CONSTRAINT [PK_ImageEnterSet]
    PRIMARY KEY CLUSTERED ([ImageId] ASC);
GO

-- Creating primary key on [EntertainmentId] in table 'EntertainmentSet'
ALTER TABLE [dbo].[EntertainmentSet]
ADD CONSTRAINT [PK_EntertainmentSet]
    PRIMARY KEY CLUSTERED ([EntertainmentId] ASC);
GO

-- Creating primary key on [CategoryId] in table 'CategoryEnterSet'
ALTER TABLE [dbo].[CategoryEnterSet]
ADD CONSTRAINT [PK_CategoryEnterSet]
    PRIMARY KEY CLUSTERED ([CategoryId] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [CommentId] in table 'CommentEnterSet'
ALTER TABLE [dbo].[CommentEnterSet]
ADD CONSTRAINT [PK_CommentEnterSet]
    PRIMARY KEY CLUSTERED ([CommentId] ASC);
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

-- Creating foreign key on [EntertainmentId_EntertainmentId] in table 'ImageEnterSet'
ALTER TABLE [dbo].[ImageEnterSet]
ADD CONSTRAINT [FK_EntertainmentImage]
    FOREIGN KEY ([EntertainmentId_EntertainmentId])
    REFERENCES [dbo].[EntertainmentSet]
        ([EntertainmentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EntertainmentImage'
CREATE INDEX [IX_FK_EntertainmentImage]
ON [dbo].[ImageEnterSet]
    ([EntertainmentId_EntertainmentId]);
GO

-- Creating foreign key on [CategoryId_CategoryId] in table 'EntertainmentSet'
ALTER TABLE [dbo].[EntertainmentSet]
ADD CONSTRAINT [FK_CategoryEntertainment]
    FOREIGN KEY ([CategoryId_CategoryId])
    REFERENCES [dbo].[CategoryEnterSet]
        ([CategoryId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryEntertainment'
CREATE INDEX [IX_FK_CategoryEntertainment]
ON [dbo].[EntertainmentSet]
    ([CategoryId_CategoryId]);
GO

-- Creating foreign key on [UserId_UserId] in table 'EntertainmentSet'
ALTER TABLE [dbo].[EntertainmentSet]
ADD CONSTRAINT [FK_UserEntertainment]
    FOREIGN KEY ([UserId_UserId])
    REFERENCES [dbo].[UserSet]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserEntertainment'
CREATE INDEX [IX_FK_UserEntertainment]
ON [dbo].[EntertainmentSet]
    ([UserId_UserId]);
GO

-- Creating foreign key on [UserId_UserId] in table 'CommentEnterSet'
ALTER TABLE [dbo].[CommentEnterSet]
ADD CONSTRAINT [FK_UserCommentEnter]
    FOREIGN KEY ([UserId_UserId])
    REFERENCES [dbo].[UserSet]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserCommentEnter'
CREATE INDEX [IX_FK_UserCommentEnter]
ON [dbo].[CommentEnterSet]
    ([UserId_UserId]);
GO

-- Creating foreign key on [EntertainmentId_EntertainmentId] in table 'CommentEnterSet'
ALTER TABLE [dbo].[CommentEnterSet]
ADD CONSTRAINT [FK_EntertainmentCommentEnter]
    FOREIGN KEY ([EntertainmentId_EntertainmentId])
    REFERENCES [dbo].[EntertainmentSet]
        ([EntertainmentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EntertainmentCommentEnter'
CREATE INDEX [IX_FK_EntertainmentCommentEnter]
ON [dbo].[CommentEnterSet]
    ([EntertainmentId_EntertainmentId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
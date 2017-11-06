
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/02/2017 20:37:47
-- Generated from EDMX file: E:\Proyectos\UniBook-Asp.Net\App-Unibook\dev\Unibook\Common\ModelUnibook.edmx
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
IF OBJECT_ID(N'[dbo].[FK_GenderPerson]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonSet] DROP CONSTRAINT [FK_GenderPerson];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonConctact]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContactSet] DROP CONSTRAINT [FK_PersonConctact];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonSet] DROP CONSTRAINT [FK_PersonUser];
GO
IF OBJECT_ID(N'[dbo].[FK_UserCommentAcademic]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CommentAcademicSet] DROP CONSTRAINT [FK_UserCommentAcademic];
GO
IF OBJECT_ID(N'[dbo].[FK_PublicationAcademicCommentAcademic]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CommentAcademicSet] DROP CONSTRAINT [FK_PublicationAcademicCommentAcademic];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoryAcademicPublicationAcademic]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PublicationAcademicSet] DROP CONSTRAINT [FK_CategoryAcademicPublicationAcademic];
GO
IF OBJECT_ID(N'[dbo].[FK_CareerSubjectCareer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SubjectCareerSet] DROP CONSTRAINT [FK_CareerSubjectCareer];
GO
IF OBJECT_ID(N'[dbo].[FK_SubjectSubjectCareer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SubjectCareerSet] DROP CONSTRAINT [FK_SubjectSubjectCareer];
GO
IF OBJECT_ID(N'[dbo].[FK_PublicationAcademicPublicationMatterCareerFaculty]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PublicationMatterCareerFacultySet] DROP CONSTRAINT [FK_PublicationAcademicPublicationMatterCareerFaculty];
GO
IF OBJECT_ID(N'[dbo].[FK_SubjectPublicationMatterCareerFaculty]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PublicationMatterCareerFacultySet] DROP CONSTRAINT [FK_SubjectPublicationMatterCareerFaculty];
GO
IF OBJECT_ID(N'[dbo].[FK_CareerPublicationMatterCareerFaculty]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PublicationMatterCareerFacultySet] DROP CONSTRAINT [FK_CareerPublicationMatterCareerFaculty];
GO
IF OBJECT_ID(N'[dbo].[FK_FacultyPublicationMatterCareerFaculty]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PublicationMatterCareerFacultySet] DROP CONSTRAINT [FK_FacultyPublicationMatterCareerFaculty];
GO
IF OBJECT_ID(N'[dbo].[FK_UserPublicationAcademic]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PublicationAcademicSet] DROP CONSTRAINT [FK_UserPublicationAcademic];
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
IF OBJECT_ID(N'[dbo].[CommentAcademicSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CommentAcademicSet];
GO
IF OBJECT_ID(N'[dbo].[PublicationAcademicSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PublicationAcademicSet];
GO
IF OBJECT_ID(N'[dbo].[CategoryAcademicSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CategoryAcademicSet];
GO
IF OBJECT_ID(N'[dbo].[PersonSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonSet];
GO
IF OBJECT_ID(N'[dbo].[ContactSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContactSet];
GO
IF OBJECT_ID(N'[dbo].[PublicationMatterCareerFacultySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PublicationMatterCareerFacultySet];
GO
IF OBJECT_ID(N'[dbo].[SubjectSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SubjectSet];
GO
IF OBJECT_ID(N'[dbo].[SubjectCareerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SubjectCareerSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [UserId] bigint IDENTITY(1,1) NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Deleted] bit  NOT NULL,
    [Role_RoleId] smallint  NOT NULL
);
GO

-- Creating table 'CareerSet'
CREATE TABLE [dbo].[CareerSet] (
    [CareerId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
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
    [UserCareerId] bigint IDENTITY(1,1) NOT NULL,
    [User_UserId] bigint  NOT NULL,
    [Career_CareerId] int  NOT NULL
);
GO

-- Creating table 'GenderSet'
CREATE TABLE [dbo].[GenderSet] (
    [GenderId] tinyint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CommentAcademicSet'
CREATE TABLE [dbo].[CommentAcademicSet] (
    [CommentAcademicId] bigint IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [DateComment] datetime  NOT NULL,
    [Deleted] bit  NOT NULL,
    [User_UserId] bigint  NOT NULL,
    [PublicationAcademic_PublicationAcademicId] bigint  NOT NULL
);
GO

-- Creating table 'PublicationAcademicSet'
CREATE TABLE [dbo].[PublicationAcademicSet] (
    [PublicationAcademicId] bigint IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Image] nvarchar(max)  NULL,
    [DatePublication] datetime  NOT NULL,
    [Deleted] bit  NOT NULL,
    [CategoryAcademic_CategoryAcademicId] tinyint  NOT NULL,
    [User_UserId] bigint  NOT NULL
);
GO

-- Creating table 'CategoryAcademicSet'
CREATE TABLE [dbo].[CategoryAcademicSet] (
    [CategoryAcademicId] tinyint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Deleted] bit  NOT NULL
);
GO

-- Creating table 'PersonSet'
CREATE TABLE [dbo].[PersonSet] (
    [PersonId] bigint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [BirthDay] datetime  NULL,
    [Deleted] bit  NOT NULL,
    [Gender_GenderId] tinyint  NOT NULL,
    [User_UserId] bigint  NOT NULL
);
GO

-- Creating table 'ContactSet'
CREATE TABLE [dbo].[ContactSet] (
    [ContactId] tinyint IDENTITY(1,1) NOT NULL,
    [Data] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Deleted] bit  NOT NULL,
    [Person_PersonId] bigint  NOT NULL
);
GO

-- Creating table 'PublicationMatterCareerFacultySet'
CREATE TABLE [dbo].[PublicationMatterCareerFacultySet] (
    [PublicationMatterCareerFacultyId] int IDENTITY(1,1) NOT NULL,
    [PublicationAcademic_PublicationAcademicId] bigint  NOT NULL,
    [Subject_SubjectId] smallint  NOT NULL,
    [Career_CareerId] int  NOT NULL,
    [Faculty_FacultyId] smallint  NOT NULL
);
GO

-- Creating table 'SubjectSet'
CREATE TABLE [dbo].[SubjectSet] (
    [SubjectId] smallint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Deleted] bit  NOT NULL
);
GO

-- Creating table 'SubjectCareerSet'
CREATE TABLE [dbo].[SubjectCareerSet] (
    [SubjectCareerId] int IDENTITY(1,1) NOT NULL,
    [Career_CareerId] int  NOT NULL,
    [Subject_SubjectId] smallint  NOT NULL
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

-- Creating primary key on [CommentAcademicId] in table 'CommentAcademicSet'
ALTER TABLE [dbo].[CommentAcademicSet]
ADD CONSTRAINT [PK_CommentAcademicSet]
    PRIMARY KEY CLUSTERED ([CommentAcademicId] ASC);
GO

-- Creating primary key on [PublicationAcademicId] in table 'PublicationAcademicSet'
ALTER TABLE [dbo].[PublicationAcademicSet]
ADD CONSTRAINT [PK_PublicationAcademicSet]
    PRIMARY KEY CLUSTERED ([PublicationAcademicId] ASC);
GO

-- Creating primary key on [CategoryAcademicId] in table 'CategoryAcademicSet'
ALTER TABLE [dbo].[CategoryAcademicSet]
ADD CONSTRAINT [PK_CategoryAcademicSet]
    PRIMARY KEY CLUSTERED ([CategoryAcademicId] ASC);
GO

-- Creating primary key on [PersonId] in table 'PersonSet'
ALTER TABLE [dbo].[PersonSet]
ADD CONSTRAINT [PK_PersonSet]
    PRIMARY KEY CLUSTERED ([PersonId] ASC);
GO

-- Creating primary key on [ContactId] in table 'ContactSet'
ALTER TABLE [dbo].[ContactSet]
ADD CONSTRAINT [PK_ContactSet]
    PRIMARY KEY CLUSTERED ([ContactId] ASC);
GO

-- Creating primary key on [PublicationMatterCareerFacultyId] in table 'PublicationMatterCareerFacultySet'
ALTER TABLE [dbo].[PublicationMatterCareerFacultySet]
ADD CONSTRAINT [PK_PublicationMatterCareerFacultySet]
    PRIMARY KEY CLUSTERED ([PublicationMatterCareerFacultyId] ASC);
GO

-- Creating primary key on [SubjectId] in table 'SubjectSet'
ALTER TABLE [dbo].[SubjectSet]
ADD CONSTRAINT [PK_SubjectSet]
    PRIMARY KEY CLUSTERED ([SubjectId] ASC);
GO

-- Creating primary key on [SubjectCareerId] in table 'SubjectCareerSet'
ALTER TABLE [dbo].[SubjectCareerSet]
ADD CONSTRAINT [PK_SubjectCareerSet]
    PRIMARY KEY CLUSTERED ([SubjectCareerId] ASC);
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
GO

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
GO

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
GO

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
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacultyCareer'
CREATE INDEX [IX_FK_FacultyCareer]
ON [dbo].[CareerSet]
    ([Faculty_FacultyId]);
GO

-- Creating foreign key on [Gender_GenderId] in table 'PersonSet'
ALTER TABLE [dbo].[PersonSet]
ADD CONSTRAINT [FK_GenderPerson]
    FOREIGN KEY ([Gender_GenderId])
    REFERENCES [dbo].[GenderSet]
        ([GenderId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GenderPerson'
CREATE INDEX [IX_FK_GenderPerson]
ON [dbo].[PersonSet]
    ([Gender_GenderId]);
GO

-- Creating foreign key on [Person_PersonId] in table 'ContactSet'
ALTER TABLE [dbo].[ContactSet]
ADD CONSTRAINT [FK_PersonConctact]
    FOREIGN KEY ([Person_PersonId])
    REFERENCES [dbo].[PersonSet]
        ([PersonId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonConctact'
CREATE INDEX [IX_FK_PersonConctact]
ON [dbo].[ContactSet]
    ([Person_PersonId]);
GO

-- Creating foreign key on [User_UserId] in table 'PersonSet'
ALTER TABLE [dbo].[PersonSet]
ADD CONSTRAINT [FK_PersonUser]
    FOREIGN KEY ([User_UserId])
    REFERENCES [dbo].[UserSet]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonUser'
CREATE INDEX [IX_FK_PersonUser]
ON [dbo].[PersonSet]
    ([User_UserId]);
GO

-- Creating foreign key on [User_UserId] in table 'CommentAcademicSet'
ALTER TABLE [dbo].[CommentAcademicSet]
ADD CONSTRAINT [FK_UserCommentAcademic]
    FOREIGN KEY ([User_UserId])
    REFERENCES [dbo].[UserSet]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserCommentAcademic'
CREATE INDEX [IX_FK_UserCommentAcademic]
ON [dbo].[CommentAcademicSet]
    ([User_UserId]);
GO

-- Creating foreign key on [PublicationAcademic_PublicationAcademicId] in table 'CommentAcademicSet'
ALTER TABLE [dbo].[CommentAcademicSet]
ADD CONSTRAINT [FK_PublicationAcademicCommentAcademic]
    FOREIGN KEY ([PublicationAcademic_PublicationAcademicId])
    REFERENCES [dbo].[PublicationAcademicSet]
        ([PublicationAcademicId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PublicationAcademicCommentAcademic'
CREATE INDEX [IX_FK_PublicationAcademicCommentAcademic]
ON [dbo].[CommentAcademicSet]
    ([PublicationAcademic_PublicationAcademicId]);
GO

-- Creating foreign key on [CategoryAcademic_CategoryAcademicId] in table 'PublicationAcademicSet'
ALTER TABLE [dbo].[PublicationAcademicSet]
ADD CONSTRAINT [FK_CategoryAcademicPublicationAcademic]
    FOREIGN KEY ([CategoryAcademic_CategoryAcademicId])
    REFERENCES [dbo].[CategoryAcademicSet]
        ([CategoryAcademicId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryAcademicPublicationAcademic'
CREATE INDEX [IX_FK_CategoryAcademicPublicationAcademic]
ON [dbo].[PublicationAcademicSet]
    ([CategoryAcademic_CategoryAcademicId]);
GO

-- Creating foreign key on [Career_CareerId] in table 'SubjectCareerSet'
ALTER TABLE [dbo].[SubjectCareerSet]
ADD CONSTRAINT [FK_CareerSubjectCareer]
    FOREIGN KEY ([Career_CareerId])
    REFERENCES [dbo].[CareerSet]
        ([CareerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CareerSubjectCareer'
CREATE INDEX [IX_FK_CareerSubjectCareer]
ON [dbo].[SubjectCareerSet]
    ([Career_CareerId]);
GO

-- Creating foreign key on [Subject_SubjectId] in table 'SubjectCareerSet'
ALTER TABLE [dbo].[SubjectCareerSet]
ADD CONSTRAINT [FK_SubjectSubjectCareer]
    FOREIGN KEY ([Subject_SubjectId])
    REFERENCES [dbo].[SubjectSet]
        ([SubjectId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SubjectSubjectCareer'
CREATE INDEX [IX_FK_SubjectSubjectCareer]
ON [dbo].[SubjectCareerSet]
    ([Subject_SubjectId]);
GO

-- Creating foreign key on [PublicationAcademic_PublicationAcademicId] in table 'PublicationMatterCareerFacultySet'
ALTER TABLE [dbo].[PublicationMatterCareerFacultySet]
ADD CONSTRAINT [FK_PublicationAcademicPublicationMatterCareerFaculty]
    FOREIGN KEY ([PublicationAcademic_PublicationAcademicId])
    REFERENCES [dbo].[PublicationAcademicSet]
        ([PublicationAcademicId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PublicationAcademicPublicationMatterCareerFaculty'
CREATE INDEX [IX_FK_PublicationAcademicPublicationMatterCareerFaculty]
ON [dbo].[PublicationMatterCareerFacultySet]
    ([PublicationAcademic_PublicationAcademicId]);
GO

-- Creating foreign key on [Subject_SubjectId] in table 'PublicationMatterCareerFacultySet'
ALTER TABLE [dbo].[PublicationMatterCareerFacultySet]
ADD CONSTRAINT [FK_SubjectPublicationMatterCareerFaculty]
    FOREIGN KEY ([Subject_SubjectId])
    REFERENCES [dbo].[SubjectSet]
        ([SubjectId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SubjectPublicationMatterCareerFaculty'
CREATE INDEX [IX_FK_SubjectPublicationMatterCareerFaculty]
ON [dbo].[PublicationMatterCareerFacultySet]
    ([Subject_SubjectId]);
GO

-- Creating foreign key on [Career_CareerId] in table 'PublicationMatterCareerFacultySet'
ALTER TABLE [dbo].[PublicationMatterCareerFacultySet]
ADD CONSTRAINT [FK_CareerPublicationMatterCareerFaculty]
    FOREIGN KEY ([Career_CareerId])
    REFERENCES [dbo].[CareerSet]
        ([CareerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CareerPublicationMatterCareerFaculty'
CREATE INDEX [IX_FK_CareerPublicationMatterCareerFaculty]
ON [dbo].[PublicationMatterCareerFacultySet]
    ([Career_CareerId]);
GO

-- Creating foreign key on [Faculty_FacultyId] in table 'PublicationMatterCareerFacultySet'
ALTER TABLE [dbo].[PublicationMatterCareerFacultySet]
ADD CONSTRAINT [FK_FacultyPublicationMatterCareerFaculty]
    FOREIGN KEY ([Faculty_FacultyId])
    REFERENCES [dbo].[FacultySet]
        ([FacultyId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacultyPublicationMatterCareerFaculty'
CREATE INDEX [IX_FK_FacultyPublicationMatterCareerFaculty]
ON [dbo].[PublicationMatterCareerFacultySet]
    ([Faculty_FacultyId]);
GO

-- Creating foreign key on [User_UserId] in table 'PublicationAcademicSet'
ALTER TABLE [dbo].[PublicationAcademicSet]
ADD CONSTRAINT [FK_UserPublicationAcademic]
    FOREIGN KEY ([User_UserId])
    REFERENCES [dbo].[UserSet]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserPublicationAcademic'
CREATE INDEX [IX_FK_UserPublicationAcademic]
ON [dbo].[PublicationAcademicSet]
    ([User_UserId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
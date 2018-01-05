
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/04/2018 21:08:15
-- Generated from EDMX file: H:\MSIT11730305\9-1.專題\專題\WindowsForms個人專題\WindowsForms個人專題\DrModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Dark Cuisine circles];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_食譜_user]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Recipe] DROP CONSTRAINT [FK_食譜_user];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO
IF OBJECT_ID(N'[dbo].[Recipe]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Recipe];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [UserID] int IDENTITY(1,1) NOT NULL,
    [Email] nvarchar(50)  NOT NULL,
    [PassWord] nvarchar(100)  NOT NULL,
    [Gender] nchar(10)  NULL,
    [FirstName] nvarchar(50)  NULL,
    [LastName] nvarchar(50)  NULL,
    [Photo] varbinary(max)  NULL,
    [LineID] nvarchar(50)  NULL
);
GO

-- Creating table 'Recipe'
CREATE TABLE [dbo].[Recipe] (
    [RecipeID] int IDENTITY(1,1) NOT NULL,
    [UserID] int  NOT NULL,
    [FoodName] nvarchar(20)  NOT NULL,
    [Description] nvarchar(200)  NOT NULL,
    [CookingTime_minute_] int  NULL,
    [Amount] int  NULL,
    [Photo] nvarchar(max)  NULL,
    [Tips] nvarchar(200)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UserID] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([UserID] ASC);
GO

-- Creating primary key on [RecipeID] in table 'Recipe'
ALTER TABLE [dbo].[Recipe]
ADD CONSTRAINT [PK_Recipe]
    PRIMARY KEY CLUSTERED ([RecipeID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserID] in table 'Recipe'
ALTER TABLE [dbo].[Recipe]
ADD CONSTRAINT [FK_食譜_user]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[User]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_食譜_user'
CREATE INDEX [IX_FK_食譜_user]
ON [dbo].[Recipe]
    ([UserID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
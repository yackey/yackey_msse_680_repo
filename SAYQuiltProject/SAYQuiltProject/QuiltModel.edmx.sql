
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 12/29/2013 08:36:14
-- Generated from EDMX file: F:\yackey\various\regis\GitHub\yackey_msse_680_repo\SAYQuiltProject\SAYQuiltProject\QuiltModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_OrderQuilt]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_OrderQuilt];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderRecipient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_OrderRecipient];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderOrderHistory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderHistories] DROP CONSTRAINT [FK_OrderOrderHistory];
GO
IF OBJECT_ID(N'[dbo].[FK_QuiltDesignBlock]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Quilts] DROP CONSTRAINT [FK_QuiltDesignBlock];
GO
IF OBJECT_ID(N'[dbo].[FK_QuiltBOM]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BOMs] DROP CONSTRAINT [FK_QuiltBOM];
GO
IF OBJECT_ID(N'[dbo].[FK_QuiltAward]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Awards] DROP CONSTRAINT [FK_QuiltAward];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Orders];
GO
IF OBJECT_ID(N'[dbo].[Quilts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Quilts];
GO
IF OBJECT_ID(N'[dbo].[Recipients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Recipients];
GO
IF OBJECT_ID(N'[dbo].[OrderHistories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderHistories];
GO
IF OBJECT_ID(N'[dbo].[DesignBlocks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DesignBlocks];
GO
IF OBJECT_ID(N'[dbo].[BOMs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BOMs];
GO
IF OBJECT_ID(N'[dbo].[Awards]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Awards];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [OrderId] int IDENTITY(1,1) NOT NULL,
    [StartDate] nvarchar(max)  NULL,
    [EndDate] nvarchar(max)  NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Quilt_QuiltId] int  NOT NULL,
    [Recipient_RecipientId] int  NOT NULL
);
GO

-- Creating table 'Quilts'
CREATE TABLE [dbo].[Quilts] (
    [QuiltId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [DesignBlock_DesignBlockId] int  NOT NULL
);
GO

-- Creating table 'Recipients'
CREATE TABLE [dbo].[Recipients] (
    [RecipientId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Address1] nvarchar(max)  NOT NULL,
    [Address2] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'OrderHistories'
CREATE TABLE [dbo].[OrderHistories] (
    [OrderHistoryId] int IDENTITY(1,1) NOT NULL,
    [Phase] nvarchar(max)  NOT NULL,
    [BeginDate] nvarchar(max)  NOT NULL,
    [EndDate] nvarchar(max)  NOT NULL,
    [Comments] nvarchar(max)  NOT NULL,
    [OrderOrderId] int  NOT NULL
);
GO

-- Creating table 'DesignBlocks'
CREATE TABLE [dbo].[DesignBlocks] (
    [DesignBlockId] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Genesis] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'BOMs'
CREATE TABLE [dbo].[BOMs] (
    [BomId] int IDENTITY(1,1) NOT NULL,
    [TypeOfItem] nvarchar(max)  NOT NULL,
    [Count] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [QuiltQuiltId] int  NOT NULL
);
GO

-- Creating table 'Awards'
CREATE TABLE [dbo].[Awards] (
    [AwardId] int IDENTITY(1,1) NOT NULL,
    [AwardingBody] nvarchar(max)  NOT NULL,
    [DateOfAward] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [QuiltQuiltId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [OrderId] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([OrderId] ASC);
GO

-- Creating primary key on [QuiltId] in table 'Quilts'
ALTER TABLE [dbo].[Quilts]
ADD CONSTRAINT [PK_Quilts]
    PRIMARY KEY CLUSTERED ([QuiltId] ASC);
GO

-- Creating primary key on [RecipientId] in table 'Recipients'
ALTER TABLE [dbo].[Recipients]
ADD CONSTRAINT [PK_Recipients]
    PRIMARY KEY CLUSTERED ([RecipientId] ASC);
GO

-- Creating primary key on [OrderHistoryId] in table 'OrderHistories'
ALTER TABLE [dbo].[OrderHistories]
ADD CONSTRAINT [PK_OrderHistories]
    PRIMARY KEY CLUSTERED ([OrderHistoryId] ASC);
GO

-- Creating primary key on [DesignBlockId] in table 'DesignBlocks'
ALTER TABLE [dbo].[DesignBlocks]
ADD CONSTRAINT [PK_DesignBlocks]
    PRIMARY KEY CLUSTERED ([DesignBlockId] ASC);
GO

-- Creating primary key on [BomId] in table 'BOMs'
ALTER TABLE [dbo].[BOMs]
ADD CONSTRAINT [PK_BOMs]
    PRIMARY KEY CLUSTERED ([BomId] ASC);
GO

-- Creating primary key on [AwardId] in table 'Awards'
ALTER TABLE [dbo].[Awards]
ADD CONSTRAINT [PK_Awards]
    PRIMARY KEY CLUSTERED ([AwardId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Quilt_QuiltId] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_OrderQuilt]
    FOREIGN KEY ([Quilt_QuiltId])
    REFERENCES [dbo].[Quilts]
        ([QuiltId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderQuilt'
CREATE INDEX [IX_FK_OrderQuilt]
ON [dbo].[Orders]
    ([Quilt_QuiltId]);
GO

-- Creating foreign key on [Recipient_RecipientId] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_OrderRecipient]
    FOREIGN KEY ([Recipient_RecipientId])
    REFERENCES [dbo].[Recipients]
        ([RecipientId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderRecipient'
CREATE INDEX [IX_FK_OrderRecipient]
ON [dbo].[Orders]
    ([Recipient_RecipientId]);
GO

-- Creating foreign key on [OrderOrderId] in table 'OrderHistories'
ALTER TABLE [dbo].[OrderHistories]
ADD CONSTRAINT [FK_OrderOrderHistory]
    FOREIGN KEY ([OrderOrderId])
    REFERENCES [dbo].[Orders]
        ([OrderId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderOrderHistory'
CREATE INDEX [IX_FK_OrderOrderHistory]
ON [dbo].[OrderHistories]
    ([OrderOrderId]);
GO

-- Creating foreign key on [DesignBlock_DesignBlockId] in table 'Quilts'
ALTER TABLE [dbo].[Quilts]
ADD CONSTRAINT [FK_QuiltDesignBlock]
    FOREIGN KEY ([DesignBlock_DesignBlockId])
    REFERENCES [dbo].[DesignBlocks]
        ([DesignBlockId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_QuiltDesignBlock'
CREATE INDEX [IX_FK_QuiltDesignBlock]
ON [dbo].[Quilts]
    ([DesignBlock_DesignBlockId]);
GO

-- Creating foreign key on [QuiltQuiltId] in table 'BOMs'
ALTER TABLE [dbo].[BOMs]
ADD CONSTRAINT [FK_QuiltBOM]
    FOREIGN KEY ([QuiltQuiltId])
    REFERENCES [dbo].[Quilts]
        ([QuiltId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_QuiltBOM'
CREATE INDEX [IX_FK_QuiltBOM]
ON [dbo].[BOMs]
    ([QuiltQuiltId]);
GO

-- Creating foreign key on [QuiltQuiltId] in table 'Awards'
ALTER TABLE [dbo].[Awards]
ADD CONSTRAINT [FK_QuiltAward]
    FOREIGN KEY ([QuiltQuiltId])
    REFERENCES [dbo].[Quilts]
        ([QuiltId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_QuiltAward'
CREATE INDEX [IX_FK_QuiltAward]
ON [dbo].[Awards]
    ([QuiltQuiltId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
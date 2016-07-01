﻿

CREATE TABLE [dbo].[ACTS] (
    [ID]       INT            IDENTITY (1, 1) NOT NULL,
    [NAME]     NVARCHAR (500) NOT NULL,
    [NUMBER]   TINYINT        NOT NULL,
    [YEAR]     SMALLINT       NOT NULL,
    [FILE]     NVARCHAR (150) NOT NULL,
    [CATEGORY] NVARCHAR (50)  NOT NULL,
    [DATETIME] DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    UNIQUE NONCLUSTERED ([NAME] ASC),
);

CREATE TABLE [dbo].[AMENDMENTS] (
    [ID]       INT            IDENTITY (1, 1) NOT NULL,
    [ACTID]    INT            NOT NULL,
    [NUMBER]   TINYINT        NOT NULL,
    [YEAR]     SMALLINT       NOT NULL,
    [FILE]     NVARCHAR (150) NOT NULL,
    [TYPE]     NVARCHAR (50)  NOT NULL,
    [DATETIME] DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_ACTS] FOREIGN KEY ([ACTID]) REFERENCES [dbo].[ACTS] ([ID])
);


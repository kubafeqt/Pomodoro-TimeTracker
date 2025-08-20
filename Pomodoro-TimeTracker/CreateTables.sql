CREATE TABLE [dbo].[Activity] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (100) NOT NULL,
    [Status]    NVARCHAR (50)  NULL,
    [CreatedAt] DATETIME       DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Tasks] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [ActivityId] INT            NOT NULL,
    [Task]       NVARCHAR (255) NULL,
    [SubTask]    NVARCHAR (255) NULL,
    [Status]     NVARCHAR (50)  NULL,
    [CreatedAt]  DATETIME       DEFAULT (getdate()) NOT NULL,
    [FinishedAt] DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Tasks_Activity] FOREIGN KEY ([ActivityId]) REFERENCES [dbo].[Activity] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE [dbo].[Settings] (
    [PomodoroLength] INT NOT NULL,
    [PauseLength]    INT NOT NULL
);
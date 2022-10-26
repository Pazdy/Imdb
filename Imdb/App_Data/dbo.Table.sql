CREATE TABLE [dbo].[UserTable] (
    [UserId]      INT           IDENTITY (1, 1) NOT NULL,
    [UserName]    NVARCHAR (50) NOT NULL,
    [Email]       NVARCHAR (50) NOT NULL,
    [Password]	  NVARCHAR (50) NOT NULL,
    [Role]        INT           NOT NULL,
    [Posts]       INT           NULL,
    [Assessments] INT           NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);


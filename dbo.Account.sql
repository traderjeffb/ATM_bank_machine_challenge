CREATE TABLE [dbo].[Account] (
    [AccountID] INT   NOT NULL IDENTITY,
    [Balance]   MONEY NULL,
    [Deposits]  MONEY NULL,
    [Withdraws] MONEY NULL,
    PRIMARY KEY CLUSTERED ([AccountID] ASC)
);


CREATE TABLE [dbo].[TransactionID] (
    [TransactionID]   INT       NOT NULL IDENTITY,
    [CustomerID]      INT       NOT NULL,
    [TransactionType] CHAR (10) NOT NULL,
    [DateTime]        DATETIME  NOT NULL,
    PRIMARY KEY CLUSTERED ([TransactionID] ASC),
    CONSTRAINT [FK_TransactionID_ToTable] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customer] ([CustomerID])
);


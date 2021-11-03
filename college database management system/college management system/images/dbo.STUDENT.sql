CREATE TABLE [dbo].[STUDENT] (
    [std_id]        VARCHAR(20)          NOT NULL,
    [name]          VARCHAR (15) NULL,
    [addr]          VARCHAR (30) NULL,
    [phnum]         VARCHAR(15)          NULL,
    [sex]           VARCHAR (8)  NULL,
    [date_of_birth] DATE         NULL,
    PRIMARY KEY CLUSTERED ([std_id] ASC)
);


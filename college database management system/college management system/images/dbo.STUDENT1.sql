CREATE TABLE [dbo].[STUDENT] (
    [std_id]        INT          NOT NULL,
    [std_name]      VARCHAR (15) NULL,
    [std_addr]      VARCHAR (30) NULL,
    [std_pnum]      INT          NULL,
    [sex]           VARCHAR (8)  NULL,
    [date_of_birth] DATE         NULL,
    PRIMARY KEY CLUSTERED ([std_id] ASC)
);


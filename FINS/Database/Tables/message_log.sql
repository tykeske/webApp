CREATE TABLE [dbo].[message_log] (
    [message_id]        INT             IDENTITY (1, 1) NOT NULL,
    [message_content]   NVARCHAR (1000) NOT NULL,
    [template_id]       INT             NULL,
    [created_date]      SMALLDATETIME   NOT NULL,
    [created_by]        INT             NOT NULL,
    [subscriber_count]  SMALLINT        NULL,
    [status]            VARCHAR (20)    NULL,
    [location_id]       INT             NOT NULL,
    [error_description] VARCHAR (255)   NULL,
    PRIMARY KEY CLUSTERED ([message_id] ASC),
    CONSTRAINT [FK_Message_TemplateID] FOREIGN KEY ([template_id]) REFERENCES [dbo].[message_template] ([template_id]),
    CONSTRAINT [FK_Message_LocationID] FOREIGN KEY ([location_id]) REFERENCES [dbo].[pantry_location] ([location_id])
);


GO
CREATE NONCLUSTERED INDEX [IDX_Message_CreatedDate]
    ON [dbo].[message_log]([created_date] ASC);


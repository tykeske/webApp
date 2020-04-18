CREATE TABLE [dbo].[message_tag] (
    [message_id]  INT            NOT NULL,
    [tag_id]      INT            NOT NULL,
    [tag_content] NVARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([message_id] ASC, [tag_id] ASC),
    CONSTRAINT [FK_MessageTag_MessageID] FOREIGN KEY ([message_id]) REFERENCES [dbo].[message_log] ([message_id]),
    CONSTRAINT [FK_MessageTag_TagID] FOREIGN KEY ([tag_id]) REFERENCES [dbo].[template_tag] ([tag_id])
);


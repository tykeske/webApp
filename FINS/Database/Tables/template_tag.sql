CREATE TABLE [dbo].[template_tag] (
    [tag_id]      INT          IDENTITY (1, 1) NOT NULL,
    [template_id] INT          NOT NULL,
    [tag_name]    VARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([tag_id] ASC),
    CONSTRAINT [FK_Tag_TemplateID] FOREIGN KEY ([template_id]) REFERENCES [dbo].[message_template] ([template_id])
);


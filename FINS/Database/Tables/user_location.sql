CREATE TABLE [dbo].[user_location] (
    [user_id]     INT NOT NULL,
    [location_id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([user_id] ASC, [location_id] ASC),
    CONSTRAINT [FK_UserLocation_UserID] FOREIGN KEY ([user_id]) REFERENCES [dbo].[user_account] ([user_id]),
    CONSTRAINT [FK_UserLocation_LocationID] FOREIGN KEY ([location_id]) REFERENCES [dbo].[pantry_location] ([location_id])
);


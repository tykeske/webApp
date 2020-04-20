-- Retrieve data for Review Notification Log
CREATE VIEW [notification_log] AS
SELECT
	ml.[created_date] AS message_date,
	ml.[message_content],
	ua.[full_name] AS message_by,
	COALESCE(mt.[template_name], 'N/A') AS template_used,
	ml.[subscriber_count]
FROM 
	[dbo].[message_log] ml
		INNER JOIN [dbo].[user_account] ua 
			ON ua.[user_id] = ml.[created_by]
		LEFT OUTER JOIN [dbo].[message_template] mt 
			ON ml.[template_id] = mt.[template_id]
;
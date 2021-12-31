SELECT * FROM Users
SELECT * FROM UserLogs
SELECT * FROM UserLogTypes
SELECT * FROM UserNotices
SELECT * FROM UserRecovers

INSERT INTO Users VALUES
('AuthAPI', '', '', null, 0, GETDATE(), 1),
('DEV', '1234', 'phm1080@Outlook.com', null, 0, GETDATE(), 1)

INSERT INTO UserNotices VALUES
(2, 1, GETDATE(), 1) 

INSERT INTO UserLogTypes VALUES
('Generated Auth Token', 1),('Password Changed', 1),('Blocked', 1),('Unblocked', 1)
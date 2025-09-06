USE Diary;

SELECT * FROM USERS;
SELECT * FROM DiaryEntries;

SELECT TOP 100 *
FROM Users;

SELECT TOP 100 *
FROM DiaryEntries;

--INSERT INTO Users (Name, Email, Password, Username, CreatedAt)
--VALUES
--('Alice Johnson', 'alice.johnson@example.com', 'Password123!', 'alicej', GETDATE()),
--('Bob Smith', 'bob.smith@example.com', 'SecurePass456!', 'bobsmith', GETDATE()),
--('Charlie Brown', 'charlie.brown@example.com', 'MyPass789!', 'charlieb', GETDATE()),
--('Diana Prince', 'diana.prince@example.com', 'WonderPass!', 'dianap', GETDATE()),
--('Ethan Hunt', 'ethan.hunt@example.com', 'MissionPass!', 'ethanh', GETDATE()),
--('Fiona Gallagher', 'fiona.g@example.com', 'Shameless123!', 'fionag', GETDATE()),
--('George Martin', 'george.martin@example.com', 'SongPass!', 'georgem', GETDATE()),
--('Hannah Baker', 'hannah.baker@example.com', 'TapePass!', 'hannahb', GETDATE()),
--('Ian Somerhalder', 'ian.somerhalder@example.com', 'Vampire123!', 'ians', GETDATE()),
--('Julia Roberts', 'julia.roberts@example.com', 'PrettyWoman!', 'juliar', GETDATE());

--INSERT INTO DiaryEntries (Title, Description, CreatedAt, UpdatedAt)
--VALUES
--('Morning Thoughts', 'Woke up feeling refreshed and ready for the day.', GETDATE(), GETDATE()),
--('Work Meeting', 'Had a productive meeting with the development team.', GETDATE(), GETDATE()),
--('Lunch Break', 'Tried a new restaurant and enjoyed the meal.', GETDATE(), GETDATE()),
--('Afternoon Walk', 'Went for a walk in the park and felt relaxed.', GETDATE(), GETDATE()),
--('Evening Study', 'Spent time learning about C# and .NET programming.', GETDATE(), GETDATE()),
--('Family Time', 'Had dinner with family and shared stories.', GETDATE(), GETDATE()),
--('Exercise', 'Did a 30-minute workout session.', GETDATE(), GETDATE()),
--('Reading', 'Finished reading a chapter of a motivational book.', GETDATE(), GETDATE()),
--('Reflection', 'Reflected on personal goals and achievements.', GETDATE(), GETDATE()),
--('Planning', 'Planned tasks for tomorrow and organized priorities.', GETDATE(), GETDATE());


--SELECT TOP 100 u.Id, u.Name, d.CreatedAt
--FROM Users u
--JOIN DiaryEntries d ON u.Id = d.Id
--ORDER BY d.CreatedAt DESC; 
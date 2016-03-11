CREATE DATABASE TestAPI
GO
USE TestAPI
GO
CREATE TABLE Comment
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Author VARCHAR(100),
	Text VARCHAR(1000)
)

INSERT INTO Comment(Author, Text) VALUES ('hoang tung','Demo comment')

INSERT INTO Comment(Author, Text) VALUES ('hoang bach','Demo comment2')
INSERT INTO Comment(Author, Text) VALUES ('hoang tung','Other comment')

SELECT * FROM 

CREATE TABLE Post
(
	ID	INT IDENTITY(1,1) PRIMARY KEY,
	Title VARCHAR (200),
	Content VARCHAR(1000)
)
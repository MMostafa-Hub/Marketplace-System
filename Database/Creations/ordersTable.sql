CREATE TABLE orders (
    number int PRIMARY KEY IDENTITY(1,1),
    dateCreated DATETIME,
    user_username VARCHAR(10) REFERENCES users(username)
);

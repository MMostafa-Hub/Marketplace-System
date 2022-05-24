CREATE TABLE Product (
	id int PRIMARY KEY IDENTITY(1,1),
	name VARCHAR(25),
	category VARCHAR(25),
	price float,
	stockQuantity int,
	soldQuantity int
);

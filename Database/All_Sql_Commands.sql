CREATE TABLE admins (
      username VARCHAR(10) PRIMARY KEY,
      password VARCHAR(10),
);

INSERT INTO admins (username, password)
VALUES ('admin1', 'admin123');

INSERT INTO admins (username, password)
VALUES ('admin2', 'admin456');


CREATE TABLE users (
      username VARCHAR(25) PRIMARY KEY,
      password VARCHAR(25),
	age INTEGER,
	gender VARCHAR(10),
	  balance float,
	  loggedIn BOOLEAN
);

INSERT INTO users (username, password, age , gender , balance , loggedIn)
VALUES ('David00', 'david123', 20 , 'Male' , 2000 , false);

INSERT INTO users (username, password, age , gender , balance , loggedIn)
VALUES ('John00', 'john456', 21 , 'Male' , 5000 , false);

INSERT INTO users (username, password, age , gender , balance , loggedIn)
VALUES ('mark55', 'mark123', 23 , 'Male' , 20000 , false);

INSERT INTO users (username, password, age , gender , balance , loggedIn)
VALUES ('Mario00', 'mario12', 23 , 'Male' , 20000 , false);

INSERT INTO users (username, password, age , gender , balance , loggedIn)
VALUES ('Marina1', 'marina002', 23 , 'Male' , 20000 , false);

INSERT INTO users (username, password, age , gender , balance , loggedIn)
VALUES ('Mohamed77', 'password123', 23 , 'Male' , 20000 , false);

INSERT INTO users (username, password, age , gender , balance , loggedIn)
VALUES ('Hazem00', 'Hazem123', 23 , 'Male' , 20000 , false);

INSERT INTO users (username, password, age , gender , balance , loggedIn)
VALUES ('Mekky00', 'pass12345', 23 , 'Male' , 20000 , false);

INSERT INTO users (username, password, age , gender , balance , loggedIn)
VALUES ('Mahmoud', 'hoda123', 23 , 'Male' , 20000 , false);

INSERT INTO users (username, password, age , gender , balance , loggedIn)
VALUES ('fady00', 'fady123', 23 , 'Male' , 20000 , false);



CREATE TABLE Product (
	id int PRIMARY KEY IDENTITY(1,1),
	name VARCHAR(25),
	description VARCHAR(100),
	category VARCHAR(25),
	price float,
	stockQuantity int,
	soldQuantity int
);

INSERT INTO Product(name, description , category, price , stockQuantity , soldQuantity)
VALUES ('iPhone 13', 'this is a very good one',  'Mobiles', 13000, 10 , 0);

INSERT INTO Product(name, category, price , stockQuantity , soldQuantity)
VALUES ('Samsung S12', 'this is a very good one', 'Mobiles', 11000, 7 , 0);

INSERT INTO Product(name, category, price , stockQuantity , soldQuantity)
VALUES ('Mx Master 3','this is a very good one','Mouses', 4000, 30 , 0);

INSERT INTO Product(name, category, price , stockQuantity , soldQuantity)
VALUES ('LG C2','this is a very good one', 'TV', 25000, 5 , 0);

INSERT INTO Product(name, category, price , stockQuantity , soldQuantity)
VALUES ('MacBook Pro','this is a very good one', 'Laptops', 40000, 8 , 0);

INSERT INTO Product(name, category, price , stockQuantity , soldQuantity)
VALUES ('air pods Pro','this is a very good one', 'EarPods', 5000, 8 , 0);

INSERT INTO Product(name, category, price , stockQuantity , soldQuantity)
VALUES ('apple watch','this is a very good one', 'Watches', 8000, 8 , 0);


CREATE TABLE orders (
    number int PRIMARY KEY IDENTITY(1,1),
    dateCreated DATETIME,
    user_username VARCHAR(10) REFERENCES users(username)
);


INSERT INTO orders(user_username , dateCreated)
VALUES ('David00', '2022-05-24 16:02:00');

INSERT INTO orders(user_username , dateCreated)
VALUES ('Mohanad00', '2022-05-24 16:02:00');

INSERT INTO orders(user_username , dateCreated)
VALUES ('Mario00', '2022-05-24 16:02:00');

INSERT INTO orders(user_username , dateCreated)
VALUES ('Marina00', '2022-05-24 16:02:00');


CREATE TABLE contain (
	order_no int REFERENCES orders(number),
	product_id int REFERENCES Product(id),
	quantity int
	PRIMARY KEY (order_no, product_id),
);

INSERT INTO contain(order_no ,product_id , quantity)
VALUES (1 , 1 , 1);

INSERT INTO contain(order_no ,product_id , quantity)
VALUES (1 , 3 , 1);

INSERT INTO contain(order_no ,product_id , quantity)
VALUES (1 , 4 , 1);

INSERT INTO contain(order_no ,product_id , quantity)
VALUES (2 , 2 , 1);

INSERT INTO contain(order_no ,product_id , quantity)
VALUES (2 , 3 , 1);

INSERT INTO contain(order_no ,product_id , quantity)
VALUES (2 , 4 , 1);

INSERT INTO contain(order_no ,product_id , quantity)
VALUES (3 , 2 , 1);

INSERT INTO contain(order_no ,product_id , quantity)
VALUES (3 , 3 , 1);

INSERT INTO contain(order_no ,product_id , quantity)
VALUES (3 , 4 , 1);


CREATE TABLE has_in_cart (
	user_username VARCHAR(10) REFERENCES users(username),
	product_id int REFERENCES Product(id),
	quantity int
	PRIMARY KEY (user_username, product_id),
);


INSERT INTO has_in_cart(user_username ,product_id , quantity)
VALUES ('David00' , 1 , 1);

INSERT INTO has_in_cart(user_username ,product_id , quantity)
VALUES ('David00' , 3 , 1);

INSERT INTO has_in_cart(user_username ,product_id , quantity)
VALUES ('David00' , 4 , 1);

INSERT INTO has_in_cart(user_username ,product_id , quantity)
VALUES ('Mohanad00' , 2 , 1);

INSERT INTO has_in_cart(user_username ,product_id , quantity)
VALUES ('Mohanad00' , 3 , 1);

INSERT INTO has_in_cart(user_username ,product_id , quantity)
VALUES ('Mohanad00' , 4 , 1);

INSERT INTO has_in_cart(user_username ,product_id , quantity)
VALUES ('Mario00' , 2 , 1);

INSERT INTO has_in_cart(user_username ,product_id , quantity)
VALUES ('Mario00' , 3 , 1);

INSERT INTO has_in_cart(user_username ,product_id , quantity)
VALUES ('Mario00' , 4 , 1);

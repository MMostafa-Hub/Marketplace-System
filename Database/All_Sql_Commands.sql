CREATE TABLE admins (
      username VARCHAR(10) PRIMARY KEY,
      password VARCHAR(10),
);

INSERT INTO admins (username, password)
VALUES ('admin1', 'admin123');

INSERT INTO admins (username, password)
VALUES ('admin2', 'admin456');


CREATE TABLE users (
      username VARCHAR(10) PRIMARY KEY,
      password VARCHAR(10),
	  balance float
);

INSERT INTO users (username, password, balance)
VALUES ('David00', 'david123', 5000);

INSERT INTO users (username, password, balance)
VALUES ('Mohanad00', 'mohanad123', 5000);

INSERT INTO users (username, password, balance)
VALUES ('Marina00', 'marina123', 5000);

INSERT INTO users (username, password, balance)
VALUES ('Mario00', 'mario123', 5000);

INSERT INTO users (username, password, balance)
VALUES ('Mekky00', 'Mekky123', 5000);

INSERT INTO users (username, password, balance)
VALUES ('Maria00', 'maria123', 5000);

INSERT INTO users (username, password, balance)
VALUES ('Mostafa00', 'mostafa123', 5000);

INSERT INTO users (username, password, balance)
VALUES ('Nazeeh00', 'nazeeh123', 5000);

INSERT INTO users (username, password, balance)
VALUES ('Mahmoud00', 'mahmoud123', 5000);

INSERT INTO users (username, password, balance)
VALUES ('Hazem00', 'hazem123', 5000);



CREATE TABLE Product (
	id int PRIMARY KEY IDENTITY(1,1),
	name VARCHAR(25),
	category VARCHAR(25),
	price float,
	stockQuantity int,
	soldQuantity int
);

INSERT INTO Product(name, category, price , stockQuantity , soldQuantity)
VALUES ('iPhone 13', 'Mobiles', 13000, 10 , 0);

INSERT INTO Product(name, category, price , stockQuantity , soldQuantity)
VALUES ('Samsung S12', 'Mobiles', 11000, 7 , 0);

INSERT INTO Product(name, category, price , stockQuantity , soldQuantity)
VALUES ('Mx Master 3', 'Mouses', 4000, 30 , 0);

INSERT INTO Product(name, category, price , stockQuantity , soldQuantity)
VALUES ('LG C2', 'TV', 25000, 5 , 0);

INSERT INTO Product(name, category, price , stockQuantity , soldQuantity)
VALUES ('MacBook Pro', 'Laptops', 40000, 8 , 0);


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
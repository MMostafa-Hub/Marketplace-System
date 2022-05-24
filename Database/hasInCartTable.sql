CREATE TABLE has_in_cart (
	user_username VARCHAR(10) REFERENCES users(username),
	product_id int REFERENCES Product(id),
	quantity int
	PRIMARY KEY (user_username, product_id),
);

CREATE TABLE contain (
	order_no int REFERENCES orders(number),
	product_id int REFERENCES Product(id),
	quantity int
	PRIMARY KEY (order_no, product_id),
);

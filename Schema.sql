DROP TABLE IF EXISTS booking;
DROP TABLE IF EXISTS promo;
DROP TABLE IF EXISTS hotel_location;
DROP TABLE IF EXISTS room_type;
DROP TABLE IF EXISTS room;
DROP TABLE IF EXISTS users;

CREATE TABLE users (
	user_id INT PRIMARY KEY,
	email VARCHAR(255) UNIQUE NOT NULL,
	password_hash VARCHAR(255),
	first_name VARCHAR(255) NOT NULL,
	last_name VARCHAR(255) NOT NULL,
	birth_date VARCHAR(255) NOT NULL,
	created_at TIMESTAMP NOT NULL DEFAULT NOW()
)

CREATE TABLE room (
	room_id INT PRIMARY KEY,
	roomtype_id INT,
	booking_id INT
)

CREATE TABLE room_type (
	roomtype_id INT PRIMARY KEY,
	num_beds INT,
	max_occupancy INT,
	smoker bit,
	room_view bit,
	basic_price decimal,
	FOREIGN KEY (roomtype_id) REFERENCES room(roomtype_id)
)

CREATE TABLE hotel_location (
	location_id INT PRIMARY KEY,
	city_name VARCHAR(255) NOT NULL,
	country_code VARCHAR(255) NOT NULL,
	location_address VARCHAR(255) NOT NULL,
	FOREIGN KEY (location_id) REFERENCES room(location_id)
)

CREATE TABLE promo_code (
	promo_id INT PRIMARY KEY,
	promo_code VARCHAR(255) NOT NULL
)

CREATE TABLE booking (
	booking_id INT PRIMARY KEY,
	user_id int NOT NULL,
	room_id int NOT NULL,
	num_adults INT,
	num_children INT,
	checkin DateTime,
	checkout DateTime,
	FOREIGN KEY (user_id) REFERENCES users(user_id),
	FOREIGN KEY (room_id) REFERENCES room(room_id)
)
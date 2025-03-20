create schema application;
create schema info;

create table application.product
(
	id serial primary key,
	full_name varchar(30) not null,
	short_name varchar(10) not null,
	code integer not null, 
	price decimal not null,
	brand varchar(15) not null,
	details varchar(30) null,
	product_type_id integer not null references info.info_product_type(id),
	product_status_id integer not null references info.info_product_status(id),

	created_date timestamp without time zone,
	updated_date date,
);

create table info.info_product_type
(
	id serial primary key,
	full_name varchar(30) not null,
	short_name varchar(10) not null,
	code integer not null,


	created_date timestamp without time zone,
	updated_date date,
);

create table info.info_product_status
(
	id serial primary key,
	full_name varchar(30) not null,
	short_name varchar(10) not null,
	code integer not null, 

	created_date timestamp without time zone,
	updated_date date,
);



create table application.payments
(
	id serial primary key,
	amount decimal(10, 2) not null,
	currency_id integer not null references info.info_currency(id),
	payment_method_id integer not null references info.info_payment_method(id),
	payment_status integer not null references info.info_paymet_status(id),
	product_id integer not null references application.product(id),

	created_date timestamp without time zone,
	updated_date date,
);

create table info.info_currency
(
	id serial primary key,
	full_name varchar(30) not null,
	short_name varchar(10) not null,
	code integer not null,

	created_date timestamp without time zone,
	updated_date date
);

create table info.info_payment_method
(
	id serial primary key,
	full_name varchar(30) not null,
	short_name varchar(10) not null,
	code integer not null,

	created_date timestamp without time zone,
	updated_date date
);

create table info.info_paymet_status
(
	id serial primary key,
	full_name varchar(30) not null,
	short_name varchar(10) not null,
	code integer not null, 

	created_date timestamp without time zone,
	updated_date date,
);


create table application.user
(
	id uuid not null,
	first_name varchar(30) not null,
	last_name varchar(30) null,
	phone_number varchar(15) not null,
	password_hash varchar(255) not null,
	gender_id integer not null references info.info_gender(id),
	role_id integer not null references info.info_role(id),
	user_status_id integer not null references info.info_user_status(id),

	created_date timestamp without time zone,
	updated_date date,
);

create table info.info_gender
(
	id serial primary key,
	full_name varchar(30) not null,
	short_name varchar(10) not null,
	code integer not null, 

	created_date timestamp without time zone,
	updated_date date,
);

create table info.info_role
(
	id serial primary key,
	full_name varchar(30) not null,
	short_name varchar(10) not null,
	code integer not null, 

	created_date timestamp without time zone,
	updated_date date,
);

create table info.info_user_status
(
	id serial primary key,
	full_name varchar(30) not null,
	short_name varchar(10) not null,
	code integer not null, 

	created_date timestamp without time zone,
	updated_date date,
);

create table application.order
(
	id serial primary key,
	total_amount decimal not null,
	user_id uuid not null references application.user(id),

	created_date timestamp without time zone,
	updated_date date
);


create table application.order_itmes
(
	id serial primary key,
	order_id integer not null references application.order(id),
	product_id integer not null references application.product(id),
	quantity integer not null,
);



create database Pub;

use Pub;

create table Brand(
	BrandId int identity(1,1) primary key,
	NameBrand varchar(100) not null
);


create table Beer(
	BeerId int identity(1,1) primary key,
	NameBeer varchar(60) not null,
	BrandId int not null,

	constraint FK_Beer_Brand
		foreign key (BrandId)
		references Brand(BrandId)
);

insert into Brand(NameBrand)values
('Brahma'),
('Skol'),
('Amstel'),
('Guinness')

select * from Brand;
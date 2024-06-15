use master;
go
drop database if exists frizerski_salon;
go
create database frizerski_salon collate Croatian_CI_AS;
go
use frizerski_salon;


create table termin(
sifra int not null primary key identity(1,1),
id_frizura int,
id_djelatnik int,
id_korisnik int,
datum datetime
);

create table frizura(
id_frizura int not null primary key identity(1,1),
naziv varchar(50) not null,
cijena decimal(18,2) not null,
trajanje varchar(20) not null
);

create table djelatnik(
id_djelatnik int not null primary key identity(1,1),
ime varchar(40) not null,
prezime varchar(50) not null,
oib char(11)
);

create table korisnik(
id_korisnik int not null primary key identity(1,1),
ime varchar(40) not null,
prezime varchar(50) not null,
telefon varchar(20) not null
);


alter table termin add foreign key(id_frizura) references frizura(id_frizura);

alter table termin add foreign key(id_djelatnik) references djelatnik (id_djelatnik);

alter table termin add foreign key (id_korisnik) references korisnik (id_korisnik);

insert into korisnik(ime,prezime,telefon)  values 
('Martina','Mirković','0995814578'), 
('Alen','Ljubojević','0998758547'),
('Andrea','Srećković','099857845');

insert into djelatnik(ime,prezime,oib)  values 
('Luka','Lukić','03745263781'), 
('Marinka','Markić','65738291564'),
('Ljerka','Ljerkić','26753482564');

insert into frizura(naziv,cijena,trajanje)  values 
('Bob frizura',50,'30 minuta'), 
('Pixie frizura',40,'40 minuta'),
('Visoki fade s bočnim razdjeljkom ',20,'15 minuta');

insert into termin (datum) values
('2024-07-08'),('2024-08-07'),('2024-08-09');



select * from djelatnik;
select * from korisnik;
select * from frizura;
select * from termin;






use master;
go
drop database if exists zavrsni_rad;
go
create database zavrsni_rad;
go
use zavrsni_rad;


create table termin(
sifra int not null primary key identity(1,1),
id_frizura int,
id_djelatnik int,
id_korisnik int,
datum datetime
);

create table frizura(
id_frizura int not null primary key identity(1,1),
naziv varchar(50),
cijena decimal(18,2),
trajanje varchar(20)
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
telefon int not null
);


alter table termin add foreign key(id_frizura) references frizura(id_frizura);

alter table termin add foreign key(id_djelatnik) references djelatnik (id_djelatnik);

alter table termin add foreign key (id_korisnik) references korisnik (id_korisnik);








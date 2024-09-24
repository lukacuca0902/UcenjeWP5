use master;
go
drop database if exists frizerski_salon;
go
create database frizerski_salon collate Croatian_CI_AS;
go
use frizerski_salon;


create table termini(
sifra int not null primary key identity(1,1),
id_frizura int not null,
id_djelatnik int not null,
id_korisnik int not null,
datum datetime
);

create table frizure(
id_frizura int not null primary key identity(1,1),
naziv varchar(50) not null,
cijena decimal(18,2) not null,
trajanje int not null
);

create table djelatnici(
id_djelatnik int not null primary key identity(1,1),
ime varchar(40) not null,
prezime varchar(50) not null,
oib char(11)
);

create table korisnici(
id_korisnik int not null primary key identity(1,1),
ime varchar(40) not null,
prezime varchar(50) not null,
telefon varchar(20) not null
);


alter table termini add foreign key(id_frizura) references frizure(id_frizura);

alter table termini add foreign key(id_djelatnik) references djelatnici (id_djelatnik);

alter table termini add foreign key (id_korisnik) references korisnici (id_korisnik);

insert into korisnici(ime,prezime,telefon)  values 
('Martina','Mirković','0995814578'), 
('Alen','Ljubojević','0998758547'),
('Andrea','Srećković','099857845');

insert into djelatnici(ime,prezime,oib)  values 
('Luka','Lukić','03745263781'), 
('Marinka','Markić','65738291564'),
('Ljerka','Ljerkić','26753482564');

insert into frizure(naziv,cijena,trajanje)  values 
('Bob frizura',50,120), 
('Pixie frizura',40,100),
('Visoki fade s bočnim razdjeljkom ',20,15);

insert into termini(id_frizura,id_djelatnik,id_korisnik,datum) values
--Bob frizuru(1) će raditi Marinka(2) na Martini(1)
(1,2,1,'2024-06-27 16:30'),
--Pixie frizuru(2) će raditi Ljerka(3) na Andrei(3)
(2,3,3,'2024-07-12 12:15'),
--Visoki fade s bočnim razdjeljkom(3) će raditi Luka(1) na Alenu(2)
(3,1,2,'2024-06-24 08:00');



select * from djelatnici;
select * from korisnici;
select * from frizure;
select * from termini;






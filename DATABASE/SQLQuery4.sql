use esempiolezione

create table Dipartimento(
	Nome char(20) primary key,
	Indirizzo char(50),
	Citta char(50)
)

create table Impiegato(
	Matricola char(6) primary key,
	Cognome varchar(50) not null, 
	Nome varchar(50) not null,
	Dipartimento char(20) references Dipartimento(Nome),
	Stipendio integer default 0,
	unique(Cognome, Nome)
)

alter table Impiegato drop column anno_nascita
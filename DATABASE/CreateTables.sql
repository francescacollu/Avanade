/*Esercitazione 1-Francesca Collu*/

use Persone

/*Creazione della tabella PERSONE*/
create table PERSONE(
	Nome char(20) primary key,
	Reddito int not null,
	Eta int not null,
	Sesso char(1) check (Sesso='M' OR Sesso='F'),
	)

/*Inserimento di dati nella tabella PERSONE*/
INSERT INTO PERSONE (Nome,Reddito,Eta,Sesso) VALUES ('Aldo',25,15,'M');
INSERT INTO PERSONE (Nome,Reddito,Eta,Sesso) VALUES ('Andrea',27,21,'M');
INSERT INTO PERSONE (Nome,Reddito,Eta,Sesso) VALUES ('AntonGiulio',44,40,'M');
INSERT INTO PERSONE (Nome,Reddito,Eta,Sesso) VALUES ('Ezechiele',11,10,'M');
INSERT INTO PERSONE (Nome,Reddito,Eta,Sesso) VALUES ('Filippo',26,30,'M');
INSERT INTO PERSONE (Nome,Reddito,Eta,Sesso) VALUES ('Franco',60,20,'M');
INSERT INTO PERSONE (Nome,Reddito,Eta,Sesso) VALUES ('Leonardo',79,30,'M');
INSERT INTO PERSONE (Nome,Reddito,Eta,Sesso) VALUES ('Luigi',50,40,'M');
INSERT INTO PERSONE (Nome,Reddito,Eta,Sesso) VALUES ('Michelangelo',79,30,'M');
INSERT INTO PERSONE (Nome,Reddito,Eta,Sesso) VALUES ('Sergio',85,35,'M');
INSERT INTO PERSONE (Nome,Reddito,Eta,Sesso) VALUES ('Amelia',79,28,'F');
INSERT INTO PERSONE (Nome,Reddito,Eta,Sesso) VALUES ('Anna',50,29,'F');
INSERT INTO PERSONE (Nome,Reddito,Eta,Sesso) VALUES ('AnnaMaria',41,30,'F');
INSERT INTO PERSONE (Nome,Reddito,Eta,Sesso) VALUES ('Beatrice',79,30,'F');
INSERT INTO PERSONE (Nome,Reddito,Eta,Sesso) VALUES ('Luisa',75,87,'F');
INSERT INTO PERSONE (Nome,Reddito,Eta,Sesso) VALUES ('Maria',55,42,'F');
INSERT INTO PERSONE (Nome,Reddito,Eta,Sesso) VALUES ('Olga',30,41,'F');
INSERT INTO PERSONE (Nome,Reddito,Eta,Sesso) VALUES ('Gianni',23,15,null);
INSERT INTO PERSONE (Nome,Reddito,Eta,Sesso) VALUES ('Manuela',45,62,null);


/*Righe inserite a piacere*/
INSERT INTO PERSONE (Nome, Reddito, Eta, Sesso) VALUES ('Federico', 30, 26, 'M');
INSERT INTO PERSONE (Nome, Reddito, Eta, Sesso) VALUES ('MariaAntonietta', 30, 32, 'F');



/*Creazione della tabella GENITORI*/
create table GENITORI(
	Figlio char(20) references PERSONE(Nome),
	Genitore char(20) references PERSONE(Nome),
	)

/*Inserimento di dati nella tabella GENITORI*/
INSERT INTO GENITORI (Figlio,Genitore) VALUES ('Aldo','Franco');
INSERT INTO GENITORI (Figlio,Genitore) VALUES ('Aldo','Maria');
INSERT INTO GENITORI (Figlio,Genitore) VALUES ('Andrea','Franco');
INSERT INTO GENITORI (Figlio,Genitore) VALUES ('Andrea','Maria');
INSERT INTO GENITORI (Figlio,Genitore) VALUES ('AntonGiulio','Beatrice');
INSERT INTO GENITORI (Figlio,Genitore) VALUES ('AntonGiulio','Leonardo');
INSERT INTO GENITORI (Figlio,Genitore) VALUES ('Ezechiele','AnnaMaria');
INSERT INTO GENITORI (Figlio,Genitore) VALUES ('Ezechiele','AntonGiulio');
INSERT INTO GENITORI (Figlio,Genitore) VALUES ('Filippo','Anna');
INSERT INTO GENITORI (Figlio,Genitore) VALUES ('Filippo','Luigi');
INSERT INTO GENITORI (Figlio,Genitore) VALUES ('Franco','Sergio');
INSERT INTO GENITORI (Figlio,Genitore) VALUES ('Luigi','Luisa');
INSERT INTO GENITORI (Figlio,Genitore) VALUES ('AnnaMaria','Amelia');
INSERT INTO GENITORI (Figlio,Genitore) VALUES ('AnnaMaria','Michelangelo');
INSERT INTO GENITORI (Figlio,Genitore) VALUES ('Maria','Luisa');
INSERT INTO GENITORI (Figlio,Genitore) VALUES ('Olga','Anna');
INSERT INTO GENITORI (Figlio,Genitore) VALUES ('Olga','Luigi');


/*Righe inserite a piacere*/
INSERT INTO GENITORI (Figlio, Genitore) VALUES ('Federico', 'Maria');
INSERT INTO GENITORI (Figlio, Genitore) VALUES ('MariaAntonietta', 'Luigi');
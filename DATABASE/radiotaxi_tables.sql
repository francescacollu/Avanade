use Radiotaxi

create table TELEFONISTA(
	Codice_telefonista integer primary key,
	Nome char(20),
	Cognome char(20),
	Data_di_nascita date,
	)

create table CHIAMATA(
	Numero_chiamata integer primary key,
	Destinazione char(50),
	Partenza char(50),
	Data_chiam date,
	Ora_chiam time,
	Prenotata char(1) check (Prenotata= 'Y' OR Prenotata= 'N'),
	Urgente char(1) check (Urgente= 'Y' OR Urgente= 'N'),
	Codice_taxi integer,
	FOREIGN KEY(Codice_taxi) references TAXI(Codice_taxi),
	Codice_telefonista integer,
	FOREIGN KEY(Codice_telefonista) references TELEFONISTA(Codice_telefonista),
	)


create table SERVIZIO(
	Codice_taxi integer,
	FOREIGN KEY(Codice_taxi) references TAXI(Codice_taxi),
	Numero_chiamata integer,
	FOREIGN KEY(Numero_chiamata) references CHIAMATA(Numero_chiamata),
	Ora_inizio time,
	Ora_fine time,
	Data_inizio date,
	Data_fine date,
)

create table IN_CORSO(
	Codice_taxi integer,
	FOREIGN KEY(Codice_taxi) references TAXI(Codice_taxi),
	Numero_chiamata integer,
	FOREIGN KEY(Numero_chiamata) references CHIAMATA(Numero_chiamata),
	Ora_fine_presunta time,
)

create table TAXI(
	Codice_taxi integer primary key,
	Nome_proprietario char(20),
	Cognome_proprietario char(20),
	Disponibilita char(1) check (Disponibilita = 'Y' OR Disponibilita = 'N'),
)

create table PRENOTAZIONE(
	Numero_chiamata integer,
	FOREIGN KEY(Numero_chiamata) references CHIAMATA(Numero_chiamata),
	Codice_taxi integer,
	FOREIGN KEY(Codice_taxi) references TAXI(Codice_taxi),
	Ora_richiesta time,
	Data_richiesta date,
)

/*Inserimento dei dati nella tabella TELEFONISTA*/
INSERT INTO TELEFONISTA (Codice_telefonista, Nome, Cognome, Data_di_nascita) VALUES (0001, 'Chiara', 'Gambacorti', '1960-12-03');
INSERT INTO TELEFONISTA (Codice_telefonista, Nome, Cognome, Data_di_nascita) VALUES (0002, 'Francesca', 'Bruno', '1967-10-13');
INSERT INTO TELEFONISTA (Codice_telefonista, Nome, Cognome, Data_di_nascita) VALUES (0003, 'Alessandra', 'Gandolfo', '1991-09-08');
INSERT INTO TELEFONISTA (Codice_telefonista, Nome, Cognome, Data_di_nascita) VALUES (0004, 'Rita', 'Guglielmi', '1990-09-07');
--INSERT INTO TELEFONISTA (Codice_telefonista, Nome, Cognome, Data_di_nascita) VALUES (0005, 'Giorgia', 'Santi', '1989-01-13');

/*Inserimento dei dati nella tabella CHIAMATA*/
INSERT INTO CHIAMATA (Numero_chiamata, Destinazione, Partenza, Data_chiam, Ora_chiam, Prenotata, Urgente, Codice_taxi, Codice_telefonista) VALUES (1234, 'Via Verdi', 'Piazza Dante', '2018-03-27', '11:23:45', 'Y', 'N', 9876, 0002);
INSERT INTO CHIAMATA (Numero_chiamata, Destinazione, Partenza, Data_chiam, Ora_chiam, Prenotata, Urgente, Codice_taxi, Codice_telefonista) VALUES (5678, 'Via Rossini', 'Largo Carlo Felice', '2018-04-25', '20:23:45', 'N', 'Y', 5432, 0003);
INSERT INTO CHIAMATA (Numero_chiamata, Destinazione, Partenza, Data_chiam, Ora_chiam, Prenotata, Urgente, Codice_taxi, Codice_telefonista) VALUES (9101, 'Via Pellegrini', 'Piazza Matteotti', '2018-10-17', '10:58:10', 'Y', 'N', 1098, 0001);
INSERT INTO CHIAMATA (Numero_chiamata, Destinazione, Partenza, Data_chiam, Ora_chiam, Prenotata, Urgente, Codice_taxi, Codice_telefonista) VALUES (1121, 'Piazzale Michelangelo', 'Largo Augusto', '2018-08-06', '22:15:00', 'Y', 'N', 7654, 0004);

/*Inserimento dei dati nella tabella SERVIZIO*/
INSERT INTO SERVIZIO (Codice_taxi, Numero_chiamata, Ora_inizio, Ora_fine, Data_inizio, Data_fine) VALUES (9876, 1234, '11:46:20', '12:05:05', '2018-03-27', '2018-03-27');
INSERT INTO SERVIZIO (Codice_taxi, Numero_chiamata, Ora_inizio, Ora_fine, Data_inizio, Data_fine) VALUES (7654, 1121, '22:15:00', '22:35:05', '2018-08-06', '2018-08-06');
INSERT INTO SERVIZIO (Codice_taxi, Numero_chiamata, Ora_inizio, Ora_fine, Data_inizio, Data_fine) VALUES (5432, 5678, '20:29:00', '21:28:05', '2018-04-25', '2018-04-25');
INSERT INTO SERVIZIO (Codice_taxi, Numero_chiamata, Ora_inizio, Ora_fine, Data_inizio, Data_fine) VALUES (1098, 9101, '12:03:20', '14:00:05', '2018-10-18', '2018-10-18');

/*Inserimento dei dati nella tabella TAXI*/
INSERT INTO TAXI (Codice_taxi, Nome_proprietario, Cognome_proprietario, Disponibilita) VALUES (9876, 'Lapo', 'Bernardini', 'Y');
INSERT INTO TAXI (Codice_taxi, Nome_proprietario, Cognome_proprietario, Disponibilita) VALUES (6543, 'Saverio', 'Giovacchini', 'N');
INSERT INTO TAXI (Codice_taxi, Nome_proprietario, Cognome_proprietario, Disponibilita) VALUES (2109, 'Antonio', 'Langella', 'N');
INSERT INTO TAXI (Codice_taxi, Nome_proprietario, Cognome_proprietario, Disponibilita) VALUES (4321, 'Giovanna', 'Piras', 'Y');

/*Inserimento dei dati nella tabella PRENOTAZIONE*/
INSERT INTO PRENOTAZIONE (Codice_taxi, Numero_chiamata, Ora_richiesta, Data_richiesta) VALUES (9876, 1121, '11:45:00', '2018-03-27');
INSERT INTO PRENOTAZIONE (Codice_taxi, Numero_chiamata, Ora_richiesta, Data_richiesta) VALUES (5432, 9101, '22:15:00', '2018-03-27');
INSERT INTO PRENOTAZIONE (Codice_taxi, Numero_chiamata, Ora_richiesta, Data_richiesta) VALUES (1098, 5678, '20:29:00', '2018-10-18');
INSERT INTO PRENOTAZIONE (Codice_taxi, Numero_chiamata, Ora_richiesta, Data_richiesta) VALUES (7654, 1234, '20:11:00', '2018-08-06');

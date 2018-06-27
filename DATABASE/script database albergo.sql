CREATE TABLE Clienti (
  id int IDENTITY (1,1) NOT NULL,
  nominativo varchar(100) NOT NULL,
  indirizzo varchar(200) NOT NULL,
  telefono varchar(15) NOT NULL,
  PRIMARY KEY ( id )
);

CREATE TABLE Camere (
   numero  smallint   NOT NULL,
   piano  tinyint   NOT NULL,
   tipo  varchar(20) NOT NULL,
   lettiAggiunti  varchar(20) NOT NULL,
   optionals  varchar(100),
   PRIMARY KEY  ( numero )
)

CREATE TABLE Prezzi (
   periodoDal  date NOT NULL,
   periodoAl  date NOT NULL,
   tipoCamera  varchar(20) NOT NULL,
   prezzo  decimal(6,2) NOT NULL
)

CREATE TABLE supplementi (
  codice tinyint IDENTITY(1,1) NOT NULL,
  voce varchar(20) NOT NULL,
  prezzo decimal(5,2) NOT NULL,
  PRIMARY KEY  (codice)
)

CREATE TABLE Prenotazioni (
   id  int IDENTITY (1,1) NOT NULL,
   periodoDal  date NOT NULL,
   periodoAl  date NOT NULL,
   camera  smallint   NOT NULL,
   idCliente  int   NOT NULL,
   prezzoTotale  decimal(7,2) NOT NULL,
  PRIMARY KEY  ( id ),
  FOREIGN KEY  (camera)  REFERENCES Camere (numero) ,
  FOREIGN KEY  (idCliente)  REFERENCES Clienti (id)
)

CREATE TABLE Supplementi_prenotati (
   idPrenotazione  int   NOT NULL,
   codiceSupplemento  tinyint   NOT NULL
);

GO

INSERT INTO CAMERE VALUES
(101, 1, 'singola','', 'ariaCondizionata'),
(102, 1, 'doppia', '', 'ariaCondizionata,vistaMare,tv'),
(103, 1, 'doppia', 'terzo', 'ariaCondizionata,vistaMare,tv'),
(104, 1, 'matrimoniale', 'terzo,quarto', 'ariaCondizionata'),
(201, 2, 'matrimoniale', 'terzo', 'ariaCondizionata,vistaMare,tv'),
(202, 2, 'matrimoniale', 'terzo', 'ariaCondizionata,vistaMare,tv'),
(203, 2, 'matrimoniale', 'terzo,quarto', 'ariaCondizionata'),
(301, 3, 'matrimoniale', 'terzo', 'ariaCondizionata,vistaMare,tv'),
(302, 3, 'matrimoniale', 'terzo', 'ariaCondizionata,vistaMare,tv'),
(303, 3, 'matrimoniale', 'terzo,quarto', 'ariaCondizionata'),
(401, 4, 'singola', '', 'fumatori'),
(402, 4, 'tripla', 'quarto', 'fumatori,vistaMare'),
(403, 4, 'tripla', 'quarto', 'fumatori');

INSERT INTO prezzi VALUES
('2006-05-01', '2006-05-31', 'singola', '50.00'),
('2006-05-01', '2006-05-31', 'doppia', '90.00'),
('2006-05-01', '2006-05-31', 'matrimoniale', '90.00'),
('2006-05-01', '2006-05-31', 'tripla', '130.00'),
('2006-06-01', '2006-06-30', 'singola', '55.00'),
('2006-06-01', '2006-06-30', 'doppia', '95.00'),
('2006-06-01', '2006-06-30', 'matrimoniale', '95.00'),
('2006-06-01', '2006-06-30', 'tripla', '140.00'),
('2006-07-01', '2006-07-31', 'singola', '65.00'),
('2006-07-01', '2006-07-31', 'doppia', '120.00'),
('2006-07-01', '2006-07-31', 'matrimoniale', '120.00'),
('2006-07-01', '2006-07-31', 'tripla', '160.00'),
('2006-08-01', '2006-08-31', 'singola', '80.00'),
('2006-08-01', '2006-08-31', 'doppia', '150.00'),
('2006-08-01', '2006-08-31', 'matrimoniale', '150.00'),
('2006-08-01', '2006-08-31', 'tripla', '200.00'),
('2006-09-01', '2006-09-30', 'singola', '50.00'),
('2006-09-01', '2006-09-30', 'doppia', '90.00'),
('2006-09-01', '2006-09-30', 'matrimoniale', '90.00'),
('2006-09-01', '2006-09-30', 'tripla', '130.00');

INSERT INTO  supplementi  VALUES
('culla', '8.00'),
('letto aggiuntivo', '30.00'),
('uso singola', '-15.00'),
('bed&breakfast', '-10.00'),
('pensione completa', '5.00');

INSERT INTO  clienti  VALUES
('Marco Rossi','Via Antonio Cesari 11A 20162 MILANO MI','3455432345'),
('Giulio Bianchi','Via d. inichino 8 NAPOLI','3455432346'),
('Francesca Brini','Via Paolo II 9 Otranto','3455432347'),
('Linda Rossi',	'via G M BARELLI 86 42012 carpi',	'3455432348'),
('Maria Gemma',	'via De Cosmi 37 Roma',	'3455432349'),
('Stefano Belluzzi',	'via Roma 2 Bari',	'3455432350'),
('Gianni Togni',	'via Petroni 4 Bologna',	'3455432351'),
('Marco Valdo',	'via Zamboni 5 Bologna',	'3455432352');


INSERT INTO  prenotazioni  VALUES
('2018-05-13','2018-05-20',102,3,900),
('2018-04-13','2018-04-20',202,6,1300),
('2018-05-08','2018-05-15',104,1,400),
('2018-05-03','2018-05-12',302,3,750),
('2018-04-22','2018-05-01',101,2,1100),
('2018-04-29','2018-05-30',102,7,130),
('2018-05-13','2018-05-18',201,6,910),
('2018-05-02','2018-05-30',401,5,470)


INSERT INTO  supplementi_prenotati  VALUES
(2,3),
(4,4),
(4,3),
(4,5);
--Francesca Collu
--Esercitazione settimana 4

/*1) Creazione di una vista che restituisce per ogni persona l'età media dei suoi figli.*/ 

create view EtaMediaFigli (NomeGenitore, EtaMedia)
		as select G.Genitore, avg(P.Eta)
		from PERSONE P inner join GENITORI G on P.Nome = G.Figlio
		group by G.Genitore

/* Di seguito la query per visualizzare il contenuto della vista.*/
select * from EtaMediaFigli



/*2) Utilizziamo la vista EtaMediaFigli per trovare tra tutti i genitori quelli i cui figli hanno l'età massima.*/
select * from EtaMediaFigli
where EtaMedia in (	select max(EtaMedia)
					from EtaMediaFigli )
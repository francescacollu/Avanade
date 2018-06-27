/*Esercitazione settimana 3 - Francesca Collu*/

/*1. Elenco ordinato dei genitori i cui figli guadagnano più di 20*/
select Genitore
from GENITORI G inner join PERSONE P on G.Figlio=P.Nome
where P.Reddito>20
order by Genitore


/*2. Trovare nome e reddito dei genitori di Ezechiele*/
select Genitore, Reddito
from Genitori G inner join Persone P on G.Genitore=P.Nome
where G.Figlio='Ezechiele'


/*3. Trovare la relazione che mostra per ogni persona i nonni*/
select G1.Figlio as Nipote, G2.Genitore as Nonno
from GENITORI G1 inner join GENITORI G2 on G1.Genitore=G2.Figlio


/*4. Trovare il reddito medio dei padri per età*/
select P.Eta, avg(P.Reddito) as Reddito_Medio
from GENITORI G inner join PERSONE P on G.Genitore=P.Nome
where P.Sesso = 'M'
group by P.Eta


/*5. Trovare la relazione che mostra le coppie di fratelli*/
/*Nota: ogni coppia di fratelli è ripetuta due volte.*/
select distinct G1.Figlio +' - '+ G2.Figlio as Fratelli
from GENITORI G1 inner join GENITORI G2 on G1.Genitore=G2.Genitore AND G1.Figlio<>G2.Figlio


/*6. Trovare le persone che sono genitori di almeno 2 figli*/
select Genitore
from GENITORI
group by Genitore
having count(Figlio) >= 2


/*7. Trovare la relazione che mostra per ciascun figlio, i rispettivi genitori
(Padre, Madre, Figlio)
Nota: vengono visualizzate soltanto le triplette complete; saranno esclusi i figli 
aventi solo un genitore*/
select G1.Genitore as Padre, G2.Genitore as Madre, G2.Figlio
from PERSONE P1 inner join GENITORI G1 on P1.Nome=G1.Genitore
				inner join GENITORI G2 on G1.Figlio=G2.Figlio
				inner join PERSONE P2 on G2.Genitore=P2.Nome
where P1.Sesso='M' AND P2.Sesso='F'


/*8. Elenco ordinato dei genitori i cui figli guadagnano tutti più di 20*/
select distinct Genitore
from GENITORI
where Genitore not in (	select Genitore
						from Genitori G inner join Persone P on G.Figlio=P.Nome
						where P.Reddito<=20 )
order by Genitore

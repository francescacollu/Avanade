/*Esercitazione 1-Francesca Collu*/

use Persone

/*Restituisce nome e reddito dei maschi con meno di trent'anni*/
select Nome, Reddito
from PERSONE
where Eta<30 AND Sesso = 'M'

/*Restituisce nome e sesso dei teenager*/
select Nome, Sesso
from PERSONE
where Eta>10 AND Eta<20

/*Restituisce l'elenco ordinato alfabeticamente di coloro che guadagnano più di 20*/
select Nome
from PERSONE
where Reddito>20
order by Nome

/*Restituisce tutti coloro il cui nome inizia per A*/
select*
from PERSONE
where Nome like 'A%'

/*Restituisce il nome e il reddito mensile di ogni persona in euro, ordinato dal maggiore al minore*/
select Nome, (Reddito/12)*1000 as RedditoMensile
from PERSONE
order by RedditoMensile DESC

/*Restituisce un campo unico delle informazioni 'Nome-Sesso'*/
select Nome +'-'+ Sesso as Nome_Sesso
from PERSONE
/*Francesca Collu - esercitazione database 4*/

--a
select count(Codice_taxi) as N_taxi_occupati
from IN_CORSO

--b
select avg(count(C.Numero_chiamata))
from CHIAMATA C inner join TELEFONISTA T on C.Codice_telefonista=T.Codice_telefonista
where T.Nome = 'Chiara'

--c
select Codice_taxi
from TAXI
where Disponibilita = 'Y'

--d
select count(Numero_chiamata) as N_clienti_soddisfatti
from SERVIZIO
group by Codice_taxi

--e
create view Telefoniste_con_Eta
as select *, datediff(year, Data_di_nascita,'2018-06-27') as Eta
from TELEFONISTA T

select top 1 *
from Telefoniste_con_Eta
order by Eta
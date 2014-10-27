--create table states(
-- state_id char(2) primary key,
-- state_name char(30)
--)

go

----insert into states (state_id)
----select distinct state from authors
----union select state from stores
----union select state from publishers where country = 'USA';

go

alter table publishers
add constraint FK_state_reference_states foreign key (state)
references state (state_id)
on update cascade;

go

alter table states
add Tax_perecent numeric(7,3) not null
default 0
go

create table shippers(
	shippers_id int primary key,
	company_name char(40)
)

go

alter table shippers
add Phone numeric(7,3) not null
default 'Unknown'

go

drop table shippers

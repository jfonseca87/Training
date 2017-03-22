create table Usuarios
(
	UsuarioId int identity(1,1) primary key,
	NUsuario varchar(15) not null,
	Password varchar(100) not null,
	Activo int 
)


alter table Usuarios add KeYValue varchar(15)

insert into usuarios (Nusuario, Password, Activo) values ('jlfr', 'abc123', 1)
insert into usuarios (Nusuario, Password, Activo) values ('jogar47', 'abc123', 1)
insert into usuarios (Nusuario, Password, Activo) values ('rosal28', 'abc123', 1)
insert into usuarios (Nusuario, Password, Activo) values ('jugu28', 'abc123', 1)
insert into usuarios (Nusuario, Password, Activo) values ('jennysp', 'abc123', 1)

select * from usuarios

update usuarios set KeYValue = 'FyMHTl3o' where UsuarioId = 1
update usuarios set KeYValue = '7h8CpwOo' where UsuarioId = 2
update usuarios set KeYValue = 'rTOo79yA' where UsuarioId = 3
update usuarios set KeYValue = 'M4ZvB5UV' where UsuarioId = 4
update usuarios set KeYValue = 'FR7XHxo3' where UsuarioId = 5

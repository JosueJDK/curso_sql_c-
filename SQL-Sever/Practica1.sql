create database Salazar;
use Salazar;

create table Alumno(
	idAlu char(4) primary key,
	apeAlu varchar(25) not null,
	nomAlu varchar(25) not null,
	dirAlu varchar(30) not null);

create table Curso(
	idCur char(3) primary key,
	nomCur varchar(25) not null,
	costo numeric(8,2));

create table Matricula(
	nMatri char(8) primary key,
	fMatri date,
	idAlu char(4) foreign key references Alumno,
	idCur char(3) foreign key references Curso);

-- Sp para el Formulario 8
-- Store Procedure para Buscar
create proc curso_buscar
@letra char(10)='%'
as
Select *
     From Curso C
	 Where C.nomCur Like rtrim(@letra) +'%'
go

alter proc matricula_buscar
@fecha1 date,
@fecha2 date
as
Select M.nMatri, M.fMatri, A.nomAlu,C.nomCur
     From Matricula M
	 inner join Curso C on M.idCur = C.idCur
	 inner join Alumno A on M.idAlu = A.idAlu
		Where M.fMatri >= @fecha1 AND  M.fMatri <= @fecha2; 
go

Exec curso_buscar 'p';
Exec matricula_buscar '2022/01/01', '2022/01/30';
--Insert values Alumno--
select * from Alumno;
insert into Alumno values ('1010', 'Salazar', 'Josue', 'Av. Jose San Martin');
insert into Alumno values ('2020', 'Mallcco', 'Ana', 'Av. La paz');
insert into Alumno values ('3030', 'Perez', 'Piero', 'Av. Bolivia');
insert into Alumno values ('4040', 'Rivera', 'Karen', 'Jr. Ica');
insert into Alumno values ('5050', 'Sanchez', 'Brisa', 'Jr. Huaraz');

--Insert Values Curso--
select * from Curso;
insert into Curso values ('111', 'Programacion', 500);
insert into Curso values ('222', 'Diseño Grafico', 320);
insert into Curso values ('333', 'Matematica I', 200);
insert into Curso values ('444', 'Fisica', 220);
insert into Curso values ('555', 'Quimica II', 150);
insert into Curso values ('777', 'Desarrollo Web', 320);
insert into Curso values ('888', 'Desarrollo Movil', 150);
insert into Curso values ('999', 'Ciencias I', 360);
insert into Curso values ('101', 'Bases de Datos', 100);
insert into Curso values ('121', 'Fisica II', 130);
drop table  Matricula;

--Inser Values matricula--
select * from Matricula;
insert into Matricula values ('10101010', '2022-05-15', '1010', '111');
insert into Matricula values ('20202020', '2022-08-05', '2020', '111');

insert into Matricula values ('30303030', '2022-02-20', '3030', '222');
insert into Matricula values ('40404040', '2022-06-25', '4040', '222');

insert into Matricula values ('50505050', '2022-01-10', '5050', '333');
insert into Matricula values ('60606060', '2022-02-06', '1010', '333');

insert into Matricula values ('70707070', '2022-03-03', '2020', '444');
insert into Matricula values ('80808080', '2022-08-15', '3030', '444');

insert into Matricula values ('90909090', '2022-10-13', '4040', '555');
insert into Matricula values ('01010101', '2022-09-18', '1010', '555');

insert into Matricula values ('02020202', '2022-11-22', '5050', '777');
insert into Matricula values ('03030303', '2022-12-26', '3030', '777');

insert into Matricula values ('04040404', '2022-09-30', '2020', '888');
insert into Matricula values ('05050505', '2022-03-09', '4040', '888');

insert into Matricula values ('06060606', '2022-01-10', '1010', '999');
insert into Matricula values ('07070707', '2022-03-01', '3030', '999');

insert into Matricula values ('08080808', '2022-06-30', '2020', '101');
insert into Matricula values ('09090909', '2022-04-28', '5050', '101');

insert into Matricula values ('11111111', '2022-05-04', '4040', '121');
insert into Matricula values ('22222222', '2022-08-19', '1010', '121');


use Northwind;

alter proc buscar_city
@country varchar(25)
as
Select CustomerId,CompanyName,ContactName, Address, City, Country
     From Customers
		Where Country = @country
go


Exec buscar_city 'Berlin'

create proc fecha_buscar
@fecha1 date,
@fecha2 date
as
	select O.OrderID, C.CompanyName, C.ContactName, C.City,
			E.LastName + ' ' +E.FirstName as 'Nombre Empleado',
			O.OrderDate, O.ShippedDate, O.Freight
		from Orders as O
		inner join Customers as C on O.CustomerID = C.CustomerID
		inner join Employees as E on O.EmployeeID = E.EmployeeID
		where Convert(DATE, O.ShippedDate) >= @fecha1 and Convert(DATE, O.ShippedDate) <= @fecha2
go
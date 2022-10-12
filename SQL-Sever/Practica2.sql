create database JSalazar;

use JSalazar;
create table Medicamento(
	ID int identity(1,1) not null,
	Cod_Med as ('Med-' + right('00000' + convert(varchar, ID), (5))), 
	Nomb_Medicam varchar(100) not null, 
	proveedor varchar(100) not null, 
	stock int, 
	precUnit money, 
	presentacion varchar(100), 
	fecha_vence date
);
drop table Medicamento

DROP PROCEDURE usp_MedicamentoCreate


CREATE PROCEDURE usp_MedicamentoCreate
	@Nomb_Medicam varchar(100), 
	@proveedor varchar(100), 
	@stock int, 
	@precUnit money, 
	@presentacion varchar(100), 
	@fecha_vence date
AS INSERT INTO Medicamento(Nomb_Medicam, proveedor, stock, precUnit, presentacion, fecha_vence)
    VALUES  (@Nomb_Medicam, @proveedor, @stock, @precUnit, @presentacion, @fecha_vence)

select * from Medicamento
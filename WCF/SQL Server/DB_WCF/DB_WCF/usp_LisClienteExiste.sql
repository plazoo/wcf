use SGO
go

/*
* Creado por:Slater AR
* Fecha: 05/10/2017
* Descripción: 
	--Comprueba si un cliente existe en la tabla
	--<COMPROBANTE_VENTA_CAB> para darles acceso a crearse 
	--su cuenta para consultas de facturas
*/
ALTER PROCEDURE usp_LisClienteExiste
@NroDocumento varChar(15)=NULL
AS
DECLARE @return bit
BEGIN
	IF (SELECT COUNT(*) FROM COMPROBANTE_VENTA_CAB WHERE LTRIM(RTRIM(NroDocumentoCliente))=LTRIM(RTRIM(@NroDocumento)))>0
	BEGIN
		SET @return=1
	END
	ELSE
	BEGIN
		SET @return=0
	END
	SELECT @return AS 'Response'
END

/*


usp_LisClienteExiste '123456789'

*/
go


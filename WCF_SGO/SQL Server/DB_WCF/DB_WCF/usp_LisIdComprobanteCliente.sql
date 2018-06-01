Use SGO
Go


ALTER PROCEDURE usp_LisIdComprobanteCliente
@IdComprobante int
AS
BEGIN
SELECT
UPPER(e.vRAZONSOCIAL) AS 'RAZONSOCIAL_PRODELSUR'
,e.vCODIGOTRIBUTARIO AS 'RUC_PRODELSUR'
,c.IdComprobante
,c.Correlativo
--,c.IdEstadoProceso
,fr.ResponseDescription AS 'InvoiceState'
,c.ImporteSubtotal
,c.Impuesto
,c.ImporteTotal
,CONVERT(VARCHAR,c.FechaRegistra,103) AS 'FechaOperacion'
,f.NombreArhivo
,CASE WHEN UPPER(RTRIM(LTRIM(c.TipoMoneda)))='PEN' THEN 'S/' ELSE '$' END AS 'TipoMoneda'
--,f.Trama
--,c.IdTipoComprobante
FROM SGU.DBO.EMPRESA e WITH(NOLOCK),
COMPROBANTE_VENTA_CAB c WITH(NOLOCK)
INNER JOIN COMPROBANTE_VENTA_DET d WITH(NOLOCK) ON c.IdComprobante = d.IdComprobante
INNER JOIN COMPROBANTEVENTA_PROCESO cp WITH(NOLOCK) ON c.IdComprobante = cp.IdComprobante
INNER JOIN COMPROBANTEVENTA_FILE f WITH(NOLOCK) ON c.IdComprobante = f.IdComprobante
INNER JOIN COMPROBANTEVENTA_FILE_RESPONSE fr WITH(NOLOCK) ON f.IdComprobanteFile = fr.IdComprobanteFile
WHERE(
	C.IdEstado=1
	AND d.IdEstado=1
	AND cp.IdEstado =1
	AND cp.IdEstadoProceso = 2
	AND f.StateInvoice IN(2,4)
	AND fr.ResponseStatus=4
	AND c.IdComprobante = @IdComprobante
	)
END

/*


usp_LisIdComprobanteCliente 162


*/

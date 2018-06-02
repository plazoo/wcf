/*  
CREADO POR : PLAZO  
FECHA: 20170831  
INS TBL_LOG  
*/  
  
ALTER PROC usp_INS_TBL_LOG  
@vcException NVARCHAR(Max),  
@idUsuario INT  =NULL
AS  
  
 INSERT INTO TBL_LOG (  
     vcException,  
     dtFecReg,  
     idUsuario)   
   VALUES (@vcException,  
     GETDATE(),  
     ISNULL(@idUsuario,0))  
  
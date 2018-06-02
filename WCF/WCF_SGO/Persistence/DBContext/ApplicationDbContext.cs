namespace Persistence.DBContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {
        }

        public virtual DbSet<AREA> AREAs { get; set; }
        public virtual DbSet<BANCO> BANCOes { get; set; }
        public virtual DbSet<CAJACHICA> CAJACHICAs { get; set; }
        public virtual DbSet<CAJACHICA_CIERRE> CAJACHICA_CIERRE { get; set; }
        public virtual DbSet<CAJACHICA_SALDO> CAJACHICA_SALDO { get; set; }
        public virtual DbSet<CAJACHICA_TIPODOCUMENTO> CAJACHICA_TIPODOCUMENTO { get; set; }
        public virtual DbSet<CARGO> CARGOes { get; set; }
        public virtual DbSet<CATALOGO_CUENTA_CONTABLE> CATALOGO_CUENTA_CONTABLE { get; set; }
        public virtual DbSet<CBANCO_TRABAJADOR> CBANCO_TRABAJADOR { get; set; }
        public virtual DbSet<CERTIFICADO_SALDO> CERTIFICADO_SALDO { get; set; }
        public virtual DbSet<CERTIFICADO_SALDO_HISTORY> CERTIFICADO_SALDO_HISTORY { get; set; }
        public virtual DbSet<CERTIFICADO_VSP> CERTIFICADO_VSP { get; set; }
        public virtual DbSet<CIERRE_ANUAL> CIERRE_ANUAL { get; set; }
        public virtual DbSet<CIERRE_CONTRATO> CIERRE_CONTRATO { get; set; }
        public virtual DbSet<CIERRE_GUIAINGRESO> CIERRE_GUIAINGRESO { get; set; }
        public virtual DbSet<CIERRE_KARDEX> CIERRE_KARDEX { get; set; }
        public virtual DbSet<CIERRE_LIQUIDACION> CIERRE_LIQUIDACION { get; set; }
        public virtual DbSet<CIERRE_OTORGADO> CIERRE_OTORGADO { get; set; }
        public virtual DbSet<CIERRE_SERVICIO> CIERRE_SERVICIO { get; set; }
        public virtual DbSet<CLIENTE> CLIENTEs { get; set; }
        public virtual DbSet<CLIENTE_BANCO> CLIENTE_BANCO { get; set; }
        public virtual DbSet<CLIENTE_CERTIFICADO> CLIENTE_CERTIFICADO { get; set; }
        public virtual DbSet<CLIENTE_CONTACTO> CLIENTE_CONTACTO { get; set; }
        public virtual DbSet<CLIENTE_COSECHA> CLIENTE_COSECHA { get; set; }
        public virtual DbSet<CLIENTE_GARANTIA> CLIENTE_GARANTIA { get; set; }
        public virtual DbSet<CLIENTE_LIMITE> CLIENTE_LIMITE { get; set; }
        public virtual DbSet<CLIENTEINHABILITADO> CLIENTEINHABILITADOes { get; set; }
        public virtual DbSet<COMPROBANTE_VENTA_CAB> COMPROBANTE_VENTA_CAB { get; set; }
        public virtual DbSet<COMPROBANTE_VENTA_DET> COMPROBANTE_VENTA_DET { get; set; }
        public virtual DbSet<COMPROBANTEVENTA_FILE> COMPROBANTEVENTA_FILE { get; set; }
        public virtual DbSet<COMPROBANTEVENTA_FILE_RESPONSE> COMPROBANTEVENTA_FILE_RESPONSE { get; set; }
        public virtual DbSet<COMPROBANTEVENTA_PROCESO> COMPROBANTEVENTA_PROCESO { get; set; }
        public virtual DbSet<CONTRATO_COMPRA> CONTRATO_COMPRA { get; set; }
        public virtual DbSet<CONTRATO_COMPRA_HISTORICO> CONTRATO_COMPRA_HISTORICO { get; set; }
        public virtual DbSet<CONTRATO_COMPRA_SWITCH> CONTRATO_COMPRA_SWITCH { get; set; }
        public virtual DbSet<CONTRATO_COMPRA_UNFIXED> CONTRATO_COMPRA_UNFIXED { get; set; }
        public virtual DbSet<CONTRATO_COMPRA_ZONA> CONTRATO_COMPRA_ZONA { get; set; }
        public virtual DbSet<CONTRATO_ZONA_OUT> CONTRATO_ZONA_OUT { get; set; }
        public virtual DbSet<CONTRATO_ZONA_SWITCH> CONTRATO_ZONA_SWITCH { get; set; }
        public virtual DbSet<CONTRATO_ZONA_UNFIXED> CONTRATO_ZONA_UNFIXED { get; set; }
        public virtual DbSet<CORREO> CORREOs { get; set; }
        public virtual DbSet<CUENTA_BANCO> CUENTA_BANCO { get; set; }
        public virtual DbSet<DEPARTAMENTO> DEPARTAMENTOes { get; set; }
        public virtual DbSet<DOCUMENTO_OPERACION> DOCUMENTO_OPERACION { get; set; }
        public virtual DbSet<ERRORINVOICE> ERRORINVOICEs { get; set; }
        public virtual DbSet<ESTADO> ESTADOes { get; set; }
        public virtual DbSet<GASTO_APROBACION> GASTO_APROBACION { get; set; }
        public virtual DbSet<GASTO_CENTRO_COSTO> GASTO_CENTRO_COSTO { get; set; }
        public virtual DbSet<GASTO_MOVILIDAD_CAB> GASTO_MOVILIDAD_CAB { get; set; }
        public virtual DbSet<GASTO_MOVILIDAD_DET> GASTO_MOVILIDAD_DET { get; set; }
        public virtual DbSet<GASTO_PRP_CAB> GASTO_PRP_CAB { get; set; }
        public virtual DbSet<GASTO_PRP_DET> GASTO_PRP_DET { get; set; }
        public virtual DbSet<GASTO_RECIBO_MOVILIDAD> GASTO_RECIBO_MOVILIDAD { get; set; }
        public virtual DbSet<GUIA_INGRESO_CAB> GUIA_INGRESO_CAB { get; set; }
        public virtual DbSet<GUIA_INGRESO_DET> GUIA_INGRESO_DET { get; set; }
        public virtual DbSet<GUIA_INGRESO_SALDO> GUIA_INGRESO_SALDO { get; set; }
        public virtual DbSet<IDIOMA> IDIOMAs { get; set; }
        public virtual DbSet<LABORATORIO> LABORATORIOs { get; set; }
        public virtual DbSet<LABORATORIO_DEFECTO> LABORATORIO_DEFECTO { get; set; }
        public virtual DbSet<LABORATORIO_REFERENCIA> LABORATORIO_REFERENCIA { get; set; }
        public virtual DbSet<LIQUIDACION_COMPRA_CAB> LIQUIDACION_COMPRA_CAB { get; set; }
        public virtual DbSet<LIQUIDACION_COMPRA_DET> LIQUIDACION_COMPRA_DET { get; set; }
        public virtual DbSet<LIQUIDACION_COMPRA_SALDO> LIQUIDACION_COMPRA_SALDO { get; set; }
        public virtual DbSet<MODULO_COMPARTIDO_USUARIO> MODULO_COMPARTIDO_USUARIO { get; set; }
        public virtual DbSet<MOTIVO_VISITA> MOTIVO_VISITA { get; set; }
        public virtual DbSet<ODCS_ESTADOS> ODCS_ESTADOS { get; set; }
        public virtual DbSet<ODCS_HISTORICO> ODCS_HISTORICO { get; set; }
        public virtual DbSet<ODCS_PROVEEDOR> ODCS_PROVEEDOR { get; set; }
        public virtual DbSet<ORDEN_COMPRA_CAB> ORDEN_COMPRA_CAB { get; set; }
        public virtual DbSet<ORDEN_COMPRA_DET> ORDEN_COMPRA_DET { get; set; }
        public virtual DbSet<OTORGADO_SALDO_INICIAL> OTORGADO_SALDO_INICIAL { get; set; }
        public virtual DbSet<OTORGADO_ZONA> OTORGADO_ZONA { get; set; }
        public virtual DbSet<OTORGADO_ZONA_DET> OTORGADO_ZONA_DET { get; set; }
        public virtual DbSet<PRECIO_BOLSA> PRECIO_BOLSA { get; set; }
        public virtual DbSet<PRECIO_DIA> PRECIO_DIA { get; set; }
        public virtual DbSet<PROVINCIA> PROVINCIAs { get; set; }
        public virtual DbSet<REGION> REGIONs { get; set; }
        public virtual DbSet<RESUMEN_COMPRA_CLIENTE> RESUMEN_COMPRA_CLIENTE { get; set; }
        public virtual DbSet<RESUMEN_COMPRA_CLIENTE_DETALLE> RESUMEN_COMPRA_CLIENTE_DETALLE { get; set; }
        public virtual DbSet<RESUMEN_COMPRA_CLIENTE_DETALLE_TEMP> RESUMEN_COMPRA_CLIENTE_DETALLE_TEMP { get; set; }
        public virtual DbSet<RESUMEN_COMPRA_CLIENTE_TEMP> RESUMEN_COMPRA_CLIENTE_TEMP { get; set; }
        public virtual DbSet<SERVICIO_PRP_CABECERA> SERVICIO_PRP_CABECERA { get; set; }
        public virtual DbSet<SERVICIO_PRP_DETALLE> SERVICIO_PRP_DETALLE { get; set; }
        public virtual DbSet<SERVICIO_PRP_ELIMINADO> SERVICIO_PRP_ELIMINADO { get; set; }
        public virtual DbSet<SERVICIO_PRP_RESULTADO> SERVICIO_PRP_RESULTADO { get; set; }
        public virtual DbSet<SITUACION_HIPOTECA> SITUACION_HIPOTECA { get; set; }
        public virtual DbSet<SOLICITUD_VISITA> SOLICITUD_VISITA { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TBL_ARCHIVO_CARGAMASIVA> TBL_ARCHIVO_CARGAMASIVA { get; set; }
        public virtual DbSet<TBL_LOG> TBL_LOG { get; set; }
        public virtual DbSet<TICKET_PESADA> TICKET_PESADA { get; set; }
        public virtual DbSet<TIPO_AGENTE> TIPO_AGENTE { get; set; }
        public virtual DbSet<TIPO_ARBITRAJE> TIPO_ARBITRAJE { get; set; }
        public virtual DbSet<TIPO_BLACKLIST> TIPO_BLACKLIST { get; set; }
        public virtual DbSet<TIPO_CAFE> TIPO_CAFE { get; set; }
        public virtual DbSet<TIPO_CAJA_CHICA_ZONA> TIPO_CAJA_CHICA_ZONA { get; set; }
        public virtual DbSet<TIPO_CALIDAD> TIPO_CALIDAD { get; set; }
        public virtual DbSet<TIPO_CALIDAD_LABORATORIO> TIPO_CALIDAD_LABORATORIO { get; set; }
        public virtual DbSet<TIPO_CALIDAD_PRECIO> TIPO_CALIDAD_PRECIO { get; set; }
        public virtual DbSet<TIPO_CAMBIO_OPERACION> TIPO_CAMBIO_OPERACION { get; set; }
        public virtual DbSet<TIPO_CLIENTE> TIPO_CLIENTE { get; set; }
        public virtual DbSet<TIPO_COMPRA> TIPO_COMPRA { get; set; }
        public virtual DbSet<TIPO_COND_PAGO> TIPO_COND_PAGO { get; set; }
        public virtual DbSet<TIPO_CONTROL_BASE> TIPO_CONTROL_BASE { get; set; }
        public virtual DbSet<TIPO_COSECHA> TIPO_COSECHA { get; set; }
        public virtual DbSet<TIPO_DEFECTO> TIPO_DEFECTO { get; set; }
        public virtual DbSet<TIPO_DESTINO> TIPO_DESTINO { get; set; }
        public virtual DbSet<TIPO_DIFERENCIAL> TIPO_DIFERENCIAL { get; set; }
        public virtual DbSet<TIPO_DOCUMENTO> TIPO_DOCUMENTO { get; set; }
        public virtual DbSet<TIPO_DSA> TIPO_DSA { get; set; }
        public virtual DbSet<TIPO_ESTADO> TIPO_ESTADO { get; set; }
        public virtual DbSet<TIPO_FIJADOR> TIPO_FIJADOR { get; set; }
        public virtual DbSet<TIPO_GARANTIA> TIPO_GARANTIA { get; set; }
        public virtual DbSet<TIPO_INMUEBLE> TIPO_INMUEBLE { get; set; }
        public virtual DbSet<TIPO_MES_FIJACION> TIPO_MES_FIJACION { get; set; }
        public virtual DbSet<TIPO_MODALIDAD_OTORGADO> TIPO_MODALIDAD_OTORGADO { get; set; }
        public virtual DbSet<TIPO_MONEDA> TIPO_MONEDA { get; set; }
        public virtual DbSet<TIPO_MOTIVO_OTORGADO> TIPO_MOTIVO_OTORGADO { get; set; }
        public virtual DbSet<TIPO_ORIGEN> TIPO_ORIGEN { get; set; }
        public virtual DbSet<TIPO_PRECIO> TIPO_PRECIO { get; set; }
        public virtual DbSet<TIPO_REGLAS_PESO> TIPO_REGLAS_PESO { get; set; }
        public virtual DbSet<TIPO_RENDIMIENTO> TIPO_RENDIMIENTO { get; set; }
        public virtual DbSet<TIPO_RUMA> TIPO_RUMA { get; set; }
        public virtual DbSet<TIPO_SACO> TIPO_SACO { get; set; }
        public virtual DbSet<TIPO_SEGUNDA> TIPO_SEGUNDA { get; set; }
        public virtual DbSet<TIPO_SERIE_COMPRA> TIPO_SERIE_COMPRA { get; set; }
        public virtual DbSet<TIPO_SERIE_VENTA> TIPO_SERIE_VENTA { get; set; }
        public virtual DbSet<TIPO_SERVICIO> TIPO_SERVICIO { get; set; }
        public virtual DbSet<TIPO_TAZA> TIPO_TAZA { get; set; }
        public virtual DbSet<TIPO_TERMINO_ENTREGA> TIPO_TERMINO_ENTREGA { get; set; }
        public virtual DbSet<TIPO_TITULO_VALOR> TIPO_TITULO_VALOR { get; set; }
        public virtual DbSet<TIPO_TRADER> TIPO_TRADER { get; set; }
        public virtual DbSet<TIPO_UNIDAD_MEDIDA> TIPO_UNIDAD_MEDIDA { get; set; }
        public virtual DbSet<TIPO_VALUACION> TIPO_VALUACION { get; set; }
        public virtual DbSet<TIPO_VISITA> TIPO_VISITA { get; set; }
        public virtual DbSet<TRABAJADOR_PRP> TRABAJADOR_PRP { get; set; }
        public virtual DbSet<TRABAJADOR_PRP_JEFATURA> TRABAJADOR_PRP_JEFATURA { get; set; }
        public virtual DbSet<TRASLADO_CHOFER> TRASLADO_CHOFER { get; set; }
        public virtual DbSet<TRASLADO_DET> TRASLADO_DET { get; set; }
        public virtual DbSet<TRASLADO_EMPRESA> TRASLADO_EMPRESA { get; set; }
        public virtual DbSet<TRASLADO_MOTIVO> TRASLADO_MOTIVO { get; set; }
        public virtual DbSet<TRASLADO_SALDO> TRASLADO_SALDO { get; set; }
        public virtual DbSet<TRASLADO_ZONA> TRASLADO_ZONA { get; set; }
        public virtual DbSet<COMPROBANTEVENTA_APROBACION> COMPROBANTEVENTA_APROBACION { get; set; }
        public virtual DbSet<DISTRITO> DISTRITOes { get; set; }
        public virtual DbSet<GUIA_INGRESO_CAB_BK> GUIA_INGRESO_CAB_BK { get; set; }
        public virtual DbSet<GUIA_INGRESO_DET_BK> GUIA_INGRESO_DET_BK { get; set; }
        public virtual DbSet<GUIA_INGRESO_SALDO_BK> GUIA_INGRESO_SALDO_BK { get; set; }
        public virtual DbSet<ODCS_PROVEEDOR_BANCO> ODCS_PROVEEDOR_BANCO { get; set; }
        public virtual DbSet<OTORGADO_ZONA_BK> OTORGADO_ZONA_BK { get; set; }
        public virtual DbSet<PARAMETRO> PARAMETROes { get; set; }
        public virtual DbSet<SERVICIO_PRP_CABECERA_BK> SERVICIO_PRP_CABECERA_BK { get; set; }
        public virtual DbSet<tbl_prueba> tbl_prueba { get; set; }
        public virtual DbSet<TICKET_PESADA_BK> TICKET_PESADA_BK { get; set; }
        public virtual DbSet<TRASLADO_CAB> TRASLADO_CAB { get; set; }
        public virtual DbSet<TRASLADO_DESPACHOCAFE> TRASLADO_DESPACHOCAFE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AREA>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<AREA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<BANCO>()
                .Property(e => e.RazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<BANCO>()
                .Property(e => e.NombreComercial)
                .IsUnicode(false);

            modelBuilder.Entity<BANCO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<BANCO>()
                .HasMany(e => e.CLIENTE_BANCO)
                .WithRequired(e => e.BANCO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BANCO>()
                .HasMany(e => e.CLIENTE_CONTACTO)
                .WithRequired(e => e.BANCO)
                .HasForeignKey(e => e.IdArea)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAJACHICA>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CAJACHICA>()
                .Property(e => e.IdMoneda)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CAJACHICA>()
                .HasMany(e => e.CAJACHICA_SALDO)
                .WithRequired(e => e.CAJACHICA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAJACHICA_SALDO>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CAJACHICA_TIPODOCUMENTO>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CAJACHICA_TIPODOCUMENTO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CARGO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CARGO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<CARGO>()
                .HasMany(e => e.CLIENTE_CONTACTO)
                .WithRequired(e => e.CARGO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CATALOGO_CUENTA_CONTABLE>()
                .Property(e => e.CuentaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CATALOGO_CUENTA_CONTABLE>()
                .Property(e => e.CuentaContableDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CATALOGO_CUENTA_CONTABLE>()
                .Property(e => e.CuentaHyperion)
                .IsUnicode(false);

            modelBuilder.Entity<CATALOGO_CUENTA_CONTABLE>()
                .Property(e => e.CuentaHyperionDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CBANCO_TRABAJADOR>()
                .Property(e => e.NroCuentaCheque)
                .IsUnicode(false);

            modelBuilder.Entity<CBANCO_TRABAJADOR>()
                .Property(e => e.CodigoInterbancario)
                .IsUnicode(false);

            modelBuilder.Entity<CERTIFICADO_SALDO>()
                .Property(e => e.IdTipoOperacion)
                .IsUnicode(false);

            modelBuilder.Entity<CERTIFICADO_SALDO>()
                .HasMany(e => e.CERTIFICADO_SALDO_HISTORY)
                .WithRequired(e => e.CERTIFICADO_SALDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CERTIFICADO_VSP>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CERTIFICADO_VSP>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<CERTIFICADO_VSP>()
                .HasMany(e => e.CLIENTE_CERTIFICADO)
                .WithRequired(e => e.CERTIFICADO_VSP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CIERRE_ANUAL>()
                .HasMany(e => e.CIERRE_CONTRATO)
                .WithRequired(e => e.CIERRE_ANUAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CIERRE_ANUAL>()
                .HasMany(e => e.CIERRE_GUIAINGRESO)
                .WithRequired(e => e.CIERRE_ANUAL)
                .HasForeignKey(e => e.IDDETALLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CIERRE_ANUAL>()
                .HasMany(e => e.CIERRE_KARDEX)
                .WithRequired(e => e.CIERRE_ANUAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CIERRE_ANUAL>()
                .HasMany(e => e.CIERRE_LIQUIDACION)
                .WithRequired(e => e.CIERRE_ANUAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CIERRE_ANUAL>()
                .HasMany(e => e.CIERRE_OTORGADO)
                .WithRequired(e => e.CIERRE_ANUAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CIERRE_ANUAL>()
                .HasMany(e => e.CIERRE_SERVICIO)
                .WithRequired(e => e.CIERRE_ANUAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CIERRE_CONTRATO>()
                .Property(e => e.IDCONTRATOCOMPRA)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_CONTRATO>()
                .Property(e => e.LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_CONTRATO>()
                .Property(e => e.TIPO_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_CONTRATO>()
                .Property(e => e.TIPOCOMPRA)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_CONTRATO>()
                .Property(e => e.FECHACONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_CONTRATO>()
                .Property(e => e.TIPOCAFE)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_CONTRATO>()
                .Property(e => e.CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_CONTRATO>()
                .Property(e => e.CALIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_CONTRATO>()
                .Property(e => e.OBSERVACIONES)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_CONTRATO>()
                .Property(e => e.CERTIFICACION)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_CONTRATO>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_CONTRATO>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_CONTRATO>()
                .Property(e => e.MES_FIJACION)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_CONTRATO>()
                .Property(e => e.DIFERENCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.GUIAINGRESO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.CONTACTOCLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.DESCCERTIFICACION)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.IdCertificadoVSP)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.ProcesoDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.PROPIEDAD)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.DESCUSUARIOREGISTRO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.FECHAREGISTRO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.DESCUSUARIOMODIFICA)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.FECHAMODIFICA)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.RUMA)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.MODALIDADINGRESO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.TipoCafe)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.ORIGEN)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.TRASLADO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.GUIAREMISIONEXTERNA)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.OBSERVACION)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.CONTRATOCOMPRA)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.LIQUIDACION)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.SS)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_GUIAINGRESO>()
                .Property(e => e.CALIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_KARDEX>()
                .Property(e => e.OPERACION)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_KARDEX>()
                .Property(e => e.LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_KARDEX>()
                .Property(e => e.IDCONTRATOCOMPRA)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_KARDEX>()
                .Property(e => e.CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_KARDEX>()
                .Property(e => e.FECHACONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_KARDEX>()
                .Property(e => e.TIPOCAFE)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_KARDEX>()
                .Property(e => e.MOTIVO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_KARDEX>()
                .Property(e => e.BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_KARDEX>()
                .Property(e => e.TIPOCOMPRA)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_KARDEX>()
                .Property(e => e.CALIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_KARDEX>()
                .Property(e => e.PRECIO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CIERRE_KARDEX>()
                .Property(e => e.IDLIQUIDACION)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_LIQUIDACION>()
                .Property(e => e.CodigoLiquidacion)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_LIQUIDACION>()
                .Property(e => e.CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_LIQUIDACION>()
                .Property(e => e.PRODUCTOR)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_LIQUIDACION>()
                .Property(e => e.IdGuiaIngreso)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_LIQUIDACION>()
                .Property(e => e.DescGuiaIngreso)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_LIQUIDACION>()
                .Property(e => e.DescContratoCompra)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_LIQUIDACION>()
                .Property(e => e.CALIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_LIQUIDACION>()
                .Property(e => e.UsuarioRegistra)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_LIQUIDACION>()
                .Property(e => e.UsuarioModifica)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_LIQUIDACION>()
                .Property(e => e.FacturaSerie)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_LIQUIDACION>()
                .Property(e => e.FacturaNumero)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_LIQUIDACION>()
                .Property(e => e.FacturaFecha)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_LIQUIDACION>()
                .Property(e => e.SerieDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_LIQUIDACION>()
                .Property(e => e.NroDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_LIQUIDACION>()
                .Property(e => e.CERTIFICACION)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_LIQUIDACION>()
                .Property(e => e.USUARIOASIGNACIONPRECIO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_OTORGADO>()
                .Property(e => e.CodigoOtorgadoZona)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_OTORGADO>()
                .Property(e => e.CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_OTORGADO>()
                .Property(e => e.FechaEmision)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_OTORGADO>()
                .Property(e => e.IdTipoIngreso)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_OTORGADO>()
                .Property(e => e.ModalidadOtorgado)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_OTORGADO>()
                .Property(e => e.DocumentoReferencia)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_OTORGADO>()
                .Property(e => e.SIMBOLO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_OTORGADO>()
                .Property(e => e.MotivoOtorgado)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_OTORGADO>()
                .Property(e => e.OBSERVACIONES)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_OTORGADO>()
                .Property(e => e.UsuarioRegistra)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_OTORGADO>()
                .Property(e => e.TIPODOCUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_OTORGADO>()
                .Property(e => e.DOCUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_OTORGADO>()
                .Property(e => e.ContratoCompra)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_OTORGADO>()
                .Property(e => e.APROBACION)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_OTORGADO>()
                .Property(e => e.BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_OTORGADO>()
                .Property(e => e.NroOperacion)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_OTORGADO>()
                .Property(e => e.FechaTransferencia)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_OTORGADO>()
                .Property(e => e.DESCCUENTABANCARIA)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_OTORGADO>()
                .Property(e => e.IDAPROBACION)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_SERVICIO>()
                .Property(e => e.CODIGOORDENSERVICIO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_SERVICIO>()
                .Property(e => e.LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_SERVICIO>()
                .Property(e => e.IDTIPOSERVICIO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_SERVICIO>()
                .Property(e => e.TIPOSERVICIO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_SERVICIO>()
                .Property(e => e.CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_SERVICIO>()
                .Property(e => e.TIPO_CAFE)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_SERVICIO>()
                .Property(e => e.CERTIFICADO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_SERVICIO>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_SERVICIO>()
                .Property(e => e.VUSUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_SERVICIO>()
                .Property(e => e.OBSERVACION)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_SERVICIO>()
                .Property(e => e.CodigoLiquidacion)
                .IsUnicode(false);

            modelBuilder.Entity<CIERRE_SERVICIO>()
                .Property(e => e.CodigoTraslado)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.DocIdentidad)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.NombreComercial)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.RazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.NombreCliente)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.ApellidoCliente)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.TelefonoPrincipal)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.TelefonoAlternativo)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.CentroPoblado)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.Caserio)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.DireccionContrato)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.DireccionFactura)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.ReferenciaFactura)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.DireccionInstruccion)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.DireccionMuestra)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.NombreLegal)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.ApellidoLegal)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.DocIdentidadLegal)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.TelefonoLegal)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.CorreoLegal)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.UsuarioModifica)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.IdExcel)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.IdZona)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.CadenaCP)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.FLOID)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.CLIENTE_BANCO)
                .WithRequired(e => e.CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.CLIENTE_CERTIFICADO)
                .WithRequired(e => e.CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.CLIENTE_CONTACTO)
                .WithRequired(e => e.CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.CLIENTE_GARANTIA)
                .WithRequired(e => e.CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.CLIENTE_LIMITE)
                .WithRequired(e => e.CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.CONTRATO_COMPRA)
                .WithRequired(e => e.CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.CONTRATO_COMPRA_ZONA)
                .WithRequired(e => e.CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.GUIA_INGRESO_CAB)
                .WithRequired(e => e.CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.LABORATORIOs)
                .WithRequired(e => e.CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.SERVICIO_PRP_CABECERA)
                .WithRequired(e => e.CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.TICKET_PESADA)
                .WithRequired(e => e.CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTE_BANCO>()
                .Property(e => e.NroCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE_BANCO>()
                .Property(e => e.NroCuentaInterbancario)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE_BANCO>()
                .Property(e => e.CodigoSwift)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE_BANCO>()
                .Property(e => e.Detraccion)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE_BANCO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE_CERTIFICADO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE_CONTACTO>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE_CONTACTO>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE_CONTACTO>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE_CONTACTO>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE_CONTACTO>()
                .Property(e => e.DireccionFactura)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE_CONTACTO>()
                .Property(e => e.DireccionReferencia)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE_CONTACTO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE_GARANTIA>()
                .Property(e => e.NroPartida)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE_GARANTIA>()
                .Property(e => e.CoordenadaX)
                .HasPrecision(20, 14);

            modelBuilder.Entity<CLIENTE_GARANTIA>()
                .Property(e => e.CoordenadaY)
                .HasPrecision(20, 14);

            modelBuilder.Entity<CLIENTE_GARANTIA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE_GARANTIA>()
                .Property(e => e.DireccionGarantia)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE_LIMITE>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTEINHABILITADO>()
                .Property(e => e.IdTipoCliente)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTEINHABILITADO>()
                .Property(e => e.DocIdentidad)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTEINHABILITADO>()
                .Property(e => e.RazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTEINHABILITADO>()
                .Property(e => e.NombreCliente)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTEINHABILITADO>()
                .Property(e => e.ApellidoCliente)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTEINHABILITADO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTEINHABILITADO>()
                .Property(e => e.IdEstado)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.Correlativo)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.IdLocal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.IdTipoComprobante)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.IdSerieComprobante)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.NombreCliente)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.RazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.DireccionCliente)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.NroDocumentoCliente)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.ContratoReferencia)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.TipoMoneda)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.TipoCambio)
                .HasPrecision(18, 3);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.CodigoHash)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.EstadoEnvioCorreo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.IdMotivo)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.MotivoDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.PuertoEmbarque)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.PuertoDestino)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.IdTipoOperacion)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.ExpVapor)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.ExpFormaPago)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.ExpFlete)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.ExpSeguro)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.ExpNotificar)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.ExpPaisOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.ExpOtrosConceptos)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.IdTipoComprobanteRef)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.CorrelativoRef)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .Property(e => e.TipoOperacion)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_CAB>()
                .HasMany(e => e.COMPROBANTEVENTA_FILE)
                .WithRequired(e => e.COMPROBANTE_VENTA_CAB)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_DET>()
                .Property(e => e.Unidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_DET>()
                .Property(e => e.GuiaRemisionRef)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_DET>()
                .Property(e => e.DescripcionServicio)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_DET>()
                .Property(e => e.IdTipoImpuesto)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_DET>()
                .Property(e => e.IdMotivoServicio)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_DET>()
                .Property(e => e.ExpMarks)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_DET>()
                .Property(e => e.ExpPartidaArancelaria)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTE_VENTA_DET>()
                .Property(e => e.ExpMedida)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE>()
                .Property(e => e.Correlativo)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE>()
                .Property(e => e.TipoComprobante)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE>()
                .Property(e => e.NombreArhivo)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE>()
                .Property(e => e.SignatureValue)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE>()
                .Property(e => e.DigestValue)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE>()
                .Property(e => e.StateInvoice)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE>()
                .Property(e => e.Trama)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE>()
                .HasMany(e => e.COMPROBANTEVENTA_FILE_RESPONSE)
                .WithRequired(e => e.COMPROBANTEVENTA_FILE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE_RESPONSE>()
                .Property(e => e.ProcessReceptionId)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE_RESPONSE>()
                .Property(e => e.IssueDate)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE_RESPONSE>()
                .Property(e => e.IssueTime)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE_RESPONSE>()
                .Property(e => e.ResponseDate)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE_RESPONSE>()
                .Property(e => e.ResponseTime)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE_RESPONSE>()
                .Property(e => e.ResponseNote)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE_RESPONSE>()
                .Property(e => e.SenderParty_RUC)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE_RESPONSE>()
                .Property(e => e.ReceiverParty_RUC)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE_RESPONSE>()
                .Property(e => e.RecipientParty_RUC)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE_RESPONSE>()
                .Property(e => e.ResponseCode)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE_RESPONSE>()
                .Property(e => e.DocumentSentId)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE_RESPONSE>()
                .Property(e => e.ProcessedDocumentId)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE_RESPONSE>()
                .Property(e => e.ResponseDescription)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE_RESPONSE>()
                .Property(e => e.SignatureValue)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE_RESPONSE>()
                .Property(e => e.DigestValue)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE_RESPONSE>()
                .Property(e => e.ResponseFileName)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE_RESPONSE>()
                .Property(e => e.ResponseTicket)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE_RESPONSE>()
                .Property(e => e.ResponseStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_FILE_RESPONSE>()
                .Property(e => e.Trama)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_PROCESO>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO_COMPRA>()
                .Property(e => e.SerieContrato)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO_COMPRA>()
                .Property(e => e.NumContrato)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO_COMPRA>()
                .Property(e => e.PrecioTabla)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CONTRATO_COMPRA>()
                .Property(e => e.PrecioNuevo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CONTRATO_COMPRA>()
                .Property(e => e.IdCertificadoVSP)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO_COMPRA>()
                .Property(e => e.DescCertificacion)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO_COMPRA>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO_COMPRA>()
                .Property(e => e.ObservacionInterna)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO_COMPRA>()
                .Property(e => e.ReferenciaAgente)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO_COMPRA>()
                .Property(e => e.InstruccionMuestra)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO_COMPRA>()
                .Property(e => e.IdTipoFijador)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO_COMPRA>()
                .Property(e => e.UnfxTipoFijador)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO_COMPRA>()
                .Property(e => e.GiExcel)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO_COMPRA>()
                .HasMany(e => e.CONTRATO_COMPRA_SWITCH)
                .WithRequired(e => e.CONTRATO_COMPRA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTRATO_COMPRA_HISTORICO>()
                .Property(e => e.KgActual)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CONTRATO_COMPRA_HISTORICO>()
                .Property(e => e.KgEditado)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CONTRATO_COMPRA_ZONA>()
                .Property(e => e.IdContratoCompra)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO_COMPRA_ZONA>()
                .Property(e => e.TC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CONTRATO_COMPRA_ZONA>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO_COMPRA_ZONA>()
                .Property(e => e.IdCertificacion)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO_COMPRA_ZONA>()
                .Property(e => e.Certificacion)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO_COMPRA_ZONA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO_COMPRA_ZONA>()
                .Property(e => e.UsuarioModifica)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO_COMPRA_ZONA>()
                .Property(e => e.PrecioOut)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CONTRATO_COMPRA_ZONA>()
                .Property(e => e.PrecioVigenteUnfix)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CONTRATO_COMPRA_ZONA>()
                .Property(e => e.DiferencialUnfix)
                .HasPrecision(18, 3);

            modelBuilder.Entity<CONTRATO_COMPRA_ZONA>()
                .Property(e => e.KgPorSaco)
                .HasPrecision(18, 3);

            modelBuilder.Entity<CONTRATO_COMPRA_ZONA>()
                .Property(e => e.PrecioOutOtorgado)
                .HasPrecision(18, 3);

            modelBuilder.Entity<CONTRATO_COMPRA_ZONA>()
                .HasMany(e => e.CONTRATO_ZONA_OUT)
                .WithRequired(e => e.CONTRATO_COMPRA_ZONA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTRATO_COMPRA_ZONA>()
                .HasMany(e => e.CONTRATO_ZONA_SWITCH)
                .WithRequired(e => e.CONTRATO_COMPRA_ZONA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTRATO_COMPRA_ZONA>()
                .HasMany(e => e.CONTRATO_ZONA_UNFIXED)
                .WithRequired(e => e.CONTRATO_COMPRA_ZONA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTRATO_ZONA_OUT>()
                .Property(e => e.Precio)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CONTRATO_ZONA_OUT>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO_ZONA_OUT>()
                .Property(e => e.UsuarioAprueba)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO_ZONA_SWITCH>()
                .Property(e => e.Diferencial)
                .HasPrecision(18, 3);

            modelBuilder.Entity<CONTRATO_ZONA_SWITCH>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO_ZONA_SWITCH>()
                .Property(e => e.CostoSwitch)
                .HasPrecision(18, 3);

            modelBuilder.Entity<CONTRATO_ZONA_UNFIXED>()
                .Property(e => e.Precio)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CONTRATO_ZONA_UNFIXED>()
                .Property(e => e.Diferencial)
                .HasPrecision(18, 3);

            modelBuilder.Entity<CONTRATO_ZONA_UNFIXED>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<CORREO>()
                .Property(e => e.Modulo)
                .IsUnicode(false);

            modelBuilder.Entity<CORREO>()
                .Property(e => e.Correo1)
                .IsUnicode(false);

            modelBuilder.Entity<CUENTA_BANCO>()
                .Property(e => e.NroCuentaBanco)
                .IsUnicode(false);

            modelBuilder.Entity<CUENTA_BANCO>()
                .Property(e => e.CodigoInterbancario)
                .IsUnicode(false);

            modelBuilder.Entity<CUENTA_BANCO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CUENTA_BANCO>()
                .Property(e => e.IdLocal)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTAMENTO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTAMENTO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTAMENTO>()
                .HasMany(e => e.PROVINCIAs)
                .WithRequired(e => e.DEPARTAMENTO)
                .HasForeignKey(e => e.IdProvincia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOCUMENTO_OPERACION>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTO_OPERACION>()
                .Property(e => e.Resumen)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTO_OPERACION>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTO_OPERACION>()
                .HasMany(e => e.LABORATORIOs)
                .WithRequired(e => e.DOCUMENTO_OPERACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ERRORINVOICE>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<ERRORINVOICE>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ESTADO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ESTADO>()
                .HasMany(e => e.MOTIVO_VISITA)
                .WithRequired(e => e.ESTADO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GASTO_APROBACION>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_APROBACION>()
                .Property(e => e.NroChequeCuentaBanco)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_CENTRO_COSTO>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_CENTRO_COSTO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_CENTRO_COSTO>()
                .Property(e => e.Zona)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_CENTRO_COSTO>()
                .Property(e => e.IdLocal)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_MOVILIDAD_CAB>()
                .Property(e => e.IdLocal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_MOVILIDAD_CAB>()
                .HasMany(e => e.GASTO_APROBACION)
                .WithOptional(e => e.GASTO_MOVILIDAD_CAB)
                .HasForeignKey(e => e.IdGastoMovilidad);

            modelBuilder.Entity<GASTO_MOVILIDAD_DET>()
                .Property(e => e.IdMoneda)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_MOVILIDAD_DET>()
                .Property(e => e.Origen)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_MOVILIDAD_DET>()
                .Property(e => e.Destino)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_MOVILIDAD_DET>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_MOVILIDAD_DET>()
                .Property(e => e.BaseImponible)
                .HasPrecision(18, 3);

            modelBuilder.Entity<GASTO_MOVILIDAD_DET>()
                .Property(e => e.Monto)
                .HasPrecision(18, 3);

            modelBuilder.Entity<GASTO_MOVILIDAD_DET>()
                .Property(e => e.Exceso)
                .HasPrecision(18, 3);

            modelBuilder.Entity<GASTO_PRP_CAB>()
                .Property(e => e.IdLocal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_PRP_CAB>()
                .Property(e => e.IdMoneda)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_PRP_CAB>()
                .Property(e => e.Monto)
                .HasPrecision(18, 3);

            modelBuilder.Entity<GASTO_PRP_CAB>()
                .Property(e => e.PendienteRendir)
                .HasPrecision(18, 3);

            modelBuilder.Entity<GASTO_PRP_CAB>()
                .Property(e => e.Motivo)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_PRP_CAB>()
                .Property(e => e.Vuelto)
                .HasPrecision(18, 3);

            modelBuilder.Entity<GASTO_PRP_DET>()
                .Property(e => e.DocumentoSerie)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_PRP_DET>()
                .Property(e => e.DocumentoNumero)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_PRP_DET>()
                .Property(e => e.RUC)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_PRP_DET>()
                .Property(e => e.Proveedor)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_PRP_DET>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_PRP_DET>()
                .Property(e => e.IdMoneda)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_PRP_DET>()
                .Property(e => e.BaseImponible)
                .HasPrecision(18, 3);

            modelBuilder.Entity<GASTO_PRP_DET>()
                .Property(e => e.ImpuestoIGV)
                .HasPrecision(18, 3);

            modelBuilder.Entity<GASTO_PRP_DET>()
                .Property(e => e.Inafectos)
                .HasPrecision(18, 3);

            modelBuilder.Entity<GASTO_PRP_DET>()
                .Property(e => e.MontoRedondeo)
                .HasPrecision(18, 3);

            modelBuilder.Entity<GASTO_PRP_DET>()
                .Property(e => e.MontoTotal)
                .HasPrecision(18, 3);

            modelBuilder.Entity<GASTO_RECIBO_MOVILIDAD>()
                .Property(e => e.IdLocal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_RECIBO_MOVILIDAD>()
                .Property(e => e.IdCodigoInternoRM)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_RECIBO_MOVILIDAD>()
                .Property(e => e.DocumentoSerieRM)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_RECIBO_MOVILIDAD>()
                .Property(e => e.DocumentoNumeroRM)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_RECIBO_MOVILIDAD>()
                .Property(e => e.RUCRM)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_RECIBO_MOVILIDAD>()
                .Property(e => e.ProveedorRM)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_RECIBO_MOVILIDAD>()
                .Property(e => e.DescripcionRM)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_RECIBO_MOVILIDAD>()
                .Property(e => e.IdMonedaRM)
                .IsUnicode(false);

            modelBuilder.Entity<GASTO_RECIBO_MOVILIDAD>()
                .Property(e => e.BaseImponibleRM)
                .HasPrecision(18, 3);

            modelBuilder.Entity<GASTO_RECIBO_MOVILIDAD>()
                .Property(e => e.ImpuestoIGVRM)
                .HasPrecision(18, 3);

            modelBuilder.Entity<GASTO_RECIBO_MOVILIDAD>()
                .Property(e => e.InafectosRM)
                .HasPrecision(18, 3);

            modelBuilder.Entity<GASTO_RECIBO_MOVILIDAD>()
                .Property(e => e.MontoRedondeoRM)
                .HasPrecision(18, 3);

            modelBuilder.Entity<GASTO_RECIBO_MOVILIDAD>()
                .Property(e => e.MontoTotalRM)
                .HasPrecision(18, 3);

            modelBuilder.Entity<GUIA_INGRESO_CAB>()
                .Property(e => e.IdLocal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GUIA_INGRESO_CAB>()
                .Property(e => e.RumaDestino)
                .IsUnicode(false);

            modelBuilder.Entity<GUIA_INGRESO_CAB>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<GUIA_INGRESO_CAB>()
                .Property(e => e.UsuarioModifica)
                .IsUnicode(false);

            modelBuilder.Entity<GUIA_INGRESO_CAB>()
                .Property(e => e.IdCertificadoVSP)
                .IsUnicode(false);

            modelBuilder.Entity<GUIA_INGRESO_CAB>()
                .Property(e => e.DescCertificacion)
                .IsUnicode(false);

            modelBuilder.Entity<GUIA_INGRESO_CAB>()
                .Property(e => e.ModalidadIngreso)
                .IsUnicode(false);

            modelBuilder.Entity<GUIA_INGRESO_CAB>()
                .Property(e => e.GuiaRemisionExterna)
                .IsUnicode(false);

            modelBuilder.Entity<GUIA_INGRESO_CAB>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<GUIA_INGRESO_CAB>()
                .HasMany(e => e.GUIA_INGRESO_DET)
                .WithRequired(e => e.GUIA_INGRESO_CAB)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GUIA_INGRESO_CAB>()
                .HasMany(e => e.SERVICIO_PRP_RESULTADO)
                .WithOptional(e => e.GUIA_INGRESO_CAB)
                .HasForeignKey(e => e.IdGuiaIngreso);

            modelBuilder.Entity<GUIA_INGRESO_SALDO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<IDIOMA>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<IDIOMA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<LABORATORIO>()
                .Property(e => e.IdLocal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LABORATORIO>()
                .Property(e => e.FormatoAnalisis)
                .IsUnicode(false);

            modelBuilder.Entity<LABORATORIO>()
                .Property(e => e.Calidad)
                .IsUnicode(false);

            modelBuilder.Entity<LABORATORIO>()
                .Property(e => e.APAcidez)
                .IsUnicode(false);

            modelBuilder.Entity<LABORATORIO>()
                .Property(e => e.APCuerpo)
                .IsUnicode(false);

            modelBuilder.Entity<LABORATORIO>()
                .Property(e => e.APCalidad)
                .IsUnicode(false);

            modelBuilder.Entity<LABORATORIO>()
                .Property(e => e.AORuma)
                .IsUnicode(false);

            modelBuilder.Entity<LABORATORIO>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<LABORATORIO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<LABORATORIO>()
                .Property(e => e.UsuarioModifica)
                .IsUnicode(false);

            modelBuilder.Entity<LABORATORIO>()
                .Property(e => e.PorcTamoCascara)
                .HasPrecision(18, 3);

            modelBuilder.Entity<LABORATORIO>()
                .Property(e => e.PorcDescarte)
                .HasPrecision(18, 3);

            modelBuilder.Entity<LABORATORIO>()
                .HasMany(e => e.LABORATORIO_DEFECTO)
                .WithRequired(e => e.LABORATORIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LIQUIDACION_COMPRA_CAB>()
                .Property(e => e.TipoLiquidacion)
                .IsUnicode(false);

            modelBuilder.Entity<LIQUIDACION_COMPRA_CAB>()
                .Property(e => e.IdGuiaIngreso)
                .IsUnicode(false);

            modelBuilder.Entity<LIQUIDACION_COMPRA_CAB>()
                .Property(e => e.DescGuiaIngreso)
                .IsUnicode(false);

            modelBuilder.Entity<LIQUIDACION_COMPRA_CAB>()
                .Property(e => e.IdContratoCompra)
                .IsUnicode(false);

            modelBuilder.Entity<LIQUIDACION_COMPRA_CAB>()
                .Property(e => e.DescContratoCompra)
                .IsUnicode(false);

            modelBuilder.Entity<LIQUIDACION_COMPRA_CAB>()
                .Property(e => e.Precio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<LIQUIDACION_COMPRA_CAB>()
                .Property(e => e.UsuarioRegistra)
                .IsUnicode(false);

            modelBuilder.Entity<LIQUIDACION_COMPRA_CAB>()
                .Property(e => e.UsuarioModifica)
                .IsUnicode(false);

            modelBuilder.Entity<LIQUIDACION_COMPRA_CAB>()
                .Property(e => e.FacturaSerie)
                .IsUnicode(false);

            modelBuilder.Entity<LIQUIDACION_COMPRA_CAB>()
                .Property(e => e.FacturaNumero)
                .IsUnicode(false);

            modelBuilder.Entity<LIQUIDACION_COMPRA_CAB>()
                .Property(e => e.FacturaFecha)
                .IsUnicode(false);

            modelBuilder.Entity<LIQUIDACION_COMPRA_CAB>()
                .Property(e => e.SerieDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<LIQUIDACION_COMPRA_CAB>()
                .Property(e => e.NroDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<LIQUIDACION_COMPRA_CAB>()
                .Property(e => e.UsuarioAsignacionPrecio)
                .IsUnicode(false);

            modelBuilder.Entity<LIQUIDACION_COMPRA_CAB>()
                .HasMany(e => e.LIQUIDACION_COMPRA_DET)
                .WithRequired(e => e.LIQUIDACION_COMPRA_CAB)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LIQUIDACION_COMPRA_DET>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<LIQUIDACION_COMPRA_SALDO>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<MOTIVO_VISITA>()
                .Property(e => e.DescripcionVisita)
                .IsUnicode(false);

            modelBuilder.Entity<ODCS_PROVEEDOR>()
                .Property(e => e.vcDocIdentidad)
                .IsUnicode(false);

            modelBuilder.Entity<ODCS_PROVEEDOR>()
                .Property(e => e.vcNombreComercial)
                .IsUnicode(false);

            modelBuilder.Entity<ODCS_PROVEEDOR>()
                .Property(e => e.vcRazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<ODCS_PROVEEDOR>()
                .Property(e => e.vcNombreCliente)
                .IsUnicode(false);

            modelBuilder.Entity<ODCS_PROVEEDOR>()
                .Property(e => e.vcApellidoCliente)
                .IsUnicode(false);

            modelBuilder.Entity<ODCS_PROVEEDOR>()
                .Property(e => e.vcTelefonoPrincipal)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_SALDO_INICIAL>()
                .Property(e => e.IdTipoIngreso)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_SALDO_INICIAL>()
                .Property(e => e.DocumentoReferencia)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_SALDO_INICIAL>()
                .Property(e => e.Monto)
                .HasPrecision(18, 3);

            modelBuilder.Entity<OTORGADO_SALDO_INICIAL>()
                .Property(e => e.TC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OTORGADO_SALDO_INICIAL>()
                .Property(e => e.MontoPagar)
                .HasPrecision(18, 3);

            modelBuilder.Entity<OTORGADO_SALDO_INICIAL>()
                .Property(e => e.NroOperacion)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_SALDO_INICIAL>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_SALDO_INICIAL>()
                .Property(e => e.DescCuentaBancaria)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_SALDO_INICIAL>()
                .Property(e => e.IdAprobacion)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_SALDO_INICIAL>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_SALDO_INICIAL>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_SALDO_INICIAL>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_SALDO_INICIAL>()
                .Property(e => e.UsuarioModifica)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_ZONA>()
                .Property(e => e.IdTipoIngreso)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_ZONA>()
                .Property(e => e.DocumentoReferencia)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_ZONA>()
                .Property(e => e.Monto)
                .HasPrecision(18, 3);

            modelBuilder.Entity<OTORGADO_ZONA>()
                .Property(e => e.TC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OTORGADO_ZONA>()
                .Property(e => e.MontoPagar)
                .HasPrecision(18, 3);

            modelBuilder.Entity<OTORGADO_ZONA>()
                .Property(e => e.NroOperacion)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_ZONA>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_ZONA>()
                .Property(e => e.DescCuentaBancaria)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_ZONA>()
                .Property(e => e.IdAprobacion)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_ZONA>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_ZONA>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_ZONA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_ZONA>()
                .Property(e => e.UsuarioModifica)
                .IsUnicode(false);

            modelBuilder.Entity<PRECIO_BOLSA>()
                .Property(e => e.PrecioInicio)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PRECIO_BOLSA>()
                .Property(e => e.PrecioBajo)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PRECIO_BOLSA>()
                .Property(e => e.PrecioAlto)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PRECIO_BOLSA>()
                .Property(e => e.PrecioCierre)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PRECIO_BOLSA>()
                .Property(e => e.PrecioVolumen)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PRECIO_DIA>()
                .Property(e => e.Precio)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PRECIO_DIA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<PROVINCIA>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<PROVINCIA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<REGION>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<REGION>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<REGION>()
                .HasMany(e => e.CLIENTE_GARANTIA)
                .WithRequired(e => e.REGION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE>()
                .Property(e => e.CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE>()
                .Property(e => e.OPERACION)
                .IsUnicode(false);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE>()
                .Property(e => e.TIPOCAFE)
                .IsUnicode(false);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE>()
                .Property(e => e.KGCONTRATO)
                .HasPrecision(18, 3);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE>()
                .Property(e => e.KGLIQUIDADO)
                .HasPrecision(18, 3);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE>()
                .Property(e => e.PRECIO_SOLES)
                .HasPrecision(18, 3);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE>()
                .Property(e => e.PRECIO_DOLARES)
                .HasPrecision(18, 3);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE_DETALLE>()
                .Property(e => e.OPERACION)
                .IsUnicode(false);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE_DETALLE>()
                .Property(e => e.TIPOCAFE)
                .IsUnicode(false);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE_DETALLE>()
                .Property(e => e.KGCONTRATO)
                .HasPrecision(18, 3);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE_DETALLE>()
                .Property(e => e.KGLIQUIDADO)
                .HasPrecision(18, 3);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE_DETALLE>()
                .Property(e => e.PRECIO_SOLES)
                .HasPrecision(18, 3);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE_DETALLE>()
                .Property(e => e.PRECIO_DOLARES)
                .HasPrecision(18, 3);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE_DETALLE_TEMP>()
                .Property(e => e.OPERACION)
                .IsUnicode(false);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE_DETALLE_TEMP>()
                .Property(e => e.TIPOCAFE)
                .IsUnicode(false);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE_DETALLE_TEMP>()
                .Property(e => e.KGCONTRATO)
                .HasPrecision(18, 3);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE_DETALLE_TEMP>()
                .Property(e => e.KGLIQUIDADO)
                .HasPrecision(18, 3);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE_DETALLE_TEMP>()
                .Property(e => e.PRECIO_SOLES)
                .HasPrecision(18, 3);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE_DETALLE_TEMP>()
                .Property(e => e.PRECIO_DOLARES)
                .HasPrecision(18, 3);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE_TEMP>()
                .Property(e => e.CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE_TEMP>()
                .Property(e => e.OPERACION)
                .IsUnicode(false);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE_TEMP>()
                .Property(e => e.TIPOCAFE)
                .IsUnicode(false);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE_TEMP>()
                .Property(e => e.KGCONTRATO)
                .HasPrecision(18, 3);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE_TEMP>()
                .Property(e => e.KGLIQUIDADO)
                .HasPrecision(18, 3);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE_TEMP>()
                .Property(e => e.PRECIO_SOLES)
                .HasPrecision(18, 3);

            modelBuilder.Entity<RESUMEN_COMPRA_CLIENTE_TEMP>()
                .Property(e => e.PRECIO_DOLARES)
                .HasPrecision(18, 3);

            modelBuilder.Entity<SERVICIO_PRP_CABECERA>()
                .Property(e => e.IdLocal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIO_PRP_CABECERA>()
                .Property(e => e.IdTipoServicio)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIO_PRP_CABECERA>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIO_PRP_CABECERA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIO_PRP_CABECERA>()
                .Property(e => e.UsuarioFinProceso)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIO_PRP_CABECERA>()
                .Property(e => e.UsuarioModifica)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIO_PRP_CABECERA>()
                .Property(e => e.TipoServicioDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIO_PRP_CABECERA>()
                .HasMany(e => e.SERVICIO_PRP_DETALLE)
                .WithRequired(e => e.SERVICIO_PRP_CABECERA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SERVICIO_PRP_CABECERA>()
                .HasMany(e => e.SERVICIO_PRP_RESULTADO)
                .WithRequired(e => e.SERVICIO_PRP_CABECERA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SERVICIO_PRP_RESULTADO>()
                .Property(e => e.Certificado)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIO_PRP_RESULTADO>()
                .Property(e => e.IdCertificado)
                .IsUnicode(false);

            modelBuilder.Entity<SITUACION_HIPOTECA>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<SITUACION_HIPOTECA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<SITUACION_HIPOTECA>()
                .HasMany(e => e.CLIENTE_GARANTIA)
                .WithRequired(e => e.SITUACION_HIPOTECA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SOLICITUD_VISITA>()
                .Property(e => e.IdSolicitud)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITUD_VISITA>()
                .Property(e => e.RazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITUD_VISITA>()
                .Property(e => e.NombreVisita)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITUD_VISITA>()
                .Property(e => e.ApellidoVisita)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITUD_VISITA>()
                .Property(e => e.NumDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITUD_VISITA>()
                .Property(e => e.NumPlaca)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITUD_VISITA>()
                .Property(e => e.NumTracto)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITUD_VISITA>()
                .Property(e => e.NumContenedor)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITUD_VISITA>()
                .Property(e => e.NombreChofer)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITUD_VISITA>()
                .Property(e => e.ApellidoChofer)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITUD_VISITA>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<TICKET_PESADA>()
                .Property(e => e.IdLocal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TICKET_PESADA>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<TICKET_PESADA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TICKET_PESADA>()
                .Property(e => e.UsuarioModifica)
                .IsUnicode(false);

            modelBuilder.Entity<TICKET_PESADA>()
                .Property(e => e.IdExcel)
                .IsUnicode(false);

            modelBuilder.Entity<TICKET_PESADA>()
                .Property(e => e.GiExcel)
                .IsUnicode(false);

            modelBuilder.Entity<TICKET_PESADA>()
                .Property(e => e.IdGuiaRemision)
                .IsUnicode(false);

            modelBuilder.Entity<TICKET_PESADA>()
                .Property(e => e.GuiaRemision)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_AGENTE>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_AGENTE>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_ARBITRAJE>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_ARBITRAJE>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_BLACKLIST>()
                .Property(e => e.NombreTabla)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CAFE>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CAFE>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CAFE>()
                .HasMany(e => e.CONTRATO_COMPRA_ZONA)
                .WithRequired(e => e.TIPO_CAFE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_CAFE>()
                .HasMany(e => e.LABORATORIOs)
                .WithRequired(e => e.TIPO_CAFE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_CAJA_CHICA_ZONA>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CAJA_CHICA_ZONA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CALIDAD>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CALIDAD>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CALIDAD_LABORATORIO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CALIDAD_LABORATORIO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CALIDAD_PRECIO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CALIDAD_PRECIO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CAMBIO_OPERACION>()
                .Property(e => e.Compra)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TIPO_CAMBIO_OPERACION>()
                .Property(e => e.Venta)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TIPO_CLIENTE>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CLIENTE>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CLIENTE>()
                .HasMany(e => e.CLIENTEs)
                .WithRequired(e => e.TIPO_CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_COMPRA>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_COMPRA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_COMPRA>()
                .HasMany(e => e.CONTRATO_COMPRA)
                .WithRequired(e => e.TIPO_COMPRA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_COMPRA>()
                .HasMany(e => e.CONTRATO_COMPRA_ZONA)
                .WithRequired(e => e.TIPO_COMPRA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_COND_PAGO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_COND_PAGO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CONTROL_BASE>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CONTROL_BASE>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_COSECHA>()
                .Property(e => e.vcCosecha)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_COSECHA>()
                .Property(e => e.vcComentario)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_DEFECTO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_DEFECTO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_DESTINO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_DESTINO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_DIFERENCIAL>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_DIFERENCIAL>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_DIFERENCIAL>()
                .Property(e => e.KgBase)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TIPO_DIFERENCIAL>()
                .HasMany(e => e.CONTRATO_COMPRA)
                .WithOptional(e => e.TIPO_DIFERENCIAL)
                .HasForeignKey(e => e.UnfxTipoDiferencial);

            modelBuilder.Entity<TIPO_DIFERENCIAL>()
                .HasMany(e => e.CONTRATO_COMPRA_ZONA)
                .WithOptional(e => e.TIPO_DIFERENCIAL)
                .HasForeignKey(e => e.IdUnidadPrecio);

            modelBuilder.Entity<TIPO_DOCUMENTO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_DOCUMENTO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_DSA>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_DSA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_ESTADO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_ESTADO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_FIJADOR>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_FIJADOR>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_GARANTIA>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_GARANTIA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_INMUEBLE>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_INMUEBLE>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_INMUEBLE>()
                .HasMany(e => e.CLIENTE_GARANTIA)
                .WithRequired(e => e.TIPO_INMUEBLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_MES_FIJACION>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_MES_FIJACION>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_MODALIDAD_OTORGADO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_MODALIDAD_OTORGADO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_MONEDA>()
                .Property(e => e.DescripcionLarga)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_MONEDA>()
                .Property(e => e.DescripcionCorta)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_MONEDA>()
                .Property(e => e.Simbolo)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_MONEDA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_MONEDA>()
                .HasMany(e => e.CLIENTE_BANCO)
                .WithRequired(e => e.TIPO_MONEDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_MONEDA>()
                .HasMany(e => e.CLIENTE_GARANTIA)
                .WithRequired(e => e.TIPO_MONEDA)
                .HasForeignKey(e => e.IdMoneda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_MONEDA>()
                .HasMany(e => e.CLIENTE_GARANTIA1)
                .WithRequired(e => e.TIPO_MONEDA1)
                .HasForeignKey(e => e.IdMonedaTasacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_MOTIVO_OTORGADO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_MOTIVO_OTORGADO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_ORIGEN>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_ORIGEN>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_PRECIO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_PRECIO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_PRECIO>()
                .HasMany(e => e.CONTRATO_COMPRA_ZONA)
                .WithRequired(e => e.TIPO_PRECIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_REGLAS_PESO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_REGLAS_PESO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_RENDIMIENTO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_RENDIMIENTO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_RUMA>()
                .Property(e => e.IdLocal)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_RUMA>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_RUMA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_SACO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_SACO>()
                .Property(e => e.Valor)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TIPO_SACO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_SACO>()
                .HasMany(e => e.TICKET_PESADA)
                .WithRequired(e => e.TIPO_SACO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_SEGUNDA>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_SEGUNDA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_SERIE_COMPRA>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_SERIE_COMPRA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_SERIE_VENTA>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_SERIE_VENTA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_SERVICIO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_SERVICIO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_TAZA>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_TAZA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_TAZA>()
                .HasMany(e => e.LABORATORIO_DEFECTO)
                .WithRequired(e => e.TIPO_TAZA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_TERMINO_ENTREGA>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_TERMINO_ENTREGA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_TITULO_VALOR>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_TITULO_VALOR>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_TRADER>()
                .Property(e => e.NombreTrader)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_TRADER>()
                .Property(e => e.ApellidoTrader)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_TRADER>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_UNIDAD_MEDIDA>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_UNIDAD_MEDIDA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_UNIDAD_MEDIDA>()
                .HasMany(e => e.CONTRATO_COMPRA)
                .WithRequired(e => e.TIPO_UNIDAD_MEDIDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_VALUACION>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_VALUACION>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_VISITA>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TRABAJADOR_PRP>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TRABAJADOR_PRP>()
                .Property(e => e.DocumentoId)
                .IsUnicode(false);

            modelBuilder.Entity<TRABAJADOR_PRP>()
                .Property(e => e.IdLocal)
                .IsUnicode(false);

            modelBuilder.Entity<TRABAJADOR_PRP>()
                .HasMany(e => e.GASTO_PRP_CAB)
                .WithRequired(e => e.TRABAJADOR_PRP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRASLADO_CHOFER>()
                .Property(e => e.NombreChofer)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CHOFER>()
                .Property(e => e.ApellidoChofer)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CHOFER>()
                .Property(e => e.Vehiculo)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CHOFER>()
                .Property(e => e.NroInscripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CHOFER>()
                .Property(e => e.Licencia)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CHOFER>()
                .Property(e => e.UsuarioBL)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CHOFER>()
                .Property(e => e.DniChofer)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CHOFER>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_DET>()
                .Property(e => e.Lote)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_DET>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_DET>()
                .Property(e => e.Certificado)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_DET>()
                .Property(e => e.IdCertificado)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_EMPRESA>()
                .Property(e => e.IdLocal)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_EMPRESA>()
                .Property(e => e.DocumentoIdentidad)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_EMPRESA>()
                .Property(e => e.RazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_EMPRESA>()
                .Property(e => e.NombreComercial)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_EMPRESA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_EMPRESA>()
                .Property(e => e.UsuarioBL)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_EMPRESA>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_MOTIVO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_MOTIVO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_ZONA>()
                .Property(e => e.IdLocal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_ZONA>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_ZONA>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_ZONA>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_ZONA>()
                .Property(e => e.TipoEnvio)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_ZONA>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<COMPROBANTEVENTA_APROBACION>()
                .Property(e => e.IdLocal)
                .IsUnicode(false);

            modelBuilder.Entity<DISTRITO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<DISTRITO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<GUIA_INGRESO_CAB_BK>()
                .Property(e => e.IdLocal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GUIA_INGRESO_CAB_BK>()
                .Property(e => e.RumaDestino)
                .IsUnicode(false);

            modelBuilder.Entity<GUIA_INGRESO_CAB_BK>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<GUIA_INGRESO_CAB_BK>()
                .Property(e => e.UsuarioModifica)
                .IsUnicode(false);

            modelBuilder.Entity<GUIA_INGRESO_CAB_BK>()
                .Property(e => e.IdCertificadoVSP)
                .IsUnicode(false);

            modelBuilder.Entity<GUIA_INGRESO_CAB_BK>()
                .Property(e => e.DescCertificacion)
                .IsUnicode(false);

            modelBuilder.Entity<GUIA_INGRESO_CAB_BK>()
                .Property(e => e.ModalidadIngreso)
                .IsUnicode(false);

            modelBuilder.Entity<GUIA_INGRESO_CAB_BK>()
                .Property(e => e.GuiaRemisionExterna)
                .IsUnicode(false);

            modelBuilder.Entity<GUIA_INGRESO_SALDO_BK>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<ODCS_PROVEEDOR_BANCO>()
                .Property(e => e.NroCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<ODCS_PROVEEDOR_BANCO>()
                .Property(e => e.NroCuentaInterbancario)
                .IsUnicode(false);

            modelBuilder.Entity<ODCS_PROVEEDOR_BANCO>()
                .Property(e => e.CodigoSwift)
                .IsUnicode(false);

            modelBuilder.Entity<ODCS_PROVEEDOR_BANCO>()
                .Property(e => e.Detraccion)
                .IsUnicode(false);

            modelBuilder.Entity<ODCS_PROVEEDOR_BANCO>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_ZONA_BK>()
                .Property(e => e.IdTipoIngreso)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_ZONA_BK>()
                .Property(e => e.DocumentoReferencia)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_ZONA_BK>()
                .Property(e => e.Monto)
                .HasPrecision(18, 3);

            modelBuilder.Entity<OTORGADO_ZONA_BK>()
                .Property(e => e.TC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OTORGADO_ZONA_BK>()
                .Property(e => e.MontoPagar)
                .HasPrecision(18, 3);

            modelBuilder.Entity<OTORGADO_ZONA_BK>()
                .Property(e => e.NroOperacion)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_ZONA_BK>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_ZONA_BK>()
                .Property(e => e.DescCuentaBancaria)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_ZONA_BK>()
                .Property(e => e.IdAprobacion)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_ZONA_BK>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_ZONA_BK>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_ZONA_BK>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<OTORGADO_ZONA_BK>()
                .Property(e => e.UsuarioModifica)
                .IsUnicode(false);

            modelBuilder.Entity<PARAMETRO>()
                .Property(e => e.TipoParametro)
                .IsUnicode(false);

            modelBuilder.Entity<PARAMETRO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<PARAMETRO>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<PARAMETRO>()
                .Property(e => e.Clave1)
                .IsUnicode(false);

            modelBuilder.Entity<PARAMETRO>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<PARAMETRO>()
                .Property(e => e.Clave2)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIO_PRP_CABECERA_BK>()
                .Property(e => e.IdLocal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIO_PRP_CABECERA_BK>()
                .Property(e => e.IdTipoServicio)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIO_PRP_CABECERA_BK>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIO_PRP_CABECERA_BK>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIO_PRP_CABECERA_BK>()
                .Property(e => e.UsuarioFinProceso)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIO_PRP_CABECERA_BK>()
                .Property(e => e.UsuarioModifica)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIO_PRP_CABECERA_BK>()
                .Property(e => e.TipoServicioDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TICKET_PESADA_BK>()
                .Property(e => e.IdLocal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TICKET_PESADA_BK>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<TICKET_PESADA_BK>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TICKET_PESADA_BK>()
                .Property(e => e.UsuarioModifica)
                .IsUnicode(false);

            modelBuilder.Entity<TICKET_PESADA_BK>()
                .Property(e => e.IdExcel)
                .IsUnicode(false);

            modelBuilder.Entity<TICKET_PESADA_BK>()
                .Property(e => e.GiExcel)
                .IsUnicode(false);

            modelBuilder.Entity<TICKET_PESADA_BK>()
                .Property(e => e.IdGuiaRemision)
                .IsUnicode(false);

            modelBuilder.Entity<TICKET_PESADA_BK>()
                .Property(e => e.GuiaRemision)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CAB>()
                .Property(e => e.IdLocal)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CAB>()
                .Property(e => e.FechaTraslado)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CAB>()
                .Property(e => e.Certificado)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CAB>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CAB>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CAB>()
                .Property(e => e.UsuarioModifica)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CAB>()
                .Property(e => e.IdCertificado)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CAB>()
                .Property(e => e.CostoMinimo)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CAB>()
                .Property(e => e.TipoGuia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CAB>()
                .Property(e => e.Marcas)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CAB>()
                .Property(e => e.Destino)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CAB>()
                .Property(e => e.Contenedor)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CAB>()
                .Property(e => e.Precinto)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CAB>()
                .Property(e => e.NumContrato)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CAB>()
                .Property(e => e.Vapor)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CAB>()
                .Property(e => e.TCon)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TRASLADO_CAB>()
                .Property(e => e.Serie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_CAB>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_DESPACHOCAFE>()
                .Property(e => e.HoraSalida)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_DESPACHOCAFE>()
                .Property(e => e.HoraLlegada)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_DESPACHOCAFE>()
                .Property(e => e.GeoUrl)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_DESPACHOCAFE>()
                .Property(e => e.UsuarioGeo)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_DESPACHOCAFE>()
                .Property(e => e.ContrasenaGeo)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADO_DESPACHOCAFE>()
                .Property(e => e.NroMovilConductor)
                .IsUnicode(false);
        }
    }
}

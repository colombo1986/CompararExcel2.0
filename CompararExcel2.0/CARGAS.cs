//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompararExcel2._0
{
    using System;
    using System.Collections.Generic;
    
    public partial class CARGAS
    {
        public long IdCarga { get; set; }
        public Nullable<long> RUTTITULAR { get; set; }
        public string DVTITULAR { get; set; }
        public string NOMBRETITULAR { get; set; }
        public string AP_TITULAR { get; set; }
        public string AM_TITULAR { get; set; }
        public string TIPOSOCIO { get; set; }
        public string NOMBRECARGA { get; set; }
        public string AP_CARGA { get; set; }
        public string AM_CARGA { get; set; }
        public Nullable<long> RUTCARGA { get; set; }
        public string DVCARGA { get; set; }
        public string FECHAINICIO { get; set; }
        public string FECHATERMINO { get; set; }
        public string FECHANACIMIENTO { get; set; }
        public string ESTADO { get; set; }
        public Nullable<long> IDTITULARFK { get; set; }
    
        public virtual TITULARES TITULARES { get; set; }
    }
}

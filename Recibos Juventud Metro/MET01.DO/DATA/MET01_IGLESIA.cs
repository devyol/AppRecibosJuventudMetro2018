//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MET01.DO.DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class MET01_IGLESIA
    {
        public MET01_IGLESIA()
        {
            this.MET01_RECIBO = new HashSet<MET01_RECIBO>();
            this.MET01_RECIBO_OFICINA = new HashSet<MET01_RECIBO_OFICINA>();
        }
    
        public decimal IGLESIA { get; set; }
        public string NOMBRE { get; set; }
        public Nullable<decimal> REGION { get; set; }
        public Nullable<decimal> ENCARGADO { get; set; }
        public Nullable<decimal> PASTOR { get; set; }
        public string ESTADO_REGISTRO { get; set; }
        public string USUARIO_CREACION { get; set; }
        public Nullable<System.DateTime> FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
    
        public virtual MET01_ENCARGADO MET01_ENCARGADO { get; set; }
        public virtual ICollection<MET01_RECIBO> MET01_RECIBO { get; set; }
        public virtual MET01_PASTOR MET01_PASTOR { get; set; }
        public virtual MET01_REGION MET01_REGION { get; set; }
        public virtual ICollection<MET01_RECIBO_OFICINA> MET01_RECIBO_OFICINA { get; set; }
    }
}

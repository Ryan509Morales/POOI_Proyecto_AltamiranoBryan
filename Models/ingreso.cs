//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POOI_ProyectoVentas_AltamiranoBryan.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ingreso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ingreso()
        {
            this.detalle_ingreso = new HashSet<detalle_ingreso>();
        }
    
        public int idingreso { get; set; }
        public Nullable<int> idproveedor { get; set; }
        public string tipo_comprobante { get; set; }
        public string serie_comprobante { get; set; }
        public string num_comprobante { get; set; }
        public Nullable<System.DateTime> fecha_hora { get; set; }
        public Nullable<decimal> impuesto { get; set; }
        public string estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalle_ingreso> detalle_ingreso { get; set; }
        public virtual persona persona { get; set; }
    }
}

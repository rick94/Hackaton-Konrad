//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace Kima
{
    using System;
    using System.Collections.Generic;

    public partial class Enfermedad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Enfermedad()
        {
            this.Medicinas = new HashSet<Medicinas>();
            this.Eventoes = new HashSet<Evento>();
        }

        public int Id { get; set; }
        [Display(Name = "Nombre completo")]
        public string nombre { get; set; }
        [Display(Name = "Fecha de diágnostico")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> fecha_diagnostico { get; set; }
        [Display(Name = "Último evento de la enfermedad")]
        public Nullable<System.DateTime> ultimo_evento { get; set; }
        [Display(Name = "Tipo de la enfermedad")]
        public string tipo { get; set; }

        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medicinas> Medicinas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evento> Eventoes { get; set; }
    }
}

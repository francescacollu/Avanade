//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace primoEntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Camere
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Camere()
        {
            this.Prenotazioni = new HashSet<Prenotazioni>();
        }
    
        public short numero { get; set; }
        public byte piano { get; set; }
        public string tipo { get; set; }
        public string lettiAggiunti { get; set; }
        public string optionals { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prenotazioni> Prenotazioni { get; set; }
    }
}

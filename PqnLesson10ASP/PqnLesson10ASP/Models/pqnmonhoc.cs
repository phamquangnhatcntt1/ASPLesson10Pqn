//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PqnLesson10ASP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class pqnmonhoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pqnmonhoc()
        {
            this.pqnketqua = new HashSet<pqnketqua>();
        }
    
        public string PqnMaMH { get; set; }
        public string PqnTenMH { get; set; }
        public string Sotiet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pqnketqua> pqnketqua { get; set; }
    }
}
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
    
    public partial class pqnketqua
    {
        public string PqnMaSV { get; set; }
        public string PqnMaMH { get; set; }
        public string Diem { get; set; }
    
        public virtual pqnmonhoc pqnmonhoc { get; set; }
        public virtual pqnsinhvien pqnsinhvien { get; set; }
    }
}

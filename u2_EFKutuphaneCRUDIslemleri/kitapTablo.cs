//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace u2_EFKutuphaneCRUDIslemleri
{
    using System;
    using System.Collections.Generic;
    
    public partial class kitapTablo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public kitapTablo()
        {
            this.IslemTabloes = new HashSet<IslemTablo>();
        }
    
        public int kitapno { get; set; }
        public Nullable<int> isbnno { get; set; }
        public string kitapadi { get; set; }
        public Nullable<int> yazarno { get; set; }
        public Nullable<int> turno { get; set; }
        public Nullable<int> sayfasayisi { get; set; }
        public Nullable<int> puan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IslemTablo> IslemTabloes { get; set; }
        public virtual TurTablo TurTablo { get; set; }
        public virtual YazarTablo YazarTablo { get; set; }
    }
}
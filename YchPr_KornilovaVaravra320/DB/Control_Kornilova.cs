//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YchPr_KornilovaVaravra320.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Control_Kornilova
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Control_Kornilova()
        {
            this.COUNTRY_Kornilova = new HashSet<COUNTRY_Kornilova>();
        }
    
        public int ID_c { get; set; }
        public string View_C { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COUNTRY_Kornilova> COUNTRY_Kornilova { get; set; }
    }
}

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
    
    public partial class COUNTRY_Kornilova
    {
        public int ID_coun { get; set; }
        public string Name_coun { get; set; }
        public string City_coun { get; set; }
        public string Continent_coun { get; set; }
        public Nullable<int> Popul_coun { get; set; }
        public Nullable<int> Sq_coun { get; set; }
        public Nullable<int> View_ID_coun { get; set; }
    
        public virtual Control_Kornilova Control_Kornilova { get; set; }
    }
}
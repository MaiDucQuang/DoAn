//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Category
    {
        public tb_Category()
        {
            this.tb_Product = new HashSet<tb_Product>();
        }
    
        public int category_id { get; set; }
        public string category_name { get; set; }
    
        public virtual ICollection<tb_Product> tb_Product { get; set; }
    }
}
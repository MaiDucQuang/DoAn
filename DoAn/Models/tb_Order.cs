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
    
    public partial class tb_Order
    {
        public tb_Order()
        {
            this.tb_OrderDetail = new HashSet<tb_OrderDetail>();
        }
    
        public int order_id { get; set; }
        public Nullable<int> customer_id { get; set; }
        public Nullable<System.DateTime> order_date { get; set; }
        public string status { get; set; }
        public Nullable<decimal> total_price { get; set; }
    
        public virtual tb_Customer tb_Customer { get; set; }
        public virtual ICollection<tb_OrderDetail> tb_OrderDetail { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAcessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesTaxRate
    {
        public int SalesTaxRateID { get; set; }
        public int StateProvinceID { get; set; }
        public byte TaxType { get; set; }
        public decimal TaxRate { get; set; }
        public string Name { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual StateProvince StateProvince { get; set; }
    }
}

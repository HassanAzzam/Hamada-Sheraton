
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Resturant.DAL
{

using System;
    using System.Collections.Generic;
    
public partial class ResAreaCode
{

    public ResAreaCode()
    {

        this.ResCustomers = new HashSet<ResCustomer>();

    }


    public decimal GovId { get; set; }

    public decimal AreaId { get; set; }

    public string AreaNameA { get; set; }

    public string AreaNameE { get; set; }

    public Nullable<decimal> ServiceVal { get; set; }

    public string UserName { get; set; }

    public Nullable<System.DateTime> InsertDt { get; set; }



    public virtual ResGovCode ResGovCode { get; set; }

    public virtual ICollection<ResCustomer> ResCustomers { get; set; }

}

}


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
    
public partial class ResInstructionCode
{

    public ResInstructionCode()
    {

        this.ResOrderDtls = new HashSet<ResOrderDtl>();

    }


    public decimal InstructionId { get; set; }

    public string InstructionNameA { get; set; }

    public string InstructionNameE { get; set; }



    public virtual ICollection<ResOrderDtl> ResOrderDtls { get; set; }

}

}

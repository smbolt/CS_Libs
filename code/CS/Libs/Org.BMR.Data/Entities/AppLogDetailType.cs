//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Org.GS;
using Org.DB;
namespace Org.BMR.Data.Entities
{
  using System;
  using System.Collections.Generic;

  [DbMap(DbElement.Table, "Adsdi_Org", "", "AppLogDetailType")]
  public partial class AppLogDetailType
  {
    public AppLogDetailType()
    {
      this.AppLogDetails = new HashSet<AppLogDetail>();
    }

    public string AppLogDetailTypeCode {
      get;
      set;
    }
    public string AppLogDetailTypeDesc {
      get;
      set;
    }

    public virtual ICollection<AppLogDetail> AppLogDetails {
      get;
      set;
    }
  }
}
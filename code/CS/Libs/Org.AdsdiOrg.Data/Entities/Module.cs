//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Org.DB;
using Org.GS;
namespace Org.AdsdiOrg.Data.Entities
{
  using System;
  using System.Collections.Generic;

  [DbMap(DbElement.Table, "Adsdi_Org", "", "Module")]
  public partial class Module
  {
    public Module()
    {
      this.AppLogs = new HashSet<AppLog>();
      this.ConfigItems = new HashSet<ConfigItem>();
    }

    public int ModuleCode {
      get;
      set;
    }
    public string ModuleName {
      get;
      set;
    }

    public virtual ICollection<AppLog> AppLogs {
      get;
      set;
    }
    public virtual ICollection<ConfigItem> ConfigItems {
      get;
      set;
    }
  }
}
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

  [DbMap(DbElement.StoredProcedure, "Adsdi_Org", "", "sp_GetSoftwareUpdatesForModuleVersion_Result")]
  public partial class sp_GetSoftwareUpdatesForModuleVersion_Result
  {
    public int SoftwareModuleCode {
      get;
      set;
    }
    public string SoftwareModuleName {
      get;
      set;
    }
    public int SoftwarePlatformId {
      get;
      set;
    }
    public string SoftwarePlatformString {
      get;
      set;
    }
    public string PlatformDescription {
      get;
      set;
    }
    public int SoftwareVersionId {
      get;
      set;
    }
    public int SoftwareModuleId {
      get;
      set;
    }
    public string SoftwareVersion {
      get;
      set;
    }
    public int RepositoryId {
      get;
      set;
    }
    public string RepositoryRoot {
      get;
      set;
    }
  }
}
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

  [DbMap(DbElement.Table, "Adsdi_Org", "", "AccountTokenStatu")]
  public partial class AccountTokenStatu
  {
    public AccountTokenStatu()
    {
      this.AccountLoginTokens = new HashSet<AccountLoginToken>();
    }

    public int TokenStatusId {
      get;
      set;
    }
    public string TokenStatusAbbr {
      get;
      set;
    }
    public string TokenStatusDesc {
      get;
      set;
    }

    public virtual ICollection<AccountLoginToken> AccountLoginTokens {
      get;
      set;
    }
  }
}
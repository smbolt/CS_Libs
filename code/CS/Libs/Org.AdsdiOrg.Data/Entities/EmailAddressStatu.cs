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

  [DbMap(DbElement.Table, "Adsdi_Org", "", "EmailAddressStatu")]
  public partial class EmailAddressStatu
  {
    public EmailAddressStatu()
    {
      this.PersonEmailAddresses = new HashSet<PersonEmailAddress>();
    }

    public int EmailAddressStatusId {
      get;
      set;
    }
    public string EmailAddressStatusAbbr {
      get;
      set;
    }
    public string EmailAddressStatusDesc {
      get;
      set;
    }

    public virtual ICollection<PersonEmailAddress> PersonEmailAddresses {
      get;
      set;
    }
  }
}
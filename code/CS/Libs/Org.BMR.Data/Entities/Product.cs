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

  [DbMap(DbElement.Table, "Adsdi_Org", "", "Product")]
  public partial class Product
  {
    public Product()
    {
      this.OrderDetails = new HashSet<OrderDetail>();
      this.Services = new HashSet<Service>();
    }

    public int ProductId {
      get;
      set;
    }
    public string ProductCategoryCode {
      get;
      set;
    }
    public string ProductDescription {
      get;
      set;
    }
    public int StatusId {
      get;
      set;
    }
    public decimal Price {
      get;
      set;
    }
    public decimal Cost {
      get;
      set;
    }

    public virtual ICollection<OrderDetail> OrderDetails {
      get;
      set;
    }
    public virtual ProductCategory ProductCategory {
      get;
      set;
    }
    public virtual Status Status {
      get;
      set;
    }
    public virtual ICollection<Service> Services {
      get;
      set;
    }
  }
}
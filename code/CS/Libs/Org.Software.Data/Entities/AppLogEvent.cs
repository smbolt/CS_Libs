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

namespace Org.Software.Data.Entities
{
    using System;
    using System.Collections.Generic;
    
    [DbMap(DbElement.Table, "Org_Software", "", "AppLogEvent")]
    public partial class AppLogEvent
    {
        public AppLogEvent()
        {
            this.AppLogs = new HashSet<AppLog>();
        }
    
        public int EventCode { get; set; }
        public string EventDesc { get; set; }
    
        public virtual ICollection<AppLog> AppLogs { get; set; }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Org.Software.Data.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    using DB = Org.DB;
    using Org.GS;
    
    // BEGINNING OF CLASS TO GENERATE EF CONNECTION STRINGS FROM Org.GS.Configuration.ConfigDbSpec DATA
    // IMPORT THIS CODE BY PLACING THE VALUE "include file="[include file path]" IN THE CONTEXT TEMPLATE
    // BE SURE TO FORMAT THE INCLUDE STATEMENT APPROPRIATELY.
    // SEE THE TOPIC "T4 Include Directive" in MSDN
    // REPLACE THE [include file path] part with fully qualified (rooted) path for this file.
    
    // ADDITIONALLY - SEE THE FOLLOWING WORD DOCUMENTS IN THE Org.GS\Other FOLDER WHICH DOCUMENT OTHER NECESSARY CHANGES TO THE T4 TEMPLATES
    // 1. Modifying EF Context Template.docx - for instructions for a couple simple modifications to the Context Template.
    // 2. Modifying EF Entity Template.docx - for instructions for a couple simple modifications to the Entity Template.
    
    public static class EFHelper
    {
      public static string BuildSqlServerEfConnectionString(string dbServer, string dbName, bool useWindowsAuth, string userId, string password, string efProvider, string efMetadata)
      {
        System.Data.SqlClient.SqlConnectionStringBuilder connStringBuilder = new System.Data.SqlClient.SqlConnectionStringBuilder();
        connStringBuilder.DataSource = dbServer;
        connStringBuilder.InitialCatalog = dbName;
        connStringBuilder.IntegratedSecurity = useWindowsAuth;
        if (!useWindowsAuth)
        {
          connStringBuilder.UserID = userId;
          connStringBuilder.Password = password;
        }
        string sqlConnString = connStringBuilder.ToString();
    
        System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder entityConnStringBuilder = new System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder();
        entityConnStringBuilder.Provider = efProvider;
        entityConnStringBuilder.ProviderConnectionString = sqlConnString;
        entityConnStringBuilder.Metadata = @"res://" + efMetadata + ".csdl|" +
                                            @"res://" + efMetadata + ".ssdl|" +
                                            @"res://" + efMetadata + ".msl";
        string entityConnectionString = entityConnStringBuilder.ToString();
    
        return entityConnectionString;
      }
    }
    
    // END OF CLASS TO GENERATE EF CONNECTION STRINGS FROM Org.GS.Configuration.ConfigDbSpec DATA
    
    [DbMap(DbElement.EntitySet, "", "", "")]
    
    public partial class Org_SoftwareEntities : DbContext
    {
        public Org_SoftwareEntities(string connectionStringName)
            : base(connectionStringName)
    
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AppLog> AppLogs { get; set; }
        public virtual DbSet<AppLogDetail> AppLogDetails { get; set; }
        public virtual DbSet<AppLogDetailType> AppLogDetailTypes { get; set; }
        public virtual DbSet<AppLogEvent> AppLogEvents { get; set; }
        public virtual DbSet<AppLogSeverity> AppLogSeverities { get; set; }
        public virtual DbSet<FrameworkVersion> FrameworkVersions { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<OrgStatu> OrgStatus { get; set; }
        public virtual DbSet<OrgType> OrgTypes { get; set; }
        public virtual DbSet<SoftwareModule> SoftwareModules { get; set; }
        public virtual DbSet<SoftwareModuleType> SoftwareModuleTypes { get; set; }
        public virtual DbSet<SoftwarePlatform> SoftwarePlatforms { get; set; }
        public virtual DbSet<SoftwareRepository> SoftwareRepositories { get; set; }
        public virtual DbSet<SoftwareStatu> SoftwareStatus { get; set; }
        public virtual DbSet<SoftwareVersion> SoftwareVersions { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual ObjectResult<sp_GetModuleVersionForPlatform_Result> sp_GetModuleVersionForPlatform(Nullable<int> moduleCode, string version, string platformString)
        {
            var moduleCodeParameter = moduleCode.HasValue ?
                new ObjectParameter("ModuleCode", moduleCode) :
                new ObjectParameter("ModuleCode", typeof(int));
    
            var versionParameter = version != null ?
                new ObjectParameter("Version", version) :
                new ObjectParameter("Version", typeof(string));
    
            var platformStringParameter = platformString != null ?
                new ObjectParameter("PlatformString", platformString) :
                new ObjectParameter("PlatformString", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetModuleVersionForPlatform_Result>("sp_GetModuleVersionForPlatform", moduleCodeParameter, versionParameter, platformStringParameter);
        }
    
        public virtual ObjectResult<sp_GetSoftwareUpdatesForModuleVersion_Result> sp_GetSoftwareUpdatesForModuleVersion(Nullable<int> moduleCode, string currentVersion)
        {
            var moduleCodeParameter = moduleCode.HasValue ?
                new ObjectParameter("ModuleCode", moduleCode) :
                new ObjectParameter("ModuleCode", typeof(int));
    
            var currentVersionParameter = currentVersion != null ?
                new ObjectParameter("CurrentVersion", currentVersion) :
                new ObjectParameter("CurrentVersion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetSoftwareUpdatesForModuleVersion_Result>("sp_GetSoftwareUpdatesForModuleVersion", moduleCodeParameter, currentVersionParameter);
        }
    }
}

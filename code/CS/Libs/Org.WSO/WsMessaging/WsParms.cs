﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Org.WSO.Transactions;
using Org.GS;
using Org.GS.Configuration;

namespace Org.WSO
{
  public class WsParms
  {
    public MessagingParticipant MessagingParticipant { get; set; }
    public string TransactionName { get; set; }
    public string TransactionVersion { get; set; }
    public ConfigWsSpec ConfigWsSpec { get; set; }
    public ConfigWsSpec ProxyWsSpec { get; set; }
    public bool UseProxy { get; set; }
    public bool TrackPerformance { get; set; }
    public WsHost WsHost { get; set; }

    public int OrgId { get; set; }

    public string DomainName { get; set; }
    public string MachineName { get; set; }
    public int ModuleCode { get; set; }
    public string ModuleName { get; set; }
    public string ModuleVersion { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string AppName { get; set; }
    public string AppVersion { get; set; }
    public int SendTimeoutSeconds { get; set; }
    public int LockDuration { get; set; }
    public ParmSet ParmSet { get; set; }
    public WsCommandSet WsCommandSet { get; set; }

    public WsParms()
    {
      this.MessagingParticipant = MessagingParticipant.NotSet; 
      this.TransactionName = String.Empty;
      this.TransactionVersion = String.Empty;
      this.ConfigWsSpec = null;
      this.ProxyWsSpec = null;
      this.UseProxy = false;
      this.OrgId = -1;
      this.DomainName = String.Empty;
      this.MachineName = String.Empty;
      this.ModuleCode = 0;
      this.ModuleName = String.Empty;
      this.ModuleVersion = String.Empty;
      this.UserName = String.Empty;
      this.Password = String.Empty;
      this.AppName = String.Empty;
      this.AppVersion = String.Empty;
      this.SendTimeoutSeconds = 0;
      this.TrackPerformance = false;
      this.WsHost = null; 
      this.LockDuration = 2000;
      this.ParmSet = new ParmSet();
      this.WsCommandSet = new WsCommandSet();
    } 
  }
}

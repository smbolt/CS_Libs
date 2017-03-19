﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Org.GS;

namespace Org.AX
{
  [ObfuscationAttribute(Exclude = true)]
  public enum ProfileStatus
  {
    NotSet,
    Active,
    Disabled
  }

  [ObfuscationAttribute(Exclude = true)]
  public enum InclusionResult
  {
    IncludedByDefault,
    IncludedFileMatch,
    IncludedByExtension,
    IncludedExtensionExclusionSpec,
    ExcludedByExtension,
    ExcludedBySpec
  }

  [ObfuscationAttribute(Exclude = true, ApplyToMembers = true)]
  [XMap(XType = XType.Element, CollectionElements = "Axion")]
  public class AxProfile : Dictionary<string, Axion>
  {
    [XMap(XType = XType.Element, WrapperElement = "VariableSet", CollectionElements = "Variable", UseKeyValue = true)]
    public VariableSet VariableSet { get; set; }

    [XMap(IsKey = true)]
    public string Name { get; set; }
    public string NameLower { get { return (this.Name.IsNotBlank() ? this.Name.ToLower() : String.Empty); } }

    [XMap(DefaultValue = "Active")]
    public ProfileStatus ProfileStatus { get; set; }

    public DateTime RunDateTime { get; set; }

    public AxProfile()
    {
      this.Name = String.Empty;
      this.RunDateTime = DateTime.Now;
    }

    public AxProfile(string name)
    {
      this.Name = name;
      this.ProfileStatus = ProfileStatus.NotSet;
      this.VariableSet = new VariableSet();
      this.RunDateTime = DateTime.Now;
    }
  }
}

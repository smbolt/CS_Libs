﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Org.GS;

namespace Org.GS
{
  [ObfuscationAttribute(Exclude = true, ApplyToMembers = true)]
  [XMap(XType = XType.Element, WrapperElement="VariableSet", CollectionElements = "Variable", UseKeyValue = true)] 
  public class VariableSet : Dictionary<string, string>
  {
  }
}
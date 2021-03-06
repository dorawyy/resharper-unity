﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by JetBrains ErrorDescriptionGenerator
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.DataFlow;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Daemon;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.DocumentModel;
using JetBrains.ReSharper.Psi.Resolve;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Util;

[assembly: RegisterStaticHighlightingsGroupAttribute("CgErrors", "Cg Errors", true)]

namespace JetBrains.ReSharper.Cg.Daemon.Errors
{
  #region CgSyntaxError

  [StaticSeverityHighlighting(Severity.ERROR, "CgErrors", Languages = "Cg", AttributeId = HighlightingAttributeIds.ERROR_ATTRIBUTE, OverlapResolve = OverlapResolveKind.ERROR, ToolTipFormatString = MESSAGE)]
  public partial class CgSyntaxError : IHighlighting
  {
    protected const string MESSAGE = "{0}";

    public CgSyntaxError(string text, DocumentRange documentRange)
    {
      Text = text;
      DocumentRange = documentRange;
      ToolTip = string.Format(MESSAGE, Text);
    }

    public string Text { get; private set; }
    public DocumentRange DocumentRange { get; private set; }

    public string ToolTip { get; private set; }
    public string ErrorStripeToolTip { get { return ToolTip; } }

    public JetBrains.DocumentModel.DocumentRange CalculateRange()
    {
      return DocumentRange;
    }

    public bool IsValid()
    {
      return DocumentRange.IsValid();
    }
  }

  #endregion
}

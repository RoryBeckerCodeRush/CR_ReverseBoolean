using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.CodeRush.Interop.OLE.Helpers;
using DevExpress.CodeRush.Core;
using DevExpress.CodeRush.StructuralParser;

namespace CR_ReverseBoolean
{
  class RenameExecutedUndoUnit : UndoUnit
  {
    string _DeclarationName;

    public RenameExecutedUndoUnit(string declarationName)
    {
      _DeclarationName = declarationName;
    }

    protected override string Description
    {
      get { return "Rename refactoring executed."; }
    }

    protected override void Execute()
    {
      TextDocument activeDocument = CodeRush.Documents.ActiveTextDocument;
      if (activeDocument == null)
        return;

      ILinkedIdentifier[] activeLinks = CodeRush.LinkedIdentifiers.Find(activeDocument, activeDocument.GetLineRange(CodeRush.Caret.Line));
      if (activeLinks == null || activeLinks.Length == 0)
        return;

      ILinkedIdentifier activeLink = activeLinks[0];
      if (activeLink == null)
        return;

      ILinkedIdentifierList activeLinkList = activeLink.List;
      if (activeLinkList == null)
        return;

      foreach (ILinkedIdentifier link in activeLinkList)
        CodeRush.LinkedIdentifiers.BreakAllLinksInRange(activeDocument, link.Range);

      CodeRush.LinkedIdentifiers.Invalidate(activeDocument);
    }

    protected override UndoUnit ReverseUnit()
    {
      return new RenameExecutedRedoUnit(_DeclarationName);
    }
  }

  class RenameExecutedRedoUnit : UndoUnit
  {
    string _DeclarationName;

    public RenameExecutedRedoUnit(string declarationName)
    {
      _DeclarationName = declarationName;
    }

    protected override string Description
    {
      get { return "Rename refactoring executed."; }
    }

    protected override void Execute()
    {
      Helper.ApplyRenameRefactoring(_DeclarationName);
    }

    protected override UndoUnit ReverseUnit()
    {
      return new RenameExecutedUndoUnit(_DeclarationName);
    }
  }
}

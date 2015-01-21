using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.CodeRush.StructuralParser;
using DevExpress.CodeRush.Core;
using DevExpress.DXCore.Constants;

namespace CR_ReverseBoolean
{
  class Helper
  {
    public static void ApplyRenameRefactoring(string declarationName)
    {
      CodeRush.Source.ParseIfTextChanged();

      // Now, let's move the caret to the declaration and rename...
      IElement declarationAtCaret = CodeRush.Source.GetDeclarationAtCaret(declarationName);
      if (declarationAtCaret != null)
      {
        // TODO: Figure out why sometimes GetDeclarationAtCaret returns null (e.g., works for local variables but not for properties).
        CodeRush.Caret.MoveTo(declarationAtCaret.FirstNameRange.Start);
        RefactoringProviderBase renameRefactoring = CodeRush.Refactoring.Get("Rename");
        CodeRush.SmartTags.UpdateContext();
        if (renameRefactoring != null && renameRefactoring.IsAvailable)
        {
          try
          {
            renameRefactoring.IsNestedProvider = true;
            renameRefactoring.Execute();
          }
          finally
          {
            renameRefactoring.IsNestedProvider = false;
          }
        }
      }
    }
  }
}

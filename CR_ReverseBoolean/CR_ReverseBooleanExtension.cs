using System.ComponentModel.Composition;
using DevExpress.CodeRush.Common;

namespace CR_ReverseBoolean
{
  [Export(typeof(IVsixPluginExtension))]
  public class CR_ReverseBooleanExtension : IVsixPluginExtension { }
}
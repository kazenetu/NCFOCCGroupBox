using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UserControls
{
  public partial class NCFOCCGroupBox : GroupBox
  {
    /// <summary>
    /// Control Font
    /// </summary>
    private Dictionary<Control, Font> ControlFonts = new Dictionary<Control, Font>();

    /// <summary>
    /// Constructor
    /// </summary>
    public NCFOCCGroupBox()
    {
      InitializeComponent();

      // Adding Control Fonts
      AddControlFont(Controls);

      // Adding Control Fonts method
      void AddControlFont(ControlCollection controls)
      {
        foreach (Control control in controls)
        {
          AddControlFont(control.Controls);

          ControlFonts.Add(control, (Font)control.Font.Clone());
        }
      }
    }

    /// <summary>
    /// Control Added Event
    /// </summary>
    /// <param name="e"></param>
    protected override void OnControlAdded(ControlEventArgs e)
    {
      ControlFonts.Add(e.Control, (Font)e.Control.Font.Clone());
      base.OnControlAdded(e);
    }

    /// <summary>
    /// Control Added Event
    /// </summary>
    /// <param name="e"></param>
    protected override void OnControlRemoved(ControlEventArgs e)
    {
      ControlFonts.Remove(e.Control);
      base.OnControlRemoved(e);
    }

    /// <summary>
    /// Font Change Event
    /// </summary>
    /// <param name="e"></param>
    protected override void OnFontChanged(EventArgs e)
    {
      // Call base method
      base.OnFontChanged(e);

      // Set font
      foreach (Control control in ControlFonts.Keys)
      {
        control.Font = (Font)ControlFonts[control].Clone();
      }
    }

  }
}

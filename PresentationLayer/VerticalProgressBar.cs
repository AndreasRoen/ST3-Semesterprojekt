using System;
using System.Windows.Forms;

/// <summary>
/// Source: https://stackoverflow.com/questions/597411/how-do-i-make-a-winforms-progress-bar-move-vertically-in-c
/// We simply extend ProgressBar and set the PBS_VERTICAL flag in Style.
/// </summary>
public class VerticalProgressBar : ProgressBar
{
    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.Style |= 0x04;
            return cp;
        }
    }
}
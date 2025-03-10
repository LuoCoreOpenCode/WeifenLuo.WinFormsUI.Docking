﻿using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using WinFormsCoreDockPanelSuite.Docking;

using static WinFormsCoreDockPanelSuite.Docking.DockPane;
using static WinFormsCoreDockPanelSuite.Docking.DockPanelExtender;

namespace WinFormsCoreDockPanelSuite.ThemeVS2003
{
    internal class VS2003DockPaneSplitterControlFactory : IDockPaneSplitterControlFactory
    {
        public SplitterControlBase CreateSplitterControl(DockPane pane)
        {
            return new VS2005SplitterControl(pane);
        }

        [ToolboxItem(false)]
        internal class VS2005SplitterControl : SplitterControlBase
        {
            public VS2005SplitterControl(DockPane pane) : base(pane)
            {
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                if (DockPane.DockState != DockState.Document)
                    return;

                Graphics g = e.Graphics;
                Rectangle rect = ClientRectangle;
                if (Alignment == DockAlignment.Top || Alignment == DockAlignment.Bottom)
                    g.DrawLine(SystemPens.ControlDark, rect.Left, rect.Bottom - 1, rect.Right, rect.Bottom - 1);
                else if (Alignment == DockAlignment.Left || Alignment == DockAlignment.Right)
                    g.DrawLine(SystemPens.ControlDarkDark, rect.Right - 1, rect.Top, rect.Right - 1, rect.Bottom);
            }
        }
    }
}

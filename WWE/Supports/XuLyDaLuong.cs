using System;
using System.Drawing;
using System.Windows.Forms;

namespace WWE.Supports
{
    public class XuLyDaLuong
    {
        public static void ChangeText(Label lbl, string text, Color forcecolor)
        {
            if (lbl.InvokeRequired)
            {
                lbl.BeginInvoke((Action)(() =>
                {
                    lbl.ForeColor = forcecolor;
                    lbl.Text = text;
                }));
            }
            else
            {
                lbl.ForeColor = forcecolor;
                lbl.Text = text;
            }
        }

        internal static void ChangeText(ToolStripStatusLabel lbl, StatusStrip trip, string text, Color forcecolor)
        {
            if (trip.InvokeRequired)
            {
                trip.BeginInvoke(new Action(() =>
                {
                    lbl.Text = text;
                    lbl.ForeColor = forcecolor;
                }));
            }
            else
            {
                lbl.Text = text;
                lbl.ForeColor = forcecolor;
            }
        }

        internal static void ChangeBackGroundColor(ToolStripStatusLabel lbl, StatusStrip trip, Color color)
        {
            if (trip.InvokeRequired)
            {
                trip.BeginInvoke(new Action(() =>
                {
                    lbl.BackColor = color;
                }));
            }
            else
            {
                lbl.BackColor = color;
            }
        }
    }
}

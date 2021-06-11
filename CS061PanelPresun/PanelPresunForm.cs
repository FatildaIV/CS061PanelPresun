using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS061PanelPresun
{
    public partial class PanelPresunForm : Form
    {
        public PanelPresunForm()
        {
            InitializeComponent();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            //panel1.Parent.MouseMove
            PanelPresunForm_MouseMove(
                sender,
                new MouseEventArgs(
                    e.Button, e.Clicks, e.X + panel1.Left, e.Y + panel1.Top, e.Delta));
            //if (e.Button == MouseButtons.Left)
            //{
            //    //panel1.Location = new Point(Cursor.Position.X + e.X, Cursor.Position.Y + e.Y);
            //    panel1.Left = Cursor.Position.X + e.X;
            //    panel1.Top = Cursor.Position.Y + e.Y;
            //}
        }

        private void PanelPresunForm_MouseMove(object sender, MouseEventArgs e)
        {
            //label1.Text = string.Format("x: {0}, y: {1} ", e.X, e.Y);
            label1.Text = string.Format("{0}, {1}, {2}", e.Location, e.Delta, Cursor.Position);
            if (e.Button == MouseButtons.Left)
            {
                panel1.Top = e.Y;
                panel1.Left = e.X;
            }
        }

    }
}

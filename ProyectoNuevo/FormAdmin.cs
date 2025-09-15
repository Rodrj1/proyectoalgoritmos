using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoNuevo
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                panel2.ClientRectangle,
                Color.DarkSlateGray,
                Color.FloralWhite,
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, panel2.ClientRectangle);
            }
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            ToolStpMenuAdmin.Visible = false;
        }
    }
}

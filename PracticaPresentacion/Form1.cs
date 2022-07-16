using EditorTexto;
using M3GPaint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PracticaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdEditor_Click(object sender, EventArgs e)
        {
            frmEditorTexto oEditortext = new frmEditorTexto();
            oEditortext.Show();
            this.Hide();
        }

        private void cmdPaint_Click(object sender, EventArgs e)
        {
            frmPaint oFrmPaint = new frmPaint();
            oFrmPaint.Show();
            this.Hide();
        }
    }
}

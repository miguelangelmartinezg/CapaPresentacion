using PracticaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorTexto
{
    public partial class frmEditorTexto : Form
    {
        public frmEditorTexto()
        {
            InitializeComponent();
        }

        private void frmEditor_Load(object sender, EventArgs e)
        {

        }

        private void opNuevo_Click(object sender, EventArgs e)
        {
            EditorTexto.Clear();
        }

        private void opAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog oAbrirArchivo = new OpenFileDialog();
            oAbrirArchivo.Filter = "Archivos de Textos (.txt) | *.txt";
            oAbrirArchivo.Title = "Abrir Documento";
            if (oAbrirArchivo.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader documento = new System.IO.StreamReader(oAbrirArchivo.FileName);
                EditorTexto.Text = documento.ReadToEnd();

            }
        }

        private void opGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog oGuardarArchivo = new SaveFileDialog();
            oGuardarArchivo.Filter = "Archivos de Textos (.txt) | *.txt";
            oGuardarArchivo.Title = "Guardar Documento";
            if (oGuardarArchivo.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter documento = new System.IO.StreamWriter(oGuardarArchivo.FileName);
                documento.Write(EditorTexto.Text);
                documento.Close();

            }

        }

        private void opGuardarComo_Click(object sender, EventArgs e)
        {
            SaveFileDialog oGuardarComoArchivo = new SaveFileDialog();
            oGuardarComoArchivo.Filter = "Archivos de Textos (.txt) | *.txt";
            oGuardarComoArchivo.Title = "Guardar Documento Como";
            if (oGuardarComoArchivo.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter documento = new System.IO.StreamWriter(oGuardarComoArchivo.FileName);
                documento.Write(EditorTexto.Text);
                documento.Close();

            }
        }

        private void opSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void opDeshacer_Click(object sender, EventArgs e)
        {
            if (EditorTexto.Text != "")
            {
                EditorTexto.Undo();
            }
        }

        private void opCortar_Click(object sender, EventArgs e)
        {
            EditorTexto.Cut();
        }

        private void opCopiar_Click(object sender, EventArgs e)
        {
            EditorTexto.Copy();
        }

        private void opPegar_Click(object sender, EventArgs e)
        {
            EditorTexto.Paste();
        }

        private void opSeleccionarTodo_Click(object sender, EventArgs e)
        {
            EditorTexto.SelectAll();
        }

        private void frmEditorTexto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 oMenu = new Form1();
            oMenu.Show();
        }
    }
}

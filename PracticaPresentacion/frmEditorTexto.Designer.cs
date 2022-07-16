
namespace EditorTexto
{
    partial class frmEditorTexto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditorTexto));
            this.EditorTexto = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.opNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.opAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.opGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.opGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.opSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.opDeshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.opCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.opCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.opPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.opSeleccionarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditorTexto
            // 
            this.EditorTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorTexto.Location = new System.Drawing.Point(0, 52);
            this.EditorTexto.Name = "EditorTexto";
            this.EditorTexto.Size = new System.Drawing.Size(800, 398);
            this.EditorTexto.TabIndex = 0;
            this.EditorTexto.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.edicionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opNuevo,
            this.opAbrir,
            this.opGuardar,
            this.opGuardarComo,
            this.opSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opDeshacer,
            this.opCortar,
            this.opCopiar,
            this.opPegar,
            this.opSeleccionarTodo});
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(72, 26);
            this.edicionToolStripMenuItem.Text = "Edición";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // opNuevo
            // 
            this.opNuevo.Image = ((System.Drawing.Image)(resources.GetObject("opNuevo.Image")));
            this.opNuevo.Name = "opNuevo";
            this.opNuevo.Size = new System.Drawing.Size(189, 26);
            this.opNuevo.Text = "Nuevo";
            this.opNuevo.Click += new System.EventHandler(this.opNuevo_Click);
            // 
            // opAbrir
            // 
            this.opAbrir.Image = ((System.Drawing.Image)(resources.GetObject("opAbrir.Image")));
            this.opAbrir.Name = "opAbrir";
            this.opAbrir.Size = new System.Drawing.Size(189, 26);
            this.opAbrir.Text = "Abrir";
            this.opAbrir.Click += new System.EventHandler(this.opAbrir_Click);
            // 
            // opGuardar
            // 
            this.opGuardar.Image = ((System.Drawing.Image)(resources.GetObject("opGuardar.Image")));
            this.opGuardar.Name = "opGuardar";
            this.opGuardar.Size = new System.Drawing.Size(189, 26);
            this.opGuardar.Text = "Guardar";
            this.opGuardar.Click += new System.EventHandler(this.opGuardar_Click);
            // 
            // opGuardarComo
            // 
            this.opGuardarComo.Image = ((System.Drawing.Image)(resources.GetObject("opGuardarComo.Image")));
            this.opGuardarComo.Name = "opGuardarComo";
            this.opGuardarComo.Size = new System.Drawing.Size(189, 26);
            this.opGuardarComo.Text = "Guardar Como";
            this.opGuardarComo.Click += new System.EventHandler(this.opGuardarComo_Click);
            // 
            // opSalir
            // 
            this.opSalir.Image = ((System.Drawing.Image)(resources.GetObject("opSalir.Image")));
            this.opSalir.Name = "opSalir";
            this.opSalir.Size = new System.Drawing.Size(189, 26);
            this.opSalir.Text = "Salir";
            this.opSalir.Click += new System.EventHandler(this.opSalir_Click);
            // 
            // opDeshacer
            // 
            this.opDeshacer.Image = ((System.Drawing.Image)(resources.GetObject("opDeshacer.Image")));
            this.opDeshacer.Name = "opDeshacer";
            this.opDeshacer.Size = new System.Drawing.Size(206, 26);
            this.opDeshacer.Text = "Deshacer";
            this.opDeshacer.Click += new System.EventHandler(this.opDeshacer_Click);
            // 
            // opCortar
            // 
            this.opCortar.Image = ((System.Drawing.Image)(resources.GetObject("opCortar.Image")));
            this.opCortar.Name = "opCortar";
            this.opCortar.Size = new System.Drawing.Size(206, 26);
            this.opCortar.Text = "Cortar";
            this.opCortar.Click += new System.EventHandler(this.opCortar_Click);
            // 
            // opCopiar
            // 
            this.opCopiar.Image = ((System.Drawing.Image)(resources.GetObject("opCopiar.Image")));
            this.opCopiar.Name = "opCopiar";
            this.opCopiar.Size = new System.Drawing.Size(206, 26);
            this.opCopiar.Text = "Copiar";
            this.opCopiar.Click += new System.EventHandler(this.opCopiar_Click);
            // 
            // opPegar
            // 
            this.opPegar.Image = ((System.Drawing.Image)(resources.GetObject("opPegar.Image")));
            this.opPegar.Name = "opPegar";
            this.opPegar.Size = new System.Drawing.Size(206, 26);
            this.opPegar.Text = "Pegar";
            this.opPegar.Click += new System.EventHandler(this.opPegar_Click);
            // 
            // opSeleccionarTodo
            // 
            this.opSeleccionarTodo.Image = ((System.Drawing.Image)(resources.GetObject("opSeleccionarTodo.Image")));
            this.opSeleccionarTodo.Name = "opSeleccionarTodo";
            this.opSeleccionarTodo.Size = new System.Drawing.Size(206, 26);
            this.opSeleccionarTodo.Text = "Seleccionar Todo";
            this.opSeleccionarTodo.Click += new System.EventHandler(this.opSeleccionarTodo_Click);
            // 
            // frmEditorTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditorTexto);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEditorTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M3G Eidtor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditorTexto_FormClosing);
            this.Load += new System.EventHandler(this.frmEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox EditorTexto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opNuevo;
        private System.Windows.Forms.ToolStripMenuItem opAbrir;
        private System.Windows.Forms.ToolStripMenuItem opGuardar;
        private System.Windows.Forms.ToolStripMenuItem opGuardarComo;
        private System.Windows.Forms.ToolStripMenuItem opSalir;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opDeshacer;
        private System.Windows.Forms.ToolStripMenuItem opCortar;
        private System.Windows.Forms.ToolStripMenuItem opCopiar;
        private System.Windows.Forms.ToolStripMenuItem opPegar;
        private System.Windows.Forms.ToolStripMenuItem opSeleccionarTodo;
        private System.Windows.Forms.MenuStrip menuStrip2;
    }
}


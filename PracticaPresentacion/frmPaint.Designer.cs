
namespace M3GPaint
{
    partial class frmPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaint));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnPintarColor = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLinea = new System.Windows.Forms.Button();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.btnBorra = new System.Windows.Forms.Button();
            this.btnElipse = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SelectorColores = new System.Windows.Forms.PictureBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnRellono = new System.Windows.Forms.Button();
            this.btnLapiz = new System.Windows.Forms.Button();
            this.Pintar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectorColores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pintar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.SelectorColores);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.btnPintarColor);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 123);
            this.panel1.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Aqua;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Maroon;
            this.btnGuardar.Location = new System.Drawing.Point(1176, 26);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 33);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Aqua;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Maroon;
            this.btnLimpiar.Location = new System.Drawing.Point(1176, 65);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(84, 33);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnPintarColor
            // 
            this.btnPintarColor.BackColor = System.Drawing.Color.White;
            this.btnPintarColor.Location = new System.Drawing.Point(438, 34);
            this.btnPintarColor.Name = "btnPintarColor";
            this.btnPintarColor.Size = new System.Drawing.Size(62, 60);
            this.btnPintarColor.TabIndex = 3;
            this.btnPintarColor.UseVisualStyleBackColor = false;
            this.btnPintarColor.Click += new System.EventHandler(this.btnPintarColor_Click);
            this.btnPintarColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPintarColor_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.btnRellono);
            this.panel3.Controls.Add(this.btnLinea);
            this.panel3.Controls.Add(this.btnLapiz);
            this.panel3.Controls.Add(this.btnRectangulo);
            this.panel3.Controls.Add(this.btnBorra);
            this.panel3.Controls.Add(this.btnElipse);
            this.panel3.Location = new System.Drawing.Point(506, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(649, 100);
            this.panel3.TabIndex = 3;
            // 
            // btnLinea
            // 
            this.btnLinea.BackColor = System.Drawing.Color.Aqua;
            this.btnLinea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLinea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLinea.Image = global::PracticaPresentacion.Properties.Resources.icons8_line_48;
            this.btnLinea.Location = new System.Drawing.Point(554, 10);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(84, 77);
            this.btnLinea.TabIndex = 9;
            this.btnLinea.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLinea.UseVisualStyleBackColor = false;
            this.btnLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.BackColor = System.Drawing.Color.Aqua;
            this.btnRectangulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRectangulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRectangulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRectangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRectangulo.Image = global::PracticaPresentacion.Properties.Resources.icons8_rectangle_48;
            this.btnRectangulo.Location = new System.Drawing.Point(464, 10);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(84, 77);
            this.btnRectangulo.TabIndex = 8;
            this.btnRectangulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRectangulo.UseVisualStyleBackColor = false;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // btnBorra
            // 
            this.btnBorra.BackColor = System.Drawing.Color.Aqua;
            this.btnBorra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBorra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBorra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBorra.Image = global::PracticaPresentacion.Properties.Resources.icons8_eraser_tool_481;
            this.btnBorra.Location = new System.Drawing.Point(284, 10);
            this.btnBorra.Name = "btnBorra";
            this.btnBorra.Size = new System.Drawing.Size(84, 77);
            this.btnBorra.TabIndex = 6;
            this.btnBorra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorra.UseVisualStyleBackColor = false;
            this.btnBorra.Click += new System.EventHandler(this.btnBorra_Click);
            // 
            // btnElipse
            // 
            this.btnElipse.BackColor = System.Drawing.Color.Aqua;
            this.btnElipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnElipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnElipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElipse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnElipse.Image = global::PracticaPresentacion.Properties.Resources.icons8_ellipse_48;
            this.btnElipse.Location = new System.Drawing.Point(374, 10);
            this.btnElipse.Name = "btnElipse";
            this.btnElipse.Size = new System.Drawing.Size(84, 77);
            this.btnElipse.TabIndex = 7;
            this.btnElipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnElipse.UseVisualStyleBackColor = false;
            this.btnElipse.Click += new System.EventHandler(this.btnElipse_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 676);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 32);
            this.panel2.TabIndex = 1;
            // 
            // SelectorColores
            // 
            this.SelectorColores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectorColores.Image = global::PracticaPresentacion.Properties.Resources.color_palette;
            this.SelectorColores.InitialImage = ((System.Drawing.Image)(resources.GetObject("SelectorColores.InitialImage")));
            this.SelectorColores.Location = new System.Drawing.Point(12, 11);
            this.SelectorColores.Name = "SelectorColores";
            this.SelectorColores.Size = new System.Drawing.Size(420, 100);
            this.SelectorColores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SelectorColores.TabIndex = 3;
            this.SelectorColores.TabStop = false;
            this.SelectorColores.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SelectorColores_MouseClick);
            // 
            // btnColor
            // 
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnColor.Image = ((System.Drawing.Image)(resources.GetObject("btnColor.Image")));
            this.btnColor.Location = new System.Drawing.Point(521, 21);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(84, 77);
            this.btnColor.TabIndex = 4;
            this.btnColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnRellono
            // 
            this.btnRellono.BackColor = System.Drawing.Color.Aqua;
            this.btnRellono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRellono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRellono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRellono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRellono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRellono.Image = ((System.Drawing.Image)(resources.GetObject("btnRellono.Image")));
            this.btnRellono.Location = new System.Drawing.Point(104, 10);
            this.btnRellono.Name = "btnRellono";
            this.btnRellono.Size = new System.Drawing.Size(84, 77);
            this.btnRellono.TabIndex = 10;
            this.btnRellono.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRellono.UseVisualStyleBackColor = false;
            this.btnRellono.Click += new System.EventHandler(this.btnRellono_Click);
            // 
            // btnLapiz
            // 
            this.btnLapiz.BackColor = System.Drawing.Color.Aqua;
            this.btnLapiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapiz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLapiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLapiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLapiz.Image = global::PracticaPresentacion.Properties.Resources.icons8_pencil_641;
            this.btnLapiz.Location = new System.Drawing.Point(194, 10);
            this.btnLapiz.Name = "btnLapiz";
            this.btnLapiz.Size = new System.Drawing.Size(84, 77);
            this.btnLapiz.TabIndex = 5;
            this.btnLapiz.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLapiz.UseVisualStyleBackColor = false;
            this.btnLapiz.Click += new System.EventHandler(this.btnLapiz_Click);
            // 
            // Pintar
            // 
            this.Pintar.BackColor = System.Drawing.Color.White;
            this.Pintar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pintar.Location = new System.Drawing.Point(0, 0);
            this.Pintar.Name = "Pintar";
            this.Pintar.Size = new System.Drawing.Size(1300, 708);
            this.Pintar.TabIndex = 2;
            this.Pintar.TabStop = false;
            this.Pintar.Paint += new System.Windows.Forms.PaintEventHandler(this.Pintar_Paint);
            this.Pintar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pintar_MouseClick);
            this.Pintar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pintar_MouseDown);
            this.Pintar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pintar_MouseMove);
            this.Pintar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pintar_MouseUp);
            // 
            // frmPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 708);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pintar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPaint_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectorColores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pintar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Pintar;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnPintarColor;
        private System.Windows.Forms.Button btnRellono;
        private System.Windows.Forms.Button btnLinea;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnElipse;
        private System.Windows.Forms.Button btnBorra;
        private System.Windows.Forms.Button btnLapiz;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox SelectorColores;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}


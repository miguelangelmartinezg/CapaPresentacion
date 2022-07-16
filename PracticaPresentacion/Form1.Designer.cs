
namespace PracticaPresentacion
{
    partial class Form1
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
            this.cmdEditor = new System.Windows.Forms.Button();
            this.cmdPaint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdEditor
            // 
            this.cmdEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEditor.ForeColor = System.Drawing.Color.Maroon;
            this.cmdEditor.Location = new System.Drawing.Point(12, 212);
            this.cmdEditor.Name = "cmdEditor";
            this.cmdEditor.Size = new System.Drawing.Size(369, 62);
            this.cmdEditor.TabIndex = 0;
            this.cmdEditor.Text = "M3G EDITOR";
            this.cmdEditor.UseVisualStyleBackColor = true;
            this.cmdEditor.Click += new System.EventHandler(this.cmdEditor_Click);
            // 
            // cmdPaint
            // 
            this.cmdPaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPaint.ForeColor = System.Drawing.Color.Maroon;
            this.cmdPaint.Location = new System.Drawing.Point(12, 280);
            this.cmdPaint.Name = "cmdPaint";
            this.cmdPaint.Size = new System.Drawing.Size(369, 62);
            this.cmdPaint.TabIndex = 1;
            this.cmdPaint.Text = "M3G PAINT";
            this.cmdPaint.UseVisualStyleBackColor = true;
            this.cmdPaint.Click += new System.EventHandler(this.cmdPaint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(6, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Favor Escoger una Opción";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdPaint);
            this.Controls.Add(this.cmdEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdEditor;
        private System.Windows.Forms.Button cmdPaint;
        private System.Windows.Forms.Label label1;
    }
}


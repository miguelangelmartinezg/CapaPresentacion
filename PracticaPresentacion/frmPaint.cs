using PracticaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3GPaint
{
    public partial class frmPaint : Form
    {
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen Lapiz = new Pen(Color.Black, 1);
        Pen Borrador = new Pen(Color.White, 10);
        int nIndex;
        int x, y, sX, sY, cX, cY;
        ColorDialog CD = new ColorDialog();
        Color New_Color;


      

        public frmPaint()
        {
            InitializeComponent();

            this.Width = 980;
            this.Height = 700;
            bm = new Bitmap(Pintar.Width, Pintar.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            Pintar.Image = bm;
        }

      
        private void Pintar_MouseDown(object sender, MouseEventArgs e)
        {

            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void Pintar_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (nIndex == 1)
                {
                    px = e.Location;
                    g.DrawLine(Lapiz, px, py);
                    py = px;
                }
                if (nIndex == 2)
                {
                    px = e.Location;
                    g.DrawLine(Borrador, px, py);
                    py = px;
                }
            }
            Pintar.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

      

        private void Pintar_MouseUp(object sender, MouseEventArgs e)
        {

            paint = false;

            sX = x - cX;
            sY = y - cY;

            if (nIndex == 3)
            {
                g.DrawEllipse(Lapiz, cX, cY, sX, sY);
            }
            if (nIndex == 4)
            {
                g.DrawRectangle(Lapiz, cX, cY, sX, sY);
            }
            if (nIndex == 5)
            {
                g.DrawLine(Lapiz, cX, cY, x, y);
            }

        }
        private void Pintar_MouseClick(object sender, MouseEventArgs e)
        {
            if (nIndex == 7)
            {
                Point punto = setPunto(Pintar, e.Location);
                Rellenar(bm, punto.X, punto.Y, New_Color);
            }
        }


        private void btnLapiz_Click(object sender, EventArgs e)
        {
            nIndex = 1;
        }

       

        private void btnBorra_Click(object sender, EventArgs e)
        {
            nIndex = 2;
        }

      
        private void btnElipse_Click(object sender, EventArgs e)
        {
            nIndex = 3;
        }

      

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            nIndex = 4;
        }

      

        private void btnLinea_Click(object sender, EventArgs e)
        {
            nIndex = 5;
        }

       

        private void Pintar_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            if (paint)
            {
                if (nIndex == 3)
                {
                    g.DrawEllipse(Lapiz, cX, cY, sX, sY);
                }
                if (nIndex == 4)
                {
                    g.DrawRectangle(Lapiz, cX, cY, sX, sY);
                }
                if (nIndex == 5)
                {
                    g.DrawLine(Lapiz, cX, cY, x, y);
                }
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Pintar.Image = bm;
            nIndex = 0;
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            CD.ShowDialog();
            New_Color = CD.Color;
            btnPintarColor.BackColor = CD.Color;
            Lapiz.Color = CD.Color;
        }

        private void btnRellono_Click(object sender, EventArgs e)
        {
            nIndex = 7;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var Guardar = new SaveFileDialog();
            Guardar.Filter = "Image(*.jpg) | *.jpg |(*.* | *.*";
            if (Guardar.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, Pintar.Width, Pintar.Height), bm.PixelFormat);
                btm.Save(Guardar.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Imagen Guardada Satisfactoriamente.");
            }
        }

        private void frmPaint_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 oMenu = new Form1();
            oMenu.Show();
           // this.Close();
        }

        private void btnPintarColor_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        private void SelectorColores_MouseClick(object sender, MouseEventArgs e)
        {
            Point punto = setPunto(SelectorColores, e.Location);
            btnPintarColor.BackColor = ((Bitmap)SelectorColores.Image).GetPixel(punto.X, punto.Y);
            New_Color = btnPintarColor.BackColor;
            Lapiz.Color = btnPintarColor.BackColor;

        }
        private void btnPintarColor_Click(object sender, EventArgs e)
        {
            
        }
        static Point setPunto(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }
        private void Validar(Bitmap bm,Stack<Point> sp,int x,int y,Color OldColor, Color newColor)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == OldColor)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, newColor);
            }
        }
        public void Rellenar(Bitmap bm,int x, int y,Color ColorNuevo)
        {
            Color oldColor = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, ColorNuevo);
            if (oldColor == ColorNuevo) return;

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width -1 && pt.Y < bm.Height -1)
                {
                    Validar(bm, pixel, pt.X - 1, pt.Y, oldColor, ColorNuevo);
                    Validar(bm, pixel, pt.X, pt.Y - 1, oldColor, ColorNuevo);
                    Validar(bm, pixel, pt.X + 1, pt.Y, oldColor, ColorNuevo);
                    Validar(bm, pixel, pt.X, pt.Y + 1, oldColor, ColorNuevo);
                }
            }
        }
    }
}

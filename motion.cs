using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulare_miscare_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Drawing.Graphics Desen;
        System.Drawing.Pen Creion_a, Creion_r, Creion_gr;
        System.Drawing.SolidBrush Brush_Red;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Desen.Clear(BackColor);
            // Contur
            Desen.DrawRectangle(Creion_a, x0 - 1, y0 - 1, w, h);
            //Grid
            for (i = 0; i <= nc; i++) {
                Desen.DrawLine(Creion_gr, x0 + i * lp, y0, x0 + i * lp, y0 + h);
            }
            for (i = 0; i <= nl; i++) {
                Desen.DrawLine(Creion_gr, x0, y0 + i * lp, x0 + w, y0 + i * lp);
            }
            // Cerc
            Desen.FillEllipse(Brush_Red, x0 + this.trackBar1.Value, y0 + h - lp - this.trackBar2.Value, lp, lp);

        
        }

        int i, x0, y0, w, h, nc, lp, nl;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            x0 = 130;
            y0 = 20;
            w = 500;
            h = 300;
            i = 0;
            nc = 20; // numarul de coloane
            lp = w / nc;// latimea unui patratel
            nl = h / lp;// numarul de linii  
            Desen = this.CreateGraphics();
            Creion_a = new System.Drawing.Pen(System.Drawing.Color.Blue);
            Creion_r = new System.Drawing.Pen(System.Drawing.Color.Red);
            Creion_gr = new System.Drawing.Pen(System.Drawing.Color.LightGray);
            Brush_Red = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            this.trackBar1.Maximum = w - lp;
            this.trackBar2.Maximum = h - lp;
        }

    }
}

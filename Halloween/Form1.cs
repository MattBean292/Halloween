using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Halloween
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(796, 489);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int move = 0;
            int size = 1;
            SoundPlayer player = new SoundPlayer(Properties.Resources.Metronome_SoundBible_com_1177242279);
            Font drawFont = new Font("Chiller", 20, FontStyle.Bold);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Pen blackPen = new Pen(Color.Black, 25);
            Pen orangePen = new Pen(Color.Orange, 25);
            Graphics g = this.CreateGraphics();

            g.DrawArc(orangePen, 260, 275, 275, 75, 0, 180);
            g.TranslateTransform(545, 375);
            g.RotateTransform(180);
            g.DrawArc(blackPen, 0, 0, 275, 75, 0, 180);
            g.ResetTransform();

            for (int i = 0; i < 40; i++)
            {
                player.Play();
                Thread.Sleep(1);
                g.Clear(Color.Black);
                g.FillEllipse(orangeBrush, 150, 50, 500, 350);
                g.FillPie(blackBrush, 250, 100, 150, 150, 180, 45);
                g.FillPie(blackBrush, 400, 100, 150, 150, 315, 45);
                g.FillPie(blackBrush, 350, 150, 100, 100, 60, 60);
                g.TranslateTransform(545, 375);
                g.RotateTransform(180);
                g.DrawArc(blackPen, 0, 0, 275, 75, 0, 180);
                g.ResetTransform();
                g.FillRectangle(blackBrush, 0, 0, 50 + move, 489);
                g.FillRectangle(blackBrush, 756 - move, 0, 50 + move, 489);
                g.FillRectangle(whiteBrush, 0 + move, 0, 50, 489);
                g.FillRectangle(whiteBrush, 756 - move, 0, 50, 489);
                g.FillEllipse(whiteBrush, 25 + move, -25, 50, 50);
                g.FillEllipse(whiteBrush, 25 + move, 420, 50, 50);
                g.FillEllipse(whiteBrush, 731 - move, -25, 50, 50);
                g.FillEllipse(whiteBrush, 731 - move, 420, 50, 50);
                g.FillEllipse(whiteBrush, -40 + move, -25, 50, 50);
                g.FillEllipse(whiteBrush, -40 + move, 420, 50, 50);
                g.FillEllipse(whiteBrush, 796 - move, -25, 50, 50);
                g.FillEllipse(whiteBrush, 796 - move, 420, 50, 50);
                move = move + 10;
            }
            player.Stop();
            for (int i = 0; i < 38; i++)
            {
                player.Play();
                Thread.Sleep(1);
                g.Clear(Color.Black);
                g.FillEllipse(whiteBrush, 225, 50, 350, 350);
                g.FillEllipse(blackBrush, 290, 125, 75, 125);
                g.FillEllipse(blackBrush, 440, 125, 75, 125);
                g.FillRectangle(blackBrush, 225, 280, 500, 50);
                g.FillRectangle(blackBrush, 0, 0, 756 - move, 489);
                g.FillRectangle(blackBrush, 0 + move, 0, 756 - move, 489);
                g.FillRectangle(whiteBrush, 0 + move, 0, 50, 489);
                g.FillRectangle(whiteBrush, 756 - move, 0, 50, 489);
                g.FillEllipse(whiteBrush, 25 + move, -25, 50, 50);
                g.FillEllipse(whiteBrush, 25 + move, 420, 50, 50);
                g.FillEllipse(whiteBrush, 731 - move, -25, 50, 50);
                g.FillEllipse(whiteBrush, 731 - move, 420, 50, 50);
                g.FillEllipse(whiteBrush, -40 + move, -25, 50, 50);
                g.FillEllipse(whiteBrush, -40 + move, 420, 50, 50);
                g.FillEllipse(whiteBrush, 796 - move, -25, 50, 50);
                g.FillEllipse(whiteBrush, 796 - move, 420, 50, 50);
                move = move + 10;
            }
            player.Stop();
            for (int i = 0; i < 30; i++)
            {
                drawFont = new Font("Chiller", size, FontStyle.Bold);

                player.Play();
                Thread.Sleep(2);
                g.Clear(Color.Black);
                g.FillEllipse(whiteBrush, 225, 50, 350, 350);
                g.FillEllipse(blackBrush, 290, 125, 75, 125);
                g.FillEllipse(blackBrush, 440, 125, 75, 125);
                g.FillRectangle(blackBrush, 225, 280, 500, 50);
                g.FillRectangle(whiteBrush, 0, 0, 50, 489);
                g.FillRectangle(whiteBrush, 756, 0, 50, 489);
                g.FillEllipse(whiteBrush, 25, -25, 50, 50);
                g.FillEllipse(whiteBrush, 25, 420, 50, 50);
                g.FillEllipse(whiteBrush, 731, -25, 50, 50);
                g.FillEllipse(whiteBrush, 731, 420, 50, 50);
                g.FillEllipse(whiteBrush, -40, -25, 50, 50);
                g.FillEllipse(whiteBrush, -40, 420, 50, 50);
                g.FillEllipse(whiteBrush, 796, -25, 50, 50);
                g.FillEllipse(whiteBrush, 796, 420, 50, 50);
                g.DrawString("Happy Halloween", drawFont, orangeBrush, 290, 280);
                size = size + 1;
            }
            player.Stop();
        }
       

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Font drawFont = new Font("Chiller", 30, FontStyle.Bold);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(Color.Black, 25);

            g.Clear(Color.Black);
            g.FillEllipse(orangeBrush, 150, 50, 500, 350);
            g.FillPie(blackBrush, 250, 100, 150, 150, 180, 45);
            g.FillPie(blackBrush, 400, 100, 150, 150, 315, 45);
            g.FillPie(blackBrush, 350, 150, 100, 100, 60, 60);
            g.DrawArc(blackPen, 260, 275, 275, 75, 0, 180);
            g.DrawString("Spooky", drawFont, whiteBrush, 350, 75);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;
using System.Threading;

namespace WildFireGDI
{
    public partial class MainForm : Form
    {
        Game game = null;
        Thread gameThread;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            if(game == null)
            {
                game = new Game(this);
                gameThread = (new Thread(new ThreadStart(game.GameThread)));
                gameThread.Start();
            }
            else
            {
                game._Canvas.Close();
                game = new Game(this);
                gameThread = (new Thread(new ThreadStart(game.GameThread)));
                gameThread.Start();

            }
            
  

        }

        private void checkBoxRandomWind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRandomWind.Checked)
                game.RANDOM_WIND = true;
            else
                game.RANDOM_WIND = false;
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            Point p = new Point(game._WIND.X, game._WIND.Y - 1);
            game._WIND = p;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            Point p = new Point(game._WIND.X, game._WIND.Y + 1);
            game._WIND = p;
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            Point p = new Point(game._WIND.X + 1, game._WIND.Y );
            game._WIND = p;
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            Point p = new Point(game._WIND.X - 1, game._WIND.Y);
            game._WIND = p;
        }

        private void buttonMiddle_Click(object sender, EventArgs e)
        {
            Point p = new Point(0,0);
            game._WIND = p;
        }

        private void trackBarWindSpeed_Scroll(object sender, EventArgs e)
        {

        }
    }
}

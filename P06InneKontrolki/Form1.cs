using P06InneKontrolki.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06InneKontrolki
{
    public partial class Form1 : Form
    {
        private Size domysleParametry;
        public Form1()
        {
            InitializeComponent();
            domysleParametry = pcKosz.Size;
        }

        private void pcKosz_Click(object sender, EventArgs e)
        {

        }

        private void pcKosz_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void pcKosz_MouseMove(object sender, MouseEventArgs e)
        {
            pcKosz.Width += 10;
            pcKosz.Height += 10;
        }

        private void pcKosz_MouseLeave(object sender, EventArgs e)
        {
            pcKosz.Size = domysleParametry;
        }

        private void btnPrzesunKosz_Click(object sender, EventArgs e)
        {
            timerSekunda.Enabled = !timerSekunda.Enabled;
            cbHistoria.Items.Add(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));

            pcKosz.Image = Resources._2891491; // ustawienie obraza z poziomu kodu 
            
        }

        private void timerSekunda_Tick(object sender, EventArgs e)
        {
            pcKosz.Left += 10;
        }
    }
}

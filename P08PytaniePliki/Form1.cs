using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P08PytaniePliki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            txtDane.Text = File.ReadAllText(txtSciezka.Text);   
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            File.WriteAllText(txtSciezka.Text, txtDane.Text);
        }

        private void txtSciezka_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "pliki tekstowe (*.txt)|*.txt|wszystkie pliki (*.*)|*.*";
            ofd.ShowDialog();
           
             
            txtSciezka.Text = ofd.FileName;
            //https://github.com/tomasz-trener/12DDzien4
        }
    }
}

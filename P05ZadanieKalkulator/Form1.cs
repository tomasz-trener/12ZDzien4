using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05ZadanieKalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJeden_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "1";
        }

        private void btnPrzycisk_Click(object sender, EventArgs e)
        {        
            //w sender siedzi przycisk 
            Button kliknietyPrzycisk = (Button)sender;
            txtWyswietlacz.Text += kliknietyPrzycisk.Text;


            InnaMetoda();
            InnaMetoda2();
        }

        private void InnaMetoda()
        {

        }

        private void InnaMetoda2()
        {

        }
        private void btnRownaSie_Click(object sender, EventArgs e)
        {
            Kalkulator k = new Kalkulator();

            try
            {
                double wynik = k.Policz(txtWyswietlacz.Text);
                txtWyswietlacz.Text = Convert.ToString(wynik);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message); // błędy ze środka mozmemy ewentualnie w bezpieczny sposób logowac do pliku lub bazy 
                MessageBox.Show("Niepoprawne równanie","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }
    }
}

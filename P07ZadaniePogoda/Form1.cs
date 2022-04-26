using P07ZadaniePogoda.Properties;
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

namespace P07ZadaniePogoda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (var m in File.ReadAllLines("miasta.txt"))
                cbMiasta.Items.Add(m); 

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Jednostka jd;
            if (rbCelcujesz.Checked)
                jd = Jednostka.Celcjusz;
            else if (rbFarenheit.Checked)
                jd = Jednostka.Farenheit;
            else if (rbKelvin.Checked)
                jd = Jednostka.Kelvin;
            else
                throw new Exception("Nieznana jednostka");

            try
            {
                ManagerPogody mp = new ManagerPogody();
                double temp = mp.PodajTemperature(cbMiasta.Text, Jednostka.Celcjusz);
                if (temp > 10)
                    pcObrazek.Image = Resources.sun;
                else if (temp < 0)
                    pcObrazek.Image = Resources.snow;
                else
                    pcObrazek.Image = Resources.cloud;

                //  double tmpWJednostce = mp.PodajTemperature(cbMiasta.Text, jd);
                double tmpWJednostce = new TransformatorJednostek().ZamienTemprature(mp.Temperatura, Jednostka.Celcjusz, jd);
                lblTemperatura.Text = String.Format("{0:0000.00}", tmpWJednostce);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem ze znaleizeniem temperatury. Podaj inne miasto", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }
    }
}

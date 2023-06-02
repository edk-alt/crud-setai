using SETAI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SETAI.funzioni;

namespace SETAI
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            this.ClientSize= Resources.pianta_setai.Size; 
        }

        private void btn_chiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prive_Click(object sender, EventArgs e)
        {

            nuovoTavolo.zona = "Privé";
            MessageBox.Show("Privé prenotato");
            prive.BackColor = Color.Red; 
        }

        private void zonaz_Click(object sender, EventArgs e)
        {
            nuovoTavolo.zona = "NORD-OVEST";
            MessageBox.Show("Tavolo selezionato");
            zonaz.BackColor = Color.Red;
        }


        private void zonax_Click(object sender, EventArgs e)
        {
            nuovoTavolo.zona = "SUD";
            MessageBox.Show("Tavolo selezionato");
            zonax.BackColor = Color.Red;

        }

        private void prive_MouseHover(object sender, EventArgs e)
        {
            prive.BackColor = Color.Blue;

        }

        private void prive_MouseLeave(object sender, EventArgs e)
        {
            prive.BackColor = Color.Transparent;
        }

        private void zonay_MouseHover(object sender, EventArgs e)
        {
            zonay.BackColor = Color.Blue;
        }

        private void zonay_MouseLeave(object sender, EventArgs e)
        {
            zonay.BackColor = Color.Transparent;
        }

        private void zonax_MouseHover(object sender, EventArgs e)
        {
            zonax.BackColor = Color.Blue;
        }

        private void zonax_MouseLeave(object sender, EventArgs e)
        {
            zonax.BackColor = Color.Transparent;
        }

        private void zonaz_MouseHover(object sender, EventArgs e)
        {
            zonaz.BackColor = Color.Blue;
        }

        private void zonaz_MouseLeave(object sender, EventArgs e)
        {
            zonaz.BackColor = Color.Transparent;
        }

        private void zonay_Click_1(object sender, EventArgs e)
        {
            nuovoTavolo.zona = "EST";
            MessageBox.Show("Tavolo selezionato");
            zonay.BackColor = Color.Red;
        }
    }
}

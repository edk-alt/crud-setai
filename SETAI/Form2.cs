﻿using SETAI.Properties;
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
            prive.ForeColor = Color.Blue;
        }

        private void zonaz_Click(object sender, EventArgs e)
        {
            nuovoTavolo.zona = "NORD-OVEST";
            MessageBox.Show("Tavolo selezionato");
            zonaz.BackColor = Color.Red;
            zonaz.ForeColor = Color.Blue;
        }

        private void zonay_Click(object sender, EventArgs e)
        {
            nuovoTavolo.zona = "EST";
            MessageBox.Show("Tavolo selezionato");
            zonay.BackColor = Color.Red;
            zonay.ForeColor = Color.Blue;
        }


        private void zonax_Click(object sender, EventArgs e)
        {
            nuovoTavolo.zona = "SUD";
            MessageBox.Show("Tavolo selezionato");
            zonax.BackColor = Color.Red;
            zonax.ForeColor = Color.Blue;
        }
    }
}

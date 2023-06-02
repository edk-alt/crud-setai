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
using static SETAI.Form3;
using System.Security.Cryptography.X509Certificates;

namespace SETAI
{
    public partial class Form1 : Form

    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_inserisci_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nome.Text) == true
                || string.IsNullOrEmpty(tb_tel.Text) == true
                || string.IsNullOrEmpty(tb_tavolo.Text) == true
                || string.IsNullOrEmpty(tb_persone.Text) == true
                || string.IsNullOrEmpty(tb_portate.Text) == true)
            {
                MessageBox.Show("inserire i dati");
                return;
            }

            //persone
            //portate
            //telefono

            if(int.TryParse(tb_tel.Text, out int tel) == false)
            {
                MessageBox.Show("Errore");
                return;
            }

            

            if (int.TryParse(tb_tel.Text, out int portate) == false)
            {
                MessageBox.Show("Errore");
                return;
            }

            string persone = tb_persone.Text;
            string nome = tb_nome.Text;
            string tavolo = tb_tavolo.Text;

            

            if (tel.ToString().Length < 1 || tel.ToString().Length > 10)
            {
                MessageBox.Show("Il numero di telefono deve avere 10 cifre");
                return;
            }
            if (int.Parse(persone) > 25)
            {
                MessageBox.Show("Le persone massime in un tavolo sono 25");
                return;
            }

            //public static Tavolo nuovoTavolo = default; in class1

            nuovoTavolo.nome = nome;
            nuovoTavolo.telefono = tel;
            nuovoTavolo.tavolone = tavolo;
            nuovoTavolo.persone = int.Parse(persone);
            nuovoTavolo.portate = portate;
            

            eleTavoli[num] = nuovoTavolo;
            num++;


            //tb_nome.Clear();
            //tb_tel.Clear();
            //tb_tavolo.Clear();
            //tb_persone.Clear();
            //tb_portate.Clear();
        }

        private void btn_visual_Click(object sender, EventArgs e)
        {
            lb.Items.Clear();
            funzioni.Visualizza(eleTavoli, num, lb);
        }

        private void btn_piantina_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btn_Fpers_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }        

        private void btn_elimina_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tavolo.Text) == true)
            {
                MessageBox.Show("Dati mancanti");
                return;
            }

            int k = funzioni.Elimina(eleTavoli, ref num, txt_tavolo.Text);

            MessageBox.Show("Dato eliminato");


        }

        private void lbl_user_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_user.Text = Program.UserScelto;
        }
    }
}





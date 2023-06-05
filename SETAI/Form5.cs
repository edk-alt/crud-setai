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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btn_salva_pers_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nome.Text) == true
                ||
                string.IsNullOrEmpty(txt_tavoloP.Text) == true
                ||
                string.IsNullOrEmpty(txt_telP.Text) == true)
            {
                MessageBox.Show("Dati da inserire");
                return;
            }

            if (int.TryParse(txt_telP.Text, out int tel) == false)
            {
                MessageBox.Show("Errore");
                return;

                //se il vsalore che ce dentro la tb è un intero, lo si mette dentro int tel
                //pero se è falsa la si mette dentro la MessBox
            }

            string nome = txt_nome.Text;
            string tavolo = txt_tavoloP.Text;

            int x = 0;
            while (x < num)
            {
                if (eleTavoli[x].tavolone != tavolo)
                {
                    MessageBox.Show("Tavolo non esistente, provare con un altro nome");
                    return;
                }

                x = x + 1;
            }

            Persona nuovodato = default;

            nuovodato.nome = nome;
            nuovodato.taavolino = tavolo;
            nuovodato.telefono = tel;

            elePersone[n] = nuovodato;
            n++;

            funzioni.VisualizzaPersone(elePersone, n, lb);
        }

    }
}


//nelle comunicazioni non si devono usare caratteri invisibili 
//base 64 codifica particolare che usa set caratteri asci visibili per codificare anche un set di cose invisibili 
//2 byte invisibile
//primo byte se visibile o invisibile
//secondo da carattere ero 

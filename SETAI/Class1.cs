using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SETAI
{
    public static class funzioni
    {
        public struct Login 
        {
            public string Username;
            public string password;
        }
        public static Login[] eleUtenti = new Login[100];
        public static int nn = 0;

        public struct Tavolo
        {
            public string nome;
            public int telefono;
            public string zona;
            public string tavolone;
            public int persone;
            public int portate;
            //struct dentro struct per avere persone dentro tavolo
            public Persona[] elePersoneTavolo;
            public string PR;
        }
        
        public static Tavolo[] eleTavoli = new Tavolo[100];
        public static int num = 0;



        //Globale
        public static Tavolo nuovoTavolo = default;


        public struct Persona
        {
            public string nome;
            public string taavolino;
            public int telefono;
        }

        public static Persona[] elePersone = new Persona[200];
        public static int n = 0;


        public static void Visualizza(Tavolo[] eleTavoli, int num, ListBox lb)
        {
            lb.Items.Clear();
            int x = 0;

            while (x < num)
            {
                string SUS = $"Nome: {eleTavoli[x].nome} - Telefono: {eleTavoli[x].telefono} - Zona: {eleTavoli[x].zona} -" +
                             $" Tavolo: {eleTavoli[x].tavolone} - " +
                             $"Portate: {eleTavoli[x].portate} - Persone: {eleTavoli[x].persone}";

                lb.Items.Add(SUS);
                x++;
            }

        }

        public static void VisualizzaPersone(Persona[] elep, int num, ListBox lb)
        {
            lb.Items.Clear();

            int x = 0;

            while (x < num)
            {
                string risul = $"Nome: {elePersone[x].nome} - Telefono: {elePersone[x].telefono} - Tavolo: {elePersone[x].taavolino}";

                lb.Items.Add(risul);
                x = x + 1;
            }
        }

        public static void Salva(Tavolo[] eleTavoli, int num, string filename)
        {
            string pathFile = "utenti.txt";
            StreamWriter miofile;
            miofile = new StreamWriter(pathFile);
            int x = 0;
            while (x < num)
            {
                Tavolo tmp = eleTavoli[x];
                miofile.WriteLine(tmp.nome);
                miofile.WriteLine(tmp.telefono);
                miofile.WriteLine(tmp.zona);
                miofile.WriteLine(tmp.tavolone);
                miofile.WriteLine(tmp.persone);
                miofile.WriteLine(tmp.portate);
                miofile.WriteLine(" ");
                x++;
            }
            miofile.Close();
            MessageBox.Show("Dati salvati con successo");
            
        }

        public static void Scrivi(Tavolo[] eleTavoli, ref int num, string filename, ListBox lb)
        {
            string pathFile = "utenti.txt";
            StreamReader miofile;
            miofile= new StreamReader(pathFile);

            while (num < 100 && miofile.EndOfStream == false)
            {
                Tavolo nuovodato = default;

                nuovodato.nome = miofile.ReadLine();
                nuovodato.telefono = int.Parse(miofile.ReadLine());
                nuovodato.zona = miofile.ReadLine();
                nuovodato.tavolone = miofile.ReadLine();
                nuovodato.persone = int.Parse(miofile.ReadLine());
                nuovodato.portate = int.Parse(miofile.ReadLine());
                miofile.ReadLine();

                eleTavoli[num] = nuovodato;
                num = num + 1;

            }
            funzioni.Visualizza(eleTavoli, num, lb);
            miofile.Close();
        }

        public static int Elimina(Tavolo[] eleTavoli, ref int num, string tavolo)
        {
            int x = 0;
            int y = 0;

            while (x < num)
            {
                if (eleTavoli[x].tavolone == tavolo)
                {
                    eleTavoli[x] = eleTavoli[num - 1];
                    num = num - 1;
                    x = x - 1;

                    y++;
                }
                x++;
            }

            return y;

        }

        public static int Cerca(Tavolo[] eleTavoli, ref int num, string tavolo)
        {
            int x = 0;
            int k = -1;

            while (x < num)
            {
                if (eleTavoli[x].tavolone == tavolo)
                {
                    k = x;
                }
                x++;
            }

            return k;
        }

        public static int Modifica(Tavolo[] eleTavoli, ref int num, string nome)
        {
            int x = 0;
            int K = -1;

            while (x < num)
            {
                if (eleTavoli[x].nome == nome)
                {
                    K = x;
                }
                x++;
            }

            return K;
        }

    }
}

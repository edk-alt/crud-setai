using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static SETAI.funzioni;
using System.Security.Cryptography;
using Newtonsoft.Json;

namespace SETAI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        #region Struct
        internal struct LoginAccount // struct for the accounts
        {
            public string UserName;
            public string Salt;
            public string HashPwd;
            public List<string> Claims { get; set; }
            public Dictionary<string, string> Preferences { get; set; }
        }
        #endregion

        #region Function
        LoginAccount FindUser(string username1, LoginAccount[] eleUtenti, int num)
        {   
            for (var x = 0; x < num; x++) 
            {
                if (String.Compare(eleUtenti[x].UserName, username1) == 0) 
                {
                    return eleUtenti[x];
                }
            }
            return default(LoginAccount);
        }

        public string GenerateSalt(int size)
        {
            StringBuilder sb = new StringBuilder();
            var randoNumberGenerator = RandomNumberGenerator.Create();

            var buff = new byte[size];
            randoNumberGenerator.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        public string GenerateHash(string input, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
            SHA256Managed sHA256Managed = new SHA256Managed();
            byte[] hash = sHA256Managed.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
        #endregion

        LoginAccount[] eleAccounts;
        int num = 0;

        private void btn_accedi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_registraUser.Text) == true ||
                string.IsNullOrEmpty(tb_registraPw.Text) == true)
            {
                MessageBox.Show("Inserire i dati nelle caselle");
                return;
            }


            string username = tb_user.Text;
            string password = tb_pw.Text;

            string user = tb_registraUser.Text;
            string pw = tb_registraPw.Text;

            eleAccounts = new LoginAccount[10];

            num = 0;
            {
                var newSalt = GenerateSalt(16); // generate a random salt
                var newHash = GenerateHash(pw, newSalt); // generate a hash from a string and a salt
                eleAccounts[num] = new LoginAccount // create a new account
                {
                    UserName = user, // set the username
                    Salt = newSalt, // set the salt
                    HashPwd = newHash, // set the hash
                    Claims = new List<string> { user }, // set the claims
                    Preferences = new Dictionary<string, string> { { "theme", "dark" } } // set the preferences
                };
                num = num + 1; // increase the counter
            }

            {
                var newSalt = GenerateSalt(16); // generate a random salt 
                var newHash = GenerateHash(pw, newSalt); // generate a hash from a string and a salt
                eleAccounts[num] = new LoginAccount
                {
                    UserName = user,
                    Salt = newSalt,
                    HashPwd = newHash,
                    Claims = new List<string> { user },
                    Preferences = new Dictionary<string, string> { { "theme", "light" } }
                };
                num = num + 1;
            }

            {
                var newSalt = GenerateSalt(16);
                var newHash = GenerateHash(pw, newSalt);

                eleAccounts[num] = new LoginAccount

                {
                    UserName = user,
                    Salt = newSalt,
                    HashPwd = newHash,
                    Claims = new List<string> { user },
                    Preferences = new Dictionary<string, string> { { "theme", "green" } }
                };
                num = num + 1;
                

            }

            // save to file ---------------------------------------------------------------
            File.WriteAllText("appAccounts.json", JsonConvert.SerializeObject(eleAccounts, Newtonsoft.Json.Formatting.Indented)); // save the array to a file

            MessageBox.Show("Account creato correttamente;");
            // FINE SETUP ---------------------------------------------------------------
        }

        private void btn_registra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_user.Text) == true
                ||
                string.IsNullOrEmpty(tb_pw.Text) == true)
            {
                MessageBox.Show("Inseririe dei dati nelle caselle di testo");
                return;
            }

            string user = tb_registraUser.Text;
            string pw = tb_registraPw.Text;

            //var eleAccounts = new LoginAccount[10];

            // INIZIO LOGIN ---------------------------------------------------------------

            
            eleAccounts = null; // reset the array

            if (!File.Exists("appAccounts.json")) // check if the file exists
            {
                MessageBox.Show("File utenti non trovato.");
                return;
            }

            eleAccounts = JsonConvert.DeserializeObject<LoginAccount[]>(File.ReadAllText("appAccounts.json")); // read the file

            // prova a controllare se il seguente utente è presente nel file
            //
            var userName = user;
            var pwd = pw; // vera password ---> adminPWD
                          // ---------------------------------------------------------------

            var actUser = FindUser(userName, eleAccounts, num); // cerca l'utente nell'array e se lo trova lo restituisce nella variabile actUser

            if (actUser.UserName != userName) // if the user is not found, exit
            {
                MessageBox.Show($"{userName} non trovato");
                return;
            }

            // ha trovato l'utente, ora controlla la password

            // use the salt in the file instead of the GenerateSalt function
            var hashImg = GenerateHash(pwd, actUser.Salt); // generate a hash from a string and a salt

            if (String.Compare(actUser.HashPwd, hashImg) != 0) // compare the hash with the hash in the file
            {
                Console.WriteLine("Password errata."); // if the hash is different, exit
                MessageBox.Show("Passowrd errata.");
                return;

            }
            else
            {
                MessageBox.Show("Utente riconosciuto");
                Form1 form1 = new Form1();
                form1.ShowDialog();
                return;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace MemoryGameTotal
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        //Username i Giriş ekranı formuna aktarmak için kullanılan değişken
        public static string uname;
        public static bool oturum;
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        //Giriş Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            //Database ile bağlantı kurma
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=accounts.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM users where username='" + textBox1.Text + "' AND pass='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                oturum = true; 
                //Giriş ekranındaki profil fotoğrafının üstündeki yazıyı kullanıcı adı ile dğeiştirme
                uname = textBox1.Text;
                Form1 frm1 = (Form1)Application.OpenForms["Form1"];
                //formları metod yardımıyle açtığmız için değiştirilen bir label olduğundan tekrar açmalıyız.
                frm1.panelEkrani(new Form5());            
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }

            con.Close();

        }

        //Şifreyi gizle göster butonu
        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
            
        }

        //Kayıt Ol butonu
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form signin = new signin();
            signin.ShowDialog();

        }
    }
}

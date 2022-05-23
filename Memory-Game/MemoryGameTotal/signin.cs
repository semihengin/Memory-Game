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
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }

        //Şifreyi gizle göster butonu
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '*')
            {
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '*';
            }
        }

        OleDbConnection con;
        OleDbCommand cmd;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=accounts.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into users (username,pass,isim) values ('" + txtuname.Text + "','" + txtpass.Text + "','" + txtname.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                tblolustur(txtuname.Text);
                MessageBox.Show("Kayıt tamamlandı.\nŞimdi giriş yapabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            catch (Exception hata)
            {
                MessageBox.Show("Kayıt sırasında bir sorun oluştu\nTekrar Deneyiniz." + hata.Message);
            }
  
        }
        private void tblolustur(string txtuname)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=accounts.accdb");
            con.Open();
            cmd = new OleDbCommand("CREATE TABLE " + txtuname + "(ID AUTOINCREMENT NOT NULL PRIMARY KEY,[oyun1] INTEGER NOT NULL, [oyun2] INTEGER NOT NULL)", con);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            cmd = new OleDbCommand("INSERT INTO " + txtuname + " (oyun2,oyun1) values('0','0')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

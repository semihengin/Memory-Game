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
    public partial class Form5 : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        int bestScore;
        int lastdk = 0, lastsn = 0;

        //Giriş Ekranı formu
        public Form5()
        {
            InitializeComponent();
        }

        //Giriş butonu
        private void button1_Click(object sender, EventArgs e)
        {
            Form login = new login();
            login.ShowDialog();
        }

        //Kayıt ol butonu
        private void button2_Click(object sender, EventArgs e)
        {
            Form signin = new signin();
            signin.ShowDialog();
        }

        //Giriş yaptıktan sonra profil resminin üstündeki 
        //labelin kullanıcı adına değişmesini sağlıyor.
        private void Form5_Load(object sender, EventArgs e)
        {
            saniyehesapla();
            label1.Text = Form6.oyun2lastskor.ToString();
            lbluname.Text = login.uname;
            if (lbluname.Text == "")
            {
                lbluname.Text = "Misafir Üye";
            }
            if(login.oturum == true)
            {
                //
                //En iyi skorlar groupbox'ının 
                //ayarlanması için kullanılan veritabanı işlemleri
                //
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=accounts.accdb");
                con.Open();
                //username adında oluşturulmuş accsess tablosundan
                //en yüksek skoru bulup tempskor adlı tabloya gönderir
                cmd = new OleDbCommand("SELECT Max(oyun2) AS highscore INTO tempskor FROM [" + login.uname + "]", con);
                cmd.ExecuteNonQuery();
                con.Close();
                //oluşturulan tempskor tablosundaki veriyi
                //Gerekli label a yazdırıyoruz.
                con.Open();
                cmd = new OleDbCommand("SELECT * FROM tempskor ", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bestScore = Convert.ToInt32(dr["highscore"]);
                }
                con.Close();
                //Ardından tempskor tablosunu siliyoruz.
                //Çünkü sql max sorgusu yapılırken tempskor adında yeni tablo oluşturmaya çalışıyor.
                //Eğer işimiz bittiğinde silmezsek
                //Yeni bir yüksek skoru tempskor tablosuna aktaramayız.
                con.Open();
                cmd = new OleDbCommand("DROP TABLE tempskor", con);
                cmd.ExecuteNonQuery();
                con.Close();
                //
                //
                button1.Visible = false;
                button2.Visible = false;            
            }
        }
        
        //profil fotoğrafı değiştirme butonu
        private void button3_Click(object sender, EventArgs e)
        {
            if(panel2.Visible == false) 
            { 
                panel2.Visible = true;
                button3.BackgroundImage = MemoryGameTotal.Properties.Resources.dropdownleft;
            }
            else 
            {
                panel2.Visible = false;
                button3.BackgroundImage = MemoryGameTotal.Properties.Resources.dropdownright;
            }
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            TempBox.BackgroundImage = pictureBox1.BackgroundImage;
            pictureBox1.BackgroundImage = pictureBox2.BackgroundImage;
            pictureBox2.BackgroundImage = TempBox.BackgroundImage;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TempBox.BackgroundImage = pictureBox1.BackgroundImage;
            pictureBox1.BackgroundImage = pictureBox3.BackgroundImage;
            pictureBox3.BackgroundImage = TempBox.BackgroundImage;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TempBox.BackgroundImage = pictureBox1.BackgroundImage;
            pictureBox1.BackgroundImage = pictureBox4.BackgroundImage;
            pictureBox4.BackgroundImage = TempBox.BackgroundImage;
        }

        private void saniyehesapla()
        {
            if (Form2.lastdk == "\0")
            {
                labeldk.Text = Form2.lastdk;
                labelsn.Text = Form2.lastsn;
            }
            while (Form2.lastskor > 60)
            {
                Form2.lastskor = Form2.lastskor / 60;
                lastdk++;
            }
            if (Form2.lastskor < 60)
            {
                lastsn = Form2.lastskor;
            }

            labeldk.Text = lastdk.ToString();
            labelsn.Text = lastsn.ToString();
        }
    }
}

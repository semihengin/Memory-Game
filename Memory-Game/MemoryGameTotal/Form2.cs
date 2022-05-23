using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//Veritabanı kütüphanesi

namespace MemoryGameTotal
{
    public partial class Form2 : Form
    {
        Random random = new Random();
        int i,dk,saniye;
        public static string lastdk;
        public static string lastsn;
        public static int lastskor;
       
        
        //Webdings yazı stilinde harfler iconlarla eşleştirilmiştir.
        //Bu listedeki harfler her bir iconu temsil eder.
        List<string> icons = new List<string>()
            {
                "a", "a", "b", "b", "d", "d", "e", "e",
                "f", "f", "h", "h", "i", "i", "j", "j"
            };

        //Kullanıcının ilk tıkladığını anı tespit etmek için kullanılan değişken
        //Timeri ayarlamk için kullanılır.
        Label firstClicked = null;

        //Kulanıcının ikinci tıkladığı anı tespit eder.
        Label secondClicked = null;

        private void simgeatama()
        {
            //
            //Her labela rastgele simge
            //atamak için kullanılan kısım
            //
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;  //iconları gizler
                    icons.RemoveAt(randomNumber);
                }
            }
        }


        public Form2()
        {
            InitializeComponent();
            simgeatama();
        }

        private void label_Click(object sender, EventArgs e)
        {

            timer2.Start();

            //timer1 çalışıyorsa iki farklı sembol seçilmiş demektir
            //Bu sıradaki tıklamaları işleme girmesini engellemek için
            //bu kısım devreye giriyor.
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Red)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Red;
                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Red;

                //Sembollerin doğruluk kontrolü burada yapılır
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    i++;
                    //Oyunun bittiğini belirleyen
                    //if kısmı
                    if (i == 8)
                    {
                        timer2.Stop();
                        Form gover = new kullanici();
                        gover.ShowDialog();
                        if(login.oturum == true)
                        {
                            skorkaydet();
                        }
                        
                    }
                    return;
                }

                timer1.Start();
            }
        }

        //İki farklı sembol olduğunda ikisini de
        //Tekrar gizlemek için timer kullanıyoruz.
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            //Tıklananları gizler
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        //Genel süreyi hesaplar
        private void timer2_Tick(object sender, EventArgs e)
        {
            saniye++;
            lastskor++;
            if(saniye == 60)
            {
                dk++;
                saniye = 0;
            }
            if(saniye < 10)
            {
                labelsn.Text = Convert.ToString("0" + saniye);
                lastsn = labelsn.Text;
            }
            else
            {
                labelsn.Text = Convert.ToString("" + saniye);
                lastsn = labelsn.Text;
            }
            
            labeldk.Text = Convert.ToString("0" + dk);
            lastdk = labeldk.Text;

        }
        

        OleDbConnection con;
        OleDbCommand cmd;

        //
        //Skorları veri tabanına işler
        //
        private void skorkaydet()
        {
            try
            {
                //veritabanı bağlantısı ile bağlantı kuran değişken
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=accounts.accdb");
                con.Open();
                //veritabanında sorgu komutunu atadığımzı değişken
                //Tablo oluşturduk
                cmd = new OleDbCommand("CREATE TABLE " + login.uname + "(ID AUTOINCREMENT NOT NULL PRIMARY KEY,[oyun1] INTEGER NOT NULL, [oyun2] INTEGER NOT NULL)", con);
                cmd.ExecuteNonQuery();
                con.Close();
                con.Open();
                //Tabloya kayıt ekledik
                cmd = new OleDbCommand("INSERT INTO " + login.uname + " (oyun2,oyun1) values('0','" + lastskor + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            //Tablo varsa bu kod bloğuna girer.
            catch (OleDbException)
            {

                //Kullanıcı ismiyle oluşturulan tabloya 
                //oyun1nin skorunu ekler
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=accounts.accdb");
                cmd = new OleDbCommand("INSERT INTO " + login.uname + " (oyun2,oyun1) values('0','" + lastskor + "')", con);
                con.Open();
                //Sorguyu gerçekleştiriyoruz.
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}

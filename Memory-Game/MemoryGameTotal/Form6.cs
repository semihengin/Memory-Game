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
    public partial class Form6 : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        Random rastgele = new Random();
        int i = 5;
        int lvlCounter = 1;
        int Skor = 0;
        public static int oyun2lastskor;

        public Form6()
        {
            InitializeComponent();
        }

        //Başlat butonu yazmamız gereken sayıları rastgele atıyor
        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
            int sayi = rastgele.Next(0, 50);
            label1.Text = sayi.ToString();
            sayi = rastgele.Next(0, 50);
            label2.Text = sayi.ToString();
            sayi = rastgele.Next(0, 50);
            label3.Text = sayi.ToString();
            sayi = rastgele.Next(0, 50);
            label4.Text = sayi.ToString();
            sayi = rastgele.Next(0, 50);
            label5.Text = sayi.ToString();
            sayi = rastgele.Next(0, 50);
            label6.Text = sayi.ToString();
            sayi = rastgele.Next(0, 50);
            label7.Text = sayi.ToString();
            sayi = rastgele.Next(0, 50);
            label8.Text = sayi.ToString();
            sayi = rastgele.Next(0, 50);
            label9.Text = sayi.ToString();
            start.Visible = false;
            pnlLabel.Visible = true;
            okay.Visible = true;
            show.Visible = true;

        }

        //Tamam butonu  
        private void okay_Click(object sender, EventArgs e)
        {
            show.Visible = true;

            //Doğruluk kontrolü
            if (kontrol(lvlCounter) == true)
            {
                ++lvlCounter;
                lbllevel1.Text = lvlCounter.ToString();
                lvlDesign(lvlCounter);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            --i;
            label11.Text = i.ToString();
            if (i == 0)
            {
                pnlLabel.Visible = false;
                i = 5;
                timer1.Stop();
            }
        }

        //Tekrar göster butonu
        private void show_Click(object sender, EventArgs e)
        {
            Skor = Skor - 2;
            label11.Text = "5";
            pnlLevel5.Visible = false;
            pnlLabel.Visible = true;
            timer1.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pnlLabel.Visible = true;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            okay.Visible = false;
            pnlLevel5.Visible = false;
        }

        //Levele göre zorluğu artırmak için 
        //kullandığımız method
        private void lvlDesign(int lvlCounter)
        {
            if (lvlCounter > 2 && lvlCounter <= 5)
            {
                pnlLevel1.Visible = false;
                pnlLevel3.Visible = true;
                //
                label2.Visible = false;
                label5.Visible = false;
                label8.Visible = false;
                //
                label1.Visible = true;
                label3.Visible = true;
                label7.Visible = true;
                label9.Visible = true;
                //
            }
            else if (lvlCounter > 5 && lvlCounter <= 9)
            {
                pnlLevel3.Visible = false;
                pnlLevel5.Visible = true;
                //
                label2.Visible = true;
                label5.Visible = true;
                label8.Visible = true;
                //
            }
            else
            {
                pnlLevel5.Visible = false;
                pnlLevel3.Visible = false;
                pnlLevel1.Visible = true;
                //
                label2.Visible = true;
                label5.Visible = true;
                label8.Visible = true;
                //
                label1.Visible = false;
                label3.Visible = false;
                label7.Visible = false;
                label9.Visible = false;
                //
                start.Visible = true;
                show.Visible = false;
                
            }
        }

        //Doğruluk kontrolü bu method da yapılır.
        //Levele bağlı olarak kontrol sağlanır.
        private bool kontrol(int lvlCounter)
        {
            if (lvlCounter <= 2)
            {
                if (label2.Text == textBox16.Text && label4.Text == textBox18.Text && label5.Text == textBox11.Text && label6.Text == textBox17.Text && label8.Text == textBox12.Text)
                {
                    MessageBox.Show("Doğru");
                    Skor = Skor + 15;

                    lblskor.Text = Skor.ToString();
                    start.Visible = true;
                    show.Visible = false;
                    clear();
                    return true;
                }
                else
                {
                    gameover();
                    return false;
                }

            }
            else if (lvlCounter > 2 && lvlCounter <= 5)
            {
                if (label1.Text == textBox23.Text && label4.Text == textBox21.Text && label7.Text == textBox14.Text && label6.Text == textBox19.Text && label3.Text == textBox22.Text && label9.Text == textBox13.Text)
                {
                    MessageBox.Show("Doğru");

                    Skor = Skor + 30;
                    lblskor.Text = Skor.ToString();
                    start.Visible = true;
                    show.Visible = false;
                    clear();
                    return true;
                }
                else
                {
                    gameover();
                    return false;
                }
            }
            else
            {
                if (label1.Text == textBox1.Text && label2.Text == textBox2.Text && label3.Text == textBox3.Text && label4.Text == textBox4.Text && label5.Text == textBox5.Text && label6.Text == textBox6.Text && label7.Text == textBox7.Text && label8.Text == textBox8.Text && label9.Text == textBox9.Text)
                {
                    Skor = Skor + 50;
                    lblskor.Text = Skor.ToString();
                    start.Visible = true;
                    show.Visible = false;
                    clear();
                    return true;
                }
                else
                {
                    gameover();
                    return false;
                }
            }

        }

        //Yazılmış karakterleri silmek için kullanılan method
        private void clear()
        {
            //
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            //
            textBox23.Text = "";
            textBox21.Text = "";
            textBox17.Text = "";
            textBox16.Text = "";
            textBox19.Text = "";
            textBox22.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            //
            textBox16.Text = "";
            textBox18.Text = "";
            textBox11.Text = "";
            textBox17.Text = "";
            textBox12.Text = "";
            //
        }        

        //Oyun bittiğinde skorları veritabanına işleyip
        //oyunu tekrar oynanabilecek hale getirir.
        private void gameover()
        {
            //son oyun skorunu diğer forma aktarabilmek için
            oyun2lastskor = Skor;
            //
            MessageBox.Show("Oyun Bitti");
            if(login.oturum == true)
            {
                //
                //Skor kaydetme bölümü
                //
                //Tablo yoksa oluşturur.
                try
                {
                    con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=accounts.accdb");
                    con.Open();
                    cmd = new OleDbCommand("CREATE TABLE " + login.uname + "(ID AUTOINCREMENT NOT NULL PRIMARY KEY,[oyun1] INTEGER NOT NULL, [oyun2] INTEGER NOT NULL)", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.Open();
                    cmd = new OleDbCommand("INSERT INTO " + login.uname + " (oyun1,oyun2) values('0','" + Skor + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                //Tablo varsa bu kod bloğuna girer.
                catch (OleDbException)
                {
                   
                    //Kullanıcı ismiyle oluşturulan tabloya 
                    //oyun2nin skorunu ekler
                    con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=accounts.accdb");
                    cmd = new OleDbCommand("INSERT INTO " + login.uname + " (oyun1,oyun2) values('0','" + Skor + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            lvlCounter = 1;
            Skor = 0;
            lbllevel1.Text = lvlCounter.ToString();
            lblskor.Text = Skor.ToString();
            lvlDesign(lvlCounter);
            clear();
        }
    }
}

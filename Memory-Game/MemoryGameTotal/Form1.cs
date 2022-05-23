using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;             //Semih Engin 191180037 Memory Games

namespace MemoryGameTotal
{                           
    public partial class Form1 : Form
    {
        //Main Form
        public Form1()
        {
            InitializeComponent();
            panelEkrani(new Form5());
            MenuGizle();
        }

        //Altmenüleri gizleyen metot
        public void MenuGizle()
        {
            pnlOyunMenu.Visible = false;
        }
        
        //Altmenüleri açıp kapatan metot
        private void MenuGoster(Panel altmenu)
        {
            
            if (altmenu.Visible == false)
            {
                MenuGizle();
                altmenu.Visible = true;
            }
            else
                altmenu.Visible = false;
        }

        //Program çalışıyorken açık olan formun bağlı olduğu değişken
        private Form activeForm = null;

        //joker panelde gösterilecek formu belirler
        public void panelEkrani(Form jokerform)    
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = jokerform;
            
            jokerform.TopLevel = false;
            jokerform.FormBorderStyle = FormBorderStyle.None; //Çerçevenin olmaması
            jokerform.Dock = DockStyle.Fill;       //Formun, paneli doldurması ayarı (responsive)
            pnlJokerForm.Controls.Add(jokerform);
            pnlJokerForm.Tag = jokerform;
            jokerform.BringToFront();   //formu öne çıkarır
            jokerform.Show();   //ekrana getirir.
        }

        //Oyunlar altmenüsünü açan OYunlar butonu
        private void btnGames_Click(object sender, EventArgs e)
        {
            MenuGoster(pnlOyunMenu);
        }
        //Çıkış Butonu
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        //Kart Eşleştirme oyunu butonu
        private void button5_Click(object sender, EventArgs e)
        {
            panelEkrani(new Form2());
            MenuGizle();
        }

        
        //Nasıl oynanır Butonu
        private void btninfo_Click(object sender, EventArgs e)
        {
            panelEkrani(new nasiloynanir());
            MenuGizle();
        }

        //Sayı Tahmin oyunu butonu
        private void button4_Click(object sender, EventArgs e)
        {
            panelEkrani(new Form6());
            MenuGizle();
        }

        //Ana Menü Butonu
        private void home_Click(object sender, EventArgs e)
        {
            panelEkrani(new Form5());
            MenuGizle();
        }
    }
}

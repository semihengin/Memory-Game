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
    public partial class kullanici : Form
    {
        public kullanici()
        {
           InitializeComponent();
           labeldk.Text = Form2.lastdk;
           labelsn.Text = Form2.lastsn;
        }

        private void kullanici_Load(object sender, EventArgs e)
        { 

        }
        //
        //Terar Dene butonu
        //
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.panelEkrani(new Form2());
            frm1.MenuGizle();
            this.Close();
        }
        //
        //Ana sayfa butonu
        //
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.panelEkrani(new Form5());
            frm1.MenuGizle();
            this.Close();
        }
    }
}

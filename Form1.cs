using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tasKagitMakas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string bilgisayarSecim = null;
        string kisiSecim = null;

        Random rst = new Random();
 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void secimYap(string secim)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = rst.Next(0,3);

            if(sayi == 0) { bilgisayarSecim = "tas"; }
            else if(sayi == 1) { bilgisayarSecim = "kagit"; }
            else { bilgisayarSecim = "makas";  }

            
        }
    }
}
